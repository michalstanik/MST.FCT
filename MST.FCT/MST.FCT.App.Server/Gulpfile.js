const path = require('path')

// -------------------------------------------------------------------------------
// Config

const env = require('gulp-environment')

process.env.NODE_ENV = env.current.name

const conf = (() => {
    const _conf = require('./build-config')
    return require('deepmerge').all([{}, _conf.base || {}, _conf[process.env.NODE_ENV] || {}])
})()

conf.buildPath = path.resolve(__dirname, conf.buildPath).replace(/\\/g, '/')

// -------------------------------------------------------------------------------
// Modules

const { src, dest, parallel, series, watch } = require('gulp')
const webpack = require('webpack')
const sass = require('gulp-sass')
const autoprefixer = require('gulp-autoprefixer')
const rename = require('gulp-rename')
const gulpIf = require('gulp-if')
const sourcemaps = require('gulp-sourcemaps')
const del = require('del')
const colors = require('ansi-colors')
const log = require('fancy-log')

sass.compiler = require('node-sass')
colors.enabled = require('color-support').hasBasic

// -------------------------------------------------------------------------------
// Utilities

function normalize(p) {
    return p.replace(/\\/g, '/')
}

function root(p) {
    return p.startsWith('!') ?
        normalize(`!${path.join(__dirname, 'wwwroot', p.slice(1))}`) :
        normalize(path.join(__dirname, 'wwwroot', p))
}

function getSrc(...src) {
    return src.map(p => root(p)).concat(conf.exclude.map(d => `!${root(d)}/**/*`))
}

// -------------------------------------------------------------------------------
// Clean build directory

const cleanTask = function () {
    return del([
        `${conf.buildPath}/**/*.dist.js`,
        `${conf.buildPath}/**/*.dist.css`,
        `!${conf.buildPath}/vendor/fonts/*.dist.css`
    ], {
        force: true
    })
}

const cleanSourcemapsTask = function () {
    return del([`${conf.buildPath}/**/*.map`], {
        force: true
    })
}

const cleanAllTask = parallel(cleanTask, cleanSourcemapsTask)

// -------------------------------------------------------------------------------
// Build css

const buildCssTask = function () {
    return src(getSrc('**/*.scss', '!**/_*.scss'), { base: root('.') })

        .pipe(gulpIf(conf.sourcemaps, sourcemaps.init()))
        .pipe(sass({
            outputStyle: conf.minify ? 'compressed' : 'nested'
        }).on('error', sass.logError))
        .pipe(gulpIf(conf.sourcemaps, sourcemaps.write()))

        .pipe(gulpIf(conf.sourcemaps, sourcemaps.init({
            loadMaps: true
        })))
        .pipe(autoprefixer({
            overrideBrowserslist: [
                '>= 1%',
                'last 2 versions',
                'not dead',
                'Chrome >= 45',
                'Firefox >= 38',
                'Edge >= 12',
                'Explorer >= 10',
                'iOS >= 9',
                'Safari >= 9',
                'Android >= 4.4',
                'Opera >= 30'
            ]
        }))
        .pipe(rename({ extname: '.dist.css' }))
        .pipe(gulpIf(conf.sourcemaps, sourcemaps.write()))

        .pipe(dest(conf.buildPath))
}

// -------------------------------------------------------------------------------
// Build js

const buildJsTask = function (cb) {
    setTimeout(function () {
        webpack(require('./webpack.config'), (err, stats) => {
            if (err) {
                log(colors.gray('Webpack error:'), colors.red(err.stack || err))
                if (err.details) log(colors.gray('Webpack error details:'), err.details)
                return cb()
            }

            const info = stats.toJson()

            if (stats.hasErrors()) {
                info.errors.forEach(e => log(colors.gray('Webpack compilation error:'), colors.red(e)))
            }

            if (stats.hasWarnings()) {
                info.warnings.forEach(w => log(colors.gray('Webpack compilation warning:'), colors.yellow(w)))
            }

            // Print log
            log(stats.toString({
                colors: colors.enabled,
                hash: false,
                timings: false,
                chunks: false,
                chunkModules: false,
                modules: false,
                children: true,
                version: true,
                cached: false,
                cachedAssets: false,
                reasons: false,
                source: false,
                errorDetails: false
            }))

            cb()
        })
    }, 1)
}

// -------------------------------------------------------------------------------
// Watch

const watchTask = function () {
    watch(getSrc('**/*.scss'), buildCssTask)
    watch(getSrc('**/*.js', '!**/*.dist.js'), buildJsTask)
}

// -------------------------------------------------------------------------------
// Build

const buildTasks = [
    buildCssTask,
    buildJsTask
]

const buildTask = conf.cleanBuild ?
    series(cleanAllTask, parallel(buildTasks)) :
    series(cleanSourcemapsTask, parallel(buildTasks))

// -------------------------------------------------------------------------------
// Exports

module.exports = {
    default: buildTask,
    clean: cleanAllTask,
    build: buildTask,
    'build:js': buildJsTask,
    'build:css': buildCssTask,
    watch: watchTask
}
