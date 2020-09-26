(function(e, a) { for(var i in a) e[i] = a[i]; }(window, /******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./wwwroot/vendor/libs/bootstrap-table/extensions/pipeline/pipeline.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./node_modules/bootstrap-table/src/extensions/pipeline/bootstrap-table-pipeline.js":
/*!******************************************************************************************!*\
  !*** ./node_modules/bootstrap-table/src/extensions/pipeline/bootstrap-table-pipeline.js ***!
  \******************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

eval("/**\n * @author doug-the-guy\n * @version v1.0.0\n *\n * Bootstrap Table Pipeline\n * -----------------------\n *\n * This plugin enables client side data caching for server side requests which will\n * eliminate the need to issue a new request every page change. This will allow\n * for a performance balance for a large data set between returning all data at once\n * (client side paging) and a new server side request (server side paging).\n *\n * There are two new options:\n *  - usePipeline: enables this feature\n *  - pipelineSize: the size of each cache window\n *\n * The size of the pipeline must be evenly divisible by the current page size. This is\n * assured by rounding up to the nearest evenly divisible value. For example, if\n * the pipeline size is 4990 and the current page size is 25, then pipeline size will\n * be dynamically set to 5000.\n *\n * The cache windows are computed based on the pipeline size and the total number of rows\n * returned by the server side query. For example, with pipeline size 500 and total rows\n * 1300, the cache windows will be:\n *\n *  [{'lower': 0, 'upper': 499}, {'lower': 500, 'upper': 999}, {'lower': 1000, 'upper': 1499}]\n *\n * Using the limit (i.e. the pipelineSize) and offset parameters, the server side request\n * **MUST** return only the data in the requested cache window **AND** the total number of rows.\n * To wit, the server side code must use the offset and limit parameters to prepare the response\n * data.\n *\n * On a page change, the new offset is checked if it is within the current cache window. If so,\n * the requested page data is returned from the cached data set. Otherwise, a new server side\n * request will be issued for the new cache window.\n *\n * The current cached data is only invalidated on these events:\n *  * sorting\n *  * searching\n *  * page size change\n *  * page change moves into a new cache window\n *\n * There are two new events:\n *  - cached-data-hit.bs.table: issued when cached data is used on a page change\n *  - cached-data-reset.bs.table: issued when the cached data is invalidated and a\n *      new server side request is issued\n *\n **/\nvar Utils = $.fn.bootstrapTable.utils;\n$.extend($.fn.bootstrapTable.defaults, {\n  usePipeline: false,\n  pipelineSize: 1000,\n  onCachedDataHit: function onCachedDataHit(data) {\n    return false;\n  },\n  onCachedDataReset: function onCachedDataReset(data) {\n    return false;\n  }\n});\n$.extend($.fn.bootstrapTable.Constructor.EVENTS, {\n  'cached-data-hit.bs.table': 'onCachedDataHit',\n  'cached-data-reset.bs.table': 'onCachedDataReset'\n});\nvar BootstrapTable = $.fn.bootstrapTable.Constructor;\nvar _init = BootstrapTable.prototype.init;\nvar _initServer = BootstrapTable.prototype.initServer;\nvar _onSearch = BootstrapTable.prototype.onSearch;\nvar _onSort = BootstrapTable.prototype.onSort;\nvar _onPageListChange = BootstrapTable.prototype.onPageListChange;\n\nBootstrapTable.prototype.init = function () {\n  // needs to be called before initServer()\n  this.initPipeline();\n\n  for (var _len = arguments.length, args = new Array(_len), _key = 0; _key < _len; _key++) {\n    args[_key] = arguments[_key];\n  }\n\n  _init.apply(this, Array.prototype.slice.apply(args));\n};\n\nBootstrapTable.prototype.initPipeline = function () {\n  this.cacheRequestJSON = {};\n  this.cacheWindows = [];\n  this.currWindow = 0;\n  this.resetCache = true;\n};\n\nBootstrapTable.prototype.onSearch = function (event) {\n  /* force a cache reset on search */\n  if (this.options.usePipeline) {\n    this.resetCache = true;\n  }\n\n  _onSearch.apply(this, Array.prototype.slice.apply(arguments));\n};\n\nBootstrapTable.prototype.onSort = function (event) {\n  /* force a cache reset on sort */\n  if (this.options.usePipeline) {\n    this.resetCache = true;\n  }\n\n  _onSort.apply(this, Array.prototype.slice.apply(arguments));\n};\n\nBootstrapTable.prototype.onPageListChange = function (event) {\n  /* rebuild cache window on page size change */\n  var target = $(event.currentTarget);\n  var newPageSize = parseInt(target.text());\n  this.options.pipelineSize = this.calculatePipelineSize(this.options.pipelineSize, newPageSize);\n  this.resetCache = true;\n\n  _onPageListChange.apply(this, Array.prototype.slice.apply(arguments));\n};\n\nBootstrapTable.prototype.calculatePipelineSize = function (pipelineSize, pageSize) {\n  /* calculate pipeline size by rounding up to the nearest value evenly divisible\n        * by the pageSize */\n  if (pageSize === 0) return 0;\n  return Math.ceil(pipelineSize / pageSize) * pageSize;\n};\n\nBootstrapTable.prototype.setCacheWindows = function () {\n  /* set cache windows based on the total number of rows returned by server side\n        * request and the pipelineSize */\n  this.cacheWindows = [];\n  var numWindows = this.options.totalRows / this.options.pipelineSize;\n\n  for (var i = 0; i <= numWindows; i++) {\n    var b = i * this.options.pipelineSize;\n    this.cacheWindows[i] = {\n      'lower': b,\n      'upper': b + this.options.pipelineSize - 1\n    };\n  }\n};\n\nBootstrapTable.prototype.setCurrWindow = function (offset) {\n  /* set the current cache window index, based on where the current offset falls */\n  this.currWindow = 0;\n\n  for (var i = 0; i < this.cacheWindows.length; i++) {\n    if (this.cacheWindows[i].lower <= offset && offset <= this.cacheWindows[i].upper) {\n      this.currWindow = i;\n      break;\n    }\n  }\n};\n\nBootstrapTable.prototype.drawFromCache = function (offset, limit) {\n  /* draw rows from the cache using offset and limit */\n  var res = $.extend(true, {}, this.cacheRequestJSON);\n  var drawStart = offset - this.cacheWindows[this.currWindow].lower;\n  var drawEnd = drawStart + limit;\n  res.rows = res.rows.slice(drawStart, drawEnd);\n  return res;\n};\n\nBootstrapTable.prototype.initServer = function (silent, query, url) {\n  /* determine if requested data is in cache (on paging) or if\n        * a new ajax request needs to be issued (sorting, searching, paging\n        * moving outside of cached data, page size change)\n        * initial version of this extension will entirely override base initServer\n        **/\n  var data = {};\n  var index = this.header.fields.indexOf(this.options.sortName);\n  var params = {\n    searchText: this.searchText,\n    sortName: this.options.sortName,\n    sortOrder: this.options.sortOrder\n  };\n  var request = null;\n\n  if (this.header.sortNames[index]) {\n    params.sortName = this.header.sortNames[index];\n  }\n\n  if (this.options.pagination && this.options.sidePagination === 'server') {\n    params.pageSize = this.options.pageSize === this.options.formatAllRows() ? this.options.totalRows : this.options.pageSize;\n    params.pageNumber = this.options.pageNumber;\n  }\n\n  if (!(url || this.options.url) && !this.options.ajax) {\n    return;\n  }\n\n  var useAjax = true;\n\n  if (this.options.queryParamsType === 'limit') {\n    params = {\n      searchText: params.searchText,\n      sortName: params.sortName,\n      sortOrder: params.sortOrder\n    };\n\n    if (this.options.pagination && this.options.sidePagination === 'server') {\n      params.limit = this.options.pageSize === this.options.formatAllRows() ? this.options.totalRows : this.options.pageSize;\n      params.offset = (this.options.pageSize === this.options.formatAllRows() ? this.options.totalRows : this.options.pageSize) * (this.options.pageNumber - 1);\n\n      if (this.options.usePipeline) {\n        // if cacheWindows is empty, this is the initial request\n        if (!this.cacheWindows.length) {\n          useAjax = true;\n          params.drawOffset = params.offset; // cache exists: determine if the page request is entirely within the current cached window\n        } else {\n          var w = this.cacheWindows[this.currWindow]; // case 1: reset cache but stay within current window (e.g. column sort)\n          // case 2: move outside of the current window (e.g. search or paging)\n          //  since each cache window is aligned with the current page size\n          //  checking if params.offset is outside the current window is sufficient.\n          //  need to requery for preceding or succeeding cache window\n          //  also handle case\n\n          if (this.resetCache || params.offset < w.lower || params.offset > w.upper) {\n            useAjax = true;\n            this.setCurrWindow(params.offset); // store the relative offset for drawing the page data afterwards\n\n            params.drawOffset = params.offset; // now set params.offset to the lower bound of the new cache window\n            // the server will return that whole cache window\n\n            params.offset = this.cacheWindows[this.currWindow].lower; // within current cache window\n          } else {\n            useAjax = false;\n          }\n        }\n      } else {\n        if (params.limit === 0) {\n          delete params.limit;\n        }\n      }\n    }\n  } // force an ajax call - this is on search, sort or page size change\n\n\n  if (this.resetCache) {\n    useAjax = true;\n    this.resetCache = false;\n  }\n\n  if (this.options.usePipeline && useAjax) {\n    /* in this scenario limit is used on the server to get the cache window\n            * and drawLimit is used to get the page data afterwards */\n    params.drawLimit = params.limit;\n    params.limit = this.options.pipelineSize;\n  } // cached results can be used\n\n\n  if (!useAjax) {\n    var res = this.drawFromCache(params.offset, params.limit);\n    this.load(res);\n    this.trigger('load-success', res);\n    this.trigger('cached-data-hit', res);\n    return;\n  } // cached results can't be used\n  // continue base initServer code\n\n\n  if (!$.isEmptyObject(this.filterColumnsPartial)) {\n    params.filter = JSON.stringify(this.filterColumnsPartial, null);\n  }\n\n  data = Utils.calculateObjectValue(this.options, this.options.queryParams, [params], data);\n  $.extend(data, query || {}); // false to stop request\n\n  if (data === false) {\n    return;\n  }\n\n  if (!silent) {\n    this.$tableLoading.show();\n  }\n\n  var self = this;\n  request = $.extend({}, Utils.calculateObjectValue(null, this.options.ajaxOptions), {\n    type: this.options.method,\n    url: url || this.options.url,\n    data: this.options.contentType === 'application/json' && this.options.method === 'post' ? JSON.stringify(data) : data,\n    cache: this.options.cache,\n    contentType: this.options.contentType,\n    dataType: this.options.dataType,\n    success: function success(res) {\n      res = Utils.calculateObjectValue(self.options, self.options.responseHandler, [res], res); // cache results if using pipelining\n\n      if (self.options.usePipeline) {\n        // store entire request in cache\n        self.cacheRequestJSON = $.extend(true, {}, res); // this gets set in load() also but needs to be set before\n        // setting cacheWindows\n\n        self.options.totalRows = res[self.options.totalField]; // if this is a search, potentially less results will be returned\n        // so cache windows need to be rebuilt. Otherwise it\n        // will come out the same\n\n        self.setCacheWindows();\n        self.setCurrWindow(params.drawOffset); // just load data for the page\n\n        res = self.drawFromCache(params.drawOffset, params.drawLimit);\n        self.trigger('cached-data-reset', res);\n      }\n\n      self.load(res);\n      self.trigger('load-success', res);\n      if (!silent) self.$tableLoading.hide();\n    },\n    error: function error(res) {\n      var data = [];\n\n      if (self.options.sidePagination === 'server') {\n        data = {};\n        data[self.options.totalField] = 0;\n        data[self.options.dataField] = [];\n      }\n\n      self.load(data);\n      self.trigger('load-error', res.status, res);\n      if (!silent) self.$tableLoading.hide();\n    }\n  });\n\n  if (this.options.ajax) {\n    Utils.calculateObjectValue(this, this.options.ajax, [request], null);\n  } else {\n    if (this._xhr && this._xhr.readyState !== 4) {\n      this._xhr.abort();\n    }\n\n    this._xhr = $.ajax(request);\n  }\n};\n\n//# sourceURL=webpack:///./node_modules/bootstrap-table/src/extensions/pipeline/bootstrap-table-pipeline.js?");

/***/ }),

/***/ "./wwwroot/vendor/libs/bootstrap-table/extensions/pipeline/pipeline.js":
/*!*****************************************************************************!*\
  !*** ./wwwroot/vendor/libs/bootstrap-table/extensions/pipeline/pipeline.js ***!
  \*****************************************************************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony import */ var bootstrap_table_src_extensions_pipeline_bootstrap_table_pipeline_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! bootstrap-table/src/extensions/pipeline/bootstrap-table-pipeline.js */ \"./node_modules/bootstrap-table/src/extensions/pipeline/bootstrap-table-pipeline.js\");\n/* harmony import */ var bootstrap_table_src_extensions_pipeline_bootstrap_table_pipeline_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(bootstrap_table_src_extensions_pipeline_bootstrap_table_pipeline_js__WEBPACK_IMPORTED_MODULE_0__);\n\n\n//# sourceURL=webpack:///./wwwroot/vendor/libs/bootstrap-table/extensions/pipeline/pipeline.js?");

/***/ })

/******/ })));