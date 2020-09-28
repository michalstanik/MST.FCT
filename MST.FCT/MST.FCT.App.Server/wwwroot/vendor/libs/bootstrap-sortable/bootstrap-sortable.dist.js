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
/******/ 	return __webpack_require__(__webpack_require__.s = "./wwwroot/vendor/libs/bootstrap-sortable/bootstrap-sortable.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./wwwroot/vendor/libs/bootstrap-sortable/bootstrap-sortable.js":
/*!**********************************************************************!*\
  !*** ./wwwroot/vendor/libs/bootstrap-sortable/bootstrap-sortable.js ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

eval("var __WEBPACK_LOCAL_MODULE_0__, __WEBPACK_LOCAL_MODULE_0__factory, __WEBPACK_LOCAL_MODULE_0__module;var __WEBPACK_AMD_DEFINE_FACTORY__, __WEBPACK_AMD_DEFINE_ARRAY__, __WEBPACK_AMD_DEFINE_RESULT__;// REPO: https://github.com/drvic10k/bootstrap-sortable\n\n/**\n * adding sorting ability to HTML tables with Bootstrap styling\n * @summary HTML tables sorting ability\n * @version 2.0.1\n * @requires tinysort, moment.js, jQuery\n * @license MIT\n * @author Matus Brlit (drvic10k)\n * @copyright Matus Brlit (drvic10k), bootstrap-sortable contributors\n */\n\n/**\n * TinySort is a small script that sorts HTML elements. It sorts by text- or attribute value, or by that of one of it's children.\n * @summary A nodeElement sorting script.\n * @version 2.3.6\n * @license MIT\n * @author Ron Valstar <ron@ronvalstar.nl>\n * @copyright Ron Valstar <ron@ronvalstar.nl>\n * @namespace tinysort\n */\n!function (e, t) {\n  \"use strict\";\n\n  function r() {\n    return t;\n  }\n\n   true ? !(__WEBPACK_LOCAL_MODULE_0__factory = (r), (__WEBPACK_LOCAL_MODULE_0__module = { id: \"tinysort\", exports: {}, loaded: false }), __WEBPACK_LOCAL_MODULE_0__ = (typeof __WEBPACK_LOCAL_MODULE_0__factory === 'function' ? (__WEBPACK_LOCAL_MODULE_0__factory.call(__WEBPACK_LOCAL_MODULE_0__module.exports, __webpack_require__, __WEBPACK_LOCAL_MODULE_0__module.exports, __WEBPACK_LOCAL_MODULE_0__module)) : __WEBPACK_LOCAL_MODULE_0__factory), (__WEBPACK_LOCAL_MODULE_0__module.loaded = true), __WEBPACK_LOCAL_MODULE_0__ === undefined && (__WEBPACK_LOCAL_MODULE_0__ = __WEBPACK_LOCAL_MODULE_0__module.exports)) : undefined;\n}(this, function () {\n  \"use strict\";\n\n  function e(e, n) {\n    function s() {\n      0 === arguments.length ? v({}) : t(arguments, function (e) {\n        v(x(e) ? {\n          selector: e\n        } : e);\n      }), d = $.length;\n    }\n\n    function v(e) {\n      var t = !!e.selector,\n          n = t && \":\" === e.selector[0],\n          o = r(e || {}, m);\n      $.push(r({\n        hasSelector: t,\n        hasAttr: !(o.attr === l || \"\" === o.attr),\n        hasData: o.data !== l,\n        hasFilter: n,\n        sortReturnNumber: \"asc\" === o.order ? 1 : -1\n      }, o));\n    }\n\n    function S() {\n      t(e, function (e, t) {\n        M ? M !== e.parentNode && (k = !1) : M = e.parentNode;\n        var r = $[0],\n            n = r.hasFilter,\n            o = r.selector,\n            a = !o || n && e.matchesSelector(o) || o && e.querySelector(o),\n            l = a ? R : V,\n            s = {\n          elm: e,\n          pos: t,\n          posn: l.length\n        };\n        B.push(s), l.push(s);\n      }), D = R.slice(0);\n    }\n\n    function y(e, t, r) {\n      for (var n = r(e.toString()), o = r(t.toString()), a = 0; n[a] && o[a]; a++) {\n        if (n[a] !== o[a]) {\n          var l = Number(n[a]),\n              s = Number(o[a]);\n          return l == n[a] && s == o[a] ? l - s : n[a] > o[a] ? 1 : -1;\n        }\n      }\n\n      return n.length - o.length;\n    }\n\n    function N(e) {\n      for (var t, r, n = [], o = 0, a = -1, l = 0; t = (r = e.charAt(o++)).charCodeAt(0);) {\n        var s = 46 == t || t >= 48 && 57 >= t;\n        s !== l && (n[++a] = \"\", l = s), n[a] += r;\n      }\n\n      return n;\n    }\n\n    function C(e, r) {\n      var n = 0;\n\n      for (0 !== p && (p = 0); 0 === n && d > p;) {\n        var l = $[p],\n            s = l.ignoreDashes ? f : u;\n        if (t(h, function (e) {\n          var t = e.prepare;\n          t && t(l);\n        }), l.sortFunction) n = l.sortFunction(e, r);else if (\"rand\" == l.order) n = Math.random() < .5 ? 1 : -1;else {\n          var c = a,\n              g = w(e, l),\n              m = w(r, l),\n              v = \"\" === g || g === o,\n              S = \"\" === m || m === o;\n          if (g === m) n = 0;else if (l.emptyEnd && (v || S)) n = v && S ? 0 : v ? 1 : -1;else {\n            if (!l.forceStrings) {\n              var C = x(g) ? g && g.match(s) : a,\n                  b = x(m) ? m && m.match(s) : a;\n\n              if (C && b) {\n                var A = g.substr(0, g.length - C[0].length),\n                    F = m.substr(0, m.length - b[0].length);\n                A == F && (c = !a, g = i(C[0]), m = i(b[0]));\n              }\n            }\n\n            n = g === o || m === o ? 0 : l.natural && (isNaN(g) || isNaN(m)) ? y(g, m, N) : m > g ? -1 : g > m ? 1 : 0;\n          }\n        }\n        t(h, function (e) {\n          var t = e.sort;\n          t && (n = t(l, c, g, m, n));\n        }), n *= l.sortReturnNumber, 0 === n && p++;\n      }\n\n      return 0 === n && (n = e.pos > r.pos ? 1 : -1), n;\n    }\n\n    function b() {\n      var e = R.length === B.length;\n      if (k && e) O ? R.forEach(function (e, t) {\n        e.elm.style.order = t;\n      }) : M ? M.appendChild(A()) : console.warn(\"parentNode has been removed\");else {\n        var t = $[0],\n            r = t.place,\n            n = \"org\" === r,\n            o = \"start\" === r,\n            a = \"end\" === r,\n            l = \"first\" === r,\n            s = \"last\" === r;\n        if (n) R.forEach(F), R.forEach(function (e, t) {\n          E(D[t], e.elm);\n        });else if (o || a) {\n          var c = D[o ? 0 : D.length - 1],\n              i = c && c.elm.parentNode,\n              u = i && (o && i.firstChild || i.lastChild);\n          u && (u !== c.elm && (c = {\n            elm: u\n          }), F(c), a && i.appendChild(c.ghost), E(c, A()));\n        } else if (l || s) {\n          var f = D[l ? 0 : D.length - 1];\n          E(F(f), A());\n        }\n      }\n    }\n\n    function A() {\n      return R.forEach(function (e) {\n        q.appendChild(e.elm);\n      }), q;\n    }\n\n    function F(e) {\n      var t = e.elm,\n          r = c.createElement(\"div\");\n      return e.ghost = r, t.parentNode.insertBefore(r, t), e;\n    }\n\n    function E(e, t) {\n      var r = e.ghost,\n          n = r.parentNode;\n      n.insertBefore(t, r), n.removeChild(r), delete e.ghost;\n    }\n\n    function w(e, t) {\n      var r,\n          n = e.elm;\n      return t.selector && (t.hasFilter ? n.matchesSelector(t.selector) || (n = l) : n = n.querySelector(t.selector)), t.hasAttr ? r = n.getAttribute(t.attr) : t.useVal ? r = n.value || n.getAttribute(\"value\") : t.hasData ? r = n.getAttribute(\"data-\" + t.data) : n && (r = n.textContent), x(r) && (t.cases || (r = r.toLowerCase()), r = r.replace(/\\s+/g, \" \")), null === r && (r = g), r;\n    }\n\n    function x(e) {\n      return \"string\" == typeof e;\n    }\n\n    x(e) && (e = c.querySelectorAll(e)), 0 === e.length && console.warn(\"No elements to sort\");\n    var D,\n        M,\n        q = c.createDocumentFragment(),\n        B = [],\n        R = [],\n        V = [],\n        $ = [],\n        k = !0,\n        z = e.length && e[0].parentNode,\n        L = z.rootNode !== document,\n        O = e.length && (n === o || n.useFlex !== !1) && !L && -1 !== getComputedStyle(z, null).display.indexOf(\"flex\");\n    return s.apply(l, Array.prototype.slice.call(arguments, 1)), S(), R.sort(C), b(), R.map(function (e) {\n      return e.elm;\n    });\n  }\n\n  function t(e, t) {\n    for (var r, n = e.length, o = n; o--;) {\n      r = n - o - 1, t(e[r], r);\n    }\n  }\n\n  function r(e, t, r) {\n    for (var n in t) {\n      (r || e[n] === o) && (e[n] = t[n]);\n    }\n\n    return e;\n  }\n\n  function n(e, t, r) {\n    h.push({\n      prepare: e,\n      sort: t,\n      sortBy: r\n    });\n  }\n\n  var o,\n      a = !1,\n      l = null,\n      s = window,\n      c = s.document,\n      i = parseFloat,\n      u = /(-?\\d+\\.?\\d*)\\s*$/g,\n      f = /(\\d+\\.?\\d*)\\s*$/g,\n      h = [],\n      d = 0,\n      p = 0,\n      g = String.fromCharCode(4095),\n      m = {\n    selector: l,\n    order: \"asc\",\n    attr: l,\n    data: l,\n    useVal: a,\n    place: \"org\",\n    returns: a,\n    cases: a,\n    natural: a,\n    forceStrings: a,\n    ignoreDashes: a,\n    sortFunction: l,\n    useFlex: a,\n    emptyEnd: a\n  };\n  return s.Element && function (e) {\n    e.matchesSelector = e.matchesSelector || e.mozMatchesSelector || e.msMatchesSelector || e.oMatchesSelector || e.webkitMatchesSelector || function (e) {\n      for (var t = this, r = (t.parentNode || t.document).querySelectorAll(e), n = -1; r[++n] && r[n] != t;) {\n        ;\n      }\n\n      return !!r[n];\n    };\n  }(Element.prototype), r(n, {\n    loop: t\n  }), r(e, {\n    plugin: n,\n    defaults: m\n  });\n}());\n\n(function (global, factory) {\n  if (true) {\n    !(__WEBPACK_AMD_DEFINE_ARRAY__ = [__webpack_require__(/*! jquery */ \"jquery\"), __WEBPACK_LOCAL_MODULE_0__, __webpack_require__(/*! moment */ \"moment\")], __WEBPACK_AMD_DEFINE_FACTORY__ = (factory),\n\t\t\t\t__WEBPACK_AMD_DEFINE_RESULT__ = (typeof __WEBPACK_AMD_DEFINE_FACTORY__ === 'function' ?\n\t\t\t\t(__WEBPACK_AMD_DEFINE_FACTORY__.apply(exports, __WEBPACK_AMD_DEFINE_ARRAY__)) : __WEBPACK_AMD_DEFINE_FACTORY__),\n\t\t\t\t__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));\n  } else {}\n})(this, function ($, tinysort, moment) {\n  var $document = $(document),\n      signClass,\n      sortEngine,\n      emptyEnd;\n\n  $.bootstrapSortable = function (options) {\n    if (options == undefined) {\n      initialize({});\n    } else if (options.constructor === Boolean) {\n      initialize({\n        applyLast: options\n      });\n    } else if (options.sortingHeader !== undefined) {\n      sortByColumn(options.sortingHeader);\n    } else {\n      initialize(options);\n    }\n  };\n\n  function initialize(options) {\n    // Check if moment.js is available\n    var momentJsAvailable = typeof moment !== 'undefined'; // Set class based on sign parameter\n\n    signClass = !options.sign ? \"arrow\" : options.sign; // Set sorting algorithm\n\n    if (options.customSort == 'default') options.customSort = defaultSortEngine;\n    sortEngine = options.customSort || sortEngine || defaultSortEngine;\n    emptyEnd = options.emptyEnd; // Set attributes needed for sorting\n\n    $('table.sortable').each(function () {\n      var $this = $(this);\n      var applyLast = options.applyLast === true;\n      $this.find('span.sign').remove(); // Add placeholder cells for colspans\n\n      $this.find('> thead [colspan]').each(function () {\n        var colspan = parseFloat($(this).attr('colspan'));\n\n        for (var i = 1; i < colspan; i++) {\n          $(this).after('<th class=\"colspan-compensate\">');\n        }\n      }); // Add placeholder cells for rowspans in header\n\n      $this.find('> thead [rowspan]').each(function () {\n        var $cell = $(this);\n        var rowspan = parseFloat($cell.attr('rowspan'));\n\n        for (var i = 1; i < rowspan; i++) {\n          var parentRow = $cell.parent('tr');\n          var nextRow = parentRow.next('tr');\n          var index = parentRow.children().index($cell);\n          nextRow.children().eq(index).before('<th class=\"rowspan-compensate\">');\n        }\n      }); // Set indexes to header cells\n\n      $this.find('> thead tr').each(function (rowIndex) {\n        $(this).find('th').each(function (columnIndex) {\n          var $header = $(this);\n          $header.addClass('nosort').removeClass('up down');\n          $header.attr('data-sortcolumn', columnIndex);\n          $header.attr('data-sortkey', columnIndex + '-' + rowIndex);\n        });\n      }); // Cleanup placeholder cells\n\n      $this.find('> thead .rowspan-compensate, .colspan-compensate').remove(); // Initialize sorting values specified in header\n\n      $this.find('th').each(function () {\n        var $header = $(this);\n\n        if ($header.attr('data-dateformat') !== undefined && momentJsAvailable) {\n          var colNumber = parseFloat($header.attr('data-sortcolumn'));\n          $this.find('td:nth-child(' + (colNumber + 1) + ')').each(function () {\n            var $cell = $(this);\n            $cell.attr('data-value', moment($cell.text(), $header.attr('data-dateformat')).format('YYYY/MM/DD/HH/mm/ss'));\n          });\n        } else if ($header.attr('data-valueprovider') !== undefined) {\n          var colNumber = parseFloat($header.attr('data-sortcolumn'));\n          $this.find('td:nth-child(' + (colNumber + 1) + ')').each(function () {\n            var $cell = $(this);\n            $cell.attr('data-value', new RegExp($header.attr('data-valueprovider')).exec($cell.text())[0]);\n          });\n        }\n      }); // Initialize sorting values\n\n      $this.find('td').each(function () {\n        var $cell = $(this);\n\n        if ($cell.attr('data-dateformat') !== undefined && momentJsAvailable) {\n          $cell.attr('data-value', moment($cell.text(), $cell.attr('data-dateformat')).format('YYYY/MM/DD/HH/mm/ss'));\n        } else if ($cell.attr('data-valueprovider') !== undefined) {\n          $cell.attr('data-value', new RegExp($cell.attr('data-valueprovider')).exec($cell.text())[0]);\n        } else {\n          $cell.attr('data-value') === undefined && $cell.attr('data-value', $cell.text());\n        }\n      });\n      var context = lookupSortContext($this),\n          bsSort = context.bsSort;\n      $this.find('> thead th[data-defaultsort!=\"disabled\"]').each(function (index) {\n        var $header = $(this);\n        var $sortTable = $header.closest('table.sortable');\n        $header.data('sortTable', $sortTable);\n        var sortKey = $header.attr('data-sortkey');\n        var thisLastSort = applyLast ? context.lastSort : -1;\n        bsSort[sortKey] = applyLast ? bsSort[sortKey] : $header.attr('data-defaultsort');\n\n        if (bsSort[sortKey] !== undefined && applyLast === (sortKey === thisLastSort)) {\n          bsSort[sortKey] = bsSort[sortKey] === 'asc' ? 'desc' : 'asc';\n          doSort($header, $sortTable);\n        }\n      });\n    });\n  } // Clean up placeholder cells for rowspans in body\n\n\n  function removeRowspanPlaceholders(table) {\n    table.find('> tbody [rowspan-group]').each(function () {\n      var $this = $(this);\n      var id = $this.attr('rowspan-group');\n      var parentRow = $this.parent('tr');\n      var index = parentRow.children().index($this);\n\n      while (true) {\n        var nextRow = parentRow.next('tr');\n        if (!nextRow.is('tr')) break;\n        var nextCell = nextRow.children().eq(index);\n\n        if (nextCell.attr('rowspan-group') === id) {\n          var rowspan = parseFloat($this.attr('rowspan')) || 1;\n          $this.attr('rowspan', rowspan + 1);\n          nextCell.remove();\n        } else {\n          break;\n        }\n\n        parentRow = nextRow;\n      }\n    });\n  } // Add placeholder cells for rowspans in body\n\n\n  function addRowspanPlaceholders(table) {\n    table.find('> tbody [rowspan]').each(function () {\n      var $cell = $(this);\n      var rowspan = parseFloat($cell.attr('rowspan'));\n      $cell.removeAttr('rowspan');\n      var rowSpanId = $cell.attr('rowspan-group') || guid();\n      $cell.attr('rowspan-group', rowSpanId);\n      $cell.attr('rowspan-value', rowspan);\n      var parentRow = $cell.parent('tr');\n      var index = parentRow.children().index($cell);\n\n      for (var i = 1; i < rowspan; i++) {\n        var compemnsationCell = $cell.clone(false);\n        var nextRow = parentRow.next('tr');\n        nextRow.children().eq(index).before(compemnsationCell);\n        parentRow = nextRow;\n      }\n    });\n  } // Add click event to table header\n\n\n  $document.on('click', 'table.sortable>thead th[data-defaultsort!=\"disabled\"]', function (e) {\n    sortByColumn(this);\n  }); // element is the header of the column to sort (the clicked header)\n\n  function sortByColumn(element) {\n    var $this = $(element),\n        $table = $this.data('sortTable') || $this.closest('table.sortable');\n    doSort($this, $table);\n  } // Look up sorting data appropriate for the specified table (jQuery element).\n  // This allows multiple tables on one page without collisions.\n\n\n  function lookupSortContext($table) {\n    var context = $table.data(\"bootstrap-sortable-context\");\n\n    if (context === undefined) {\n      context = {\n        bsSort: [],\n        lastSort: undefined\n      };\n      $table.find('> thead th[data-defaultsort!=\"disabled\"]').each(function (index) {\n        var $this = $(this);\n        var sortKey = $this.attr('data-sortkey');\n        context.bsSort[sortKey] = $this.attr('data-defaultsort');\n\n        if (context.bsSort[sortKey] !== undefined) {\n          context.lastSort = sortKey;\n        }\n      });\n      $table.data(\"bootstrap-sortable-context\", context);\n    }\n\n    return context;\n  }\n\n  function defaultSortEngine(rows, sortingParams) {\n    tinysort(rows, sortingParams);\n  } // Sorting mechanism separated\n\n\n  function doSort($this, $table) {\n    $table.trigger('before-sort');\n    addRowspanPlaceholders($table);\n    var sortColumn = parseFloat($this.attr('data-sortcolumn')),\n        context = lookupSortContext($table),\n        bsSort = context.bsSort;\n    var colspan = $this.attr('colspan');\n\n    if (colspan) {\n      var mainSort = parseFloat($this.data('mainsort')) || 0;\n      var rowIndex = parseFloat($this.data('sortkey').split('-').pop()); // If there is one more row in header, delve deeper\n\n      if ($table.find('> thead tr').length - 1 > rowIndex) {\n        doSort($table.find('[data-sortkey=\"' + (sortColumn + mainSort) + '-' + (rowIndex + 1) + '\"]'), $table);\n        return;\n      } // Otherwise, just adjust the sortColumn\n\n\n      sortColumn = sortColumn + mainSort;\n    }\n\n    var localSignClass = $this.attr('data-defaultsign') || signClass; // update arrow icon\n\n    $table.find('> thead th').each(function () {\n      $(this).removeClass('up').removeClass('down').addClass('nosort');\n    });\n\n    if ($.browser.mozilla) {\n      var moz_arrow = $table.find('> thead div.mozilla');\n\n      if (moz_arrow !== undefined) {\n        moz_arrow.find('.sign').remove();\n        moz_arrow.parent().html(moz_arrow.html());\n      }\n\n      $this.wrapInner('<div class=\"mozilla\"></div>');\n      $this.children().eq(0).append('<span class=\"sign ' + localSignClass + '\"></span>');\n    } else {\n      $table.find('> thead span.sign').remove();\n      $this.append('<span class=\"sign ' + localSignClass + '\"></span>');\n    } // sort direction\n\n\n    var sortKey = $this.attr('data-sortkey');\n    var initialDirection = $this.attr('data-firstsort') !== 'desc' ? 'desc' : 'asc';\n    var newDirection = bsSort[sortKey] || initialDirection;\n\n    if (context.lastSort === sortKey || bsSort[sortKey] === undefined) {\n      newDirection = newDirection === 'asc' ? 'desc' : 'asc';\n    }\n\n    bsSort[sortKey] = newDirection;\n    context.lastSort = sortKey;\n\n    if (bsSort[sortKey] === 'desc') {\n      $this.find('span.sign').addClass('up');\n      $this.addClass('up').removeClass('down nosort');\n    } else {\n      $this.addClass('down').removeClass('up nosort');\n    } // remove rows that should not be sorted\n\n\n    var rows = $table.children('tbody').children('tr');\n    var fixedRows = [];\n    $(rows.filter('[data-disablesort=\"true\"]').get().reverse()).each(function (index, fixedRow) {\n      var $fixedRow = $(fixedRow);\n      fixedRows.push({\n        index: rows.index($fixedRow),\n        row: $fixedRow\n      });\n      $fixedRow.remove();\n    }); // sort rows\n\n    var rowsToSort = rows.not('[data-disablesort=\"true\"]');\n\n    if (rowsToSort.length != 0) {\n      var emptySorting = bsSort[sortKey] === 'asc' ? emptyEnd : false;\n      sortEngine(rowsToSort, {\n        emptyEnd: emptySorting,\n        selector: 'td:nth-child(' + (sortColumn + 1) + ')',\n        order: bsSort[sortKey],\n        data: 'value'\n      });\n    } // add back the fixed rows\n\n\n    $(fixedRows.reverse()).each(function (index, row) {\n      if (row.index === 0) {\n        $table.children('tbody').prepend(row.row);\n      } else {\n        $table.children('tbody').children('tr').eq(row.index - 1).after(row.row);\n      }\n    }); // add class to sorted column cells\n\n    $table.find('> tbody > tr > td.sorted,> thead th.sorted').removeClass('sorted');\n    rowsToSort.find('td:eq(' + sortColumn + ')').addClass('sorted');\n    $this.addClass('sorted');\n    removeRowspanPlaceholders($table);\n    $table.trigger('sorted');\n  } // jQuery 1.9 removed this object\n\n\n  if (!$.browser) {\n    $.browser = {\n      chrome: false,\n      mozilla: false,\n      opera: false,\n      msie: false,\n      safari: false\n    };\n    var ua = navigator.userAgent;\n    $.each($.browser, function (c) {\n      $.browser[c] = new RegExp(c, 'i').test(ua) ? true : false;\n\n      if ($.browser.mozilla && c === 'mozilla') {\n        $.browser.mozilla = new RegExp('firefox', 'i').test(ua) ? true : false;\n      }\n\n      if ($.browser.chrome && c === 'safari') {\n        $.browser.safari = false;\n      }\n    });\n  }\n\n  function guid() {\n    function s4() {\n      return Math.floor((1 + Math.random()) * 0x10000).toString(16).substring(1);\n    }\n\n    return s4() + s4() + '-' + s4() + '-' + s4() + '-' + s4() + '-' + s4() + s4() + s4();\n  } // Initialise on DOM ready\n\n\n  $($.bootstrapSortable);\n});\n\n//# sourceURL=webpack:///./wwwroot/vendor/libs/bootstrap-sortable/bootstrap-sortable.js?");

/***/ }),

/***/ "jquery":
/*!*************************!*\
  !*** external "jQuery" ***!
  \*************************/
/*! no static exports found */
/***/ (function(module, exports) {

eval("(function() { module.exports = window[\"jQuery\"]; }());\n\n//# sourceURL=webpack:///external_%22jQuery%22?");

/***/ }),

/***/ "moment":
/*!*************************!*\
  !*** external "moment" ***!
  \*************************/
/*! no static exports found */
/***/ (function(module, exports) {

eval("(function() { module.exports = window[\"moment\"]; }());\n\n//# sourceURL=webpack:///external_%22moment%22?");

/***/ })

/******/ })));