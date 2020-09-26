module.exports = {
    base: {
        // Do not perform lookup in this directories.
        // MUST be relative to `src` directory.
        exclude: [
        ]
    },
    development: {
        // Build path can be both relative or absolute.
        buildPath: './wwwroot',

        // Minify assets.
        minify: false,

        // Generate sourcemaps.
        sourcemaps: false,
        // https://webpack.js.org/configuration/devtool/#development
        devtool: 'eval-source-map',

        // Remove sourcemaps, *.dist.js and *.dist.css files before build
        cleanBuild: false
    },
    production: {
        // Build path can be both relative or absolute.
        buildPath: './wwwroot',

        // Minify assets.
        // Note: Webpack will minify js sources in production mode regardless to this option
        minify: true,

        // Generate sourcemaps.
        sourcemaps: false,
        // https://webpack.js.org/configuration/devtool/#production
        devtool: '#source-map',

        // Remove sourcemaps, *.dist.js and *.dist.css files before build
        cleanBuild: false
    }
}
