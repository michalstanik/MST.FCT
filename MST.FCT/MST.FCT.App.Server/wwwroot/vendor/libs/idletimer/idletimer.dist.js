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
/******/ 	return __webpack_require__(__webpack_require__.s = "./wwwroot/vendor/libs/idletimer/idletimer.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./wwwroot/vendor/libs/idletimer/idletimer.js":
/*!****************************************************!*\
  !*** ./wwwroot/vendor/libs/idletimer/idletimer.js ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

eval("function _typeof(obj) { \"@babel/helpers - typeof\"; if (typeof Symbol === \"function\" && typeof Symbol.iterator === \"symbol\") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === \"function\" && obj.constructor === Symbol && obj !== Symbol.prototype ? \"symbol\" : typeof obj; }; } return _typeof(obj); }\n\n// REPO: https://github.com/thorst/jquery-idletimer\n\n/*! Idle Timer - v1.1.0 - 2016-03-21\n* https://github.com/thorst/jquery-idletimer\n* Copyright (c) 2016 Paul Irish; Licensed MIT */\n\n/*\n\tmousewheel (deprecated) -> IE6.0, Chrome, Opera, Safari\n\tDOMMouseScroll (deprecated) -> Firefox 1.0\n\twheel (standard) -> Chrome 31, Firefox 17, IE9, Firefox Mobile 17.0\n\n\t//No need to use, use DOMMouseScroll\n\tMozMousePixelScroll -> Firefox 3.5, Firefox Mobile 1.0\n\n\t//Events\n\tWheelEvent -> see wheel\n\tMouseWheelEvent -> see mousewheel\n\tMouseScrollEvent -> Firefox 3.5, Firefox Mobile 1.0\n*/\n(function ($) {\n  $.idleTimer = function (firstParam, elem) {\n    var opts;\n\n    if (_typeof(firstParam) === \"object\") {\n      opts = firstParam;\n      firstParam = null;\n    } else if (typeof firstParam === \"number\") {\n      opts = {\n        timeout: firstParam\n      };\n      firstParam = null;\n    } // element to watch\n\n\n    elem = elem || document; // defaults that are to be stored as instance props on the elem\n\n    opts = $.extend({\n      idle: false,\n      // indicates if the user is idle\n      timeout: 30000,\n      // the amount of time (ms) before the user is considered idle\n      events: \"mousemove keydown wheel DOMMouseScroll mousewheel mousedown touchstart touchmove MSPointerDown MSPointerMove\" // define active events\n\n    }, opts);\n\n    var jqElem = $(elem),\n        obj = jqElem.data(\"idleTimerObj\") || {},\n\n    /* (intentionally not documented)\n     * Toggles the idle state and fires an appropriate event.\n     * @return {void}\n     */\n    toggleIdleState = function toggleIdleState(e) {\n      var obj = $.data(elem, \"idleTimerObj\") || {}; // toggle the state\n\n      obj.idle = !obj.idle; // store toggle state date time\n\n      obj.olddate = +new Date(); // create a custom event, with state and name space\n\n      var event = $.Event((obj.idle ? \"idle\" : \"active\") + \".idleTimer\"); // trigger event on object with elem and copy of obj\n\n      $(elem).trigger(event, [elem, $.extend({}, obj), e]);\n    },\n\n    /**\n     * Handle event triggers\n     * @return {void}\n     * @method event\n     * @static\n     */\n    handleEvent = function handleEvent(e) {\n      var obj = $.data(elem, \"idleTimerObj\") || {};\n\n      if (e.type === \"storage\" && e.originalEvent.key !== obj.timerSyncId) {\n        return;\n      } // this is already paused, ignore events for now\n\n\n      if (obj.remaining != null) {\n        return;\n      }\n      /*\n      mousemove is kinda buggy, it can be triggered when it should be idle.\n      Typically is happening between 115 - 150 milliseconds after idle triggered.\n      @psyafter & @kaellis report \"always triggered if using modal (jQuery ui, with overlay)\"\n      @thorst has similar issues on ios7 \"after $.scrollTop() on text area\"\n      */\n\n\n      if (e.type === \"mousemove\") {\n        // if coord are same, it didn't move\n        if (e.pageX === obj.pageX && e.pageY === obj.pageY) {\n          return;\n        } // if coord don't exist how could it move\n\n\n        if (typeof e.pageX === \"undefined\" && typeof e.pageY === \"undefined\") {\n          return;\n        } // under 200 ms is hard to do, and you would have to stop, as continuous activity will bypass this\n\n\n        var elapsed = +new Date() - obj.olddate;\n\n        if (elapsed < 200) {\n          return;\n        }\n      } // clear any existing timeout\n\n\n      clearTimeout(obj.tId); // if the idle timer is enabled, flip\n\n      if (obj.idle) {\n        toggleIdleState(e);\n      } // store when user was last active\n\n\n      obj.lastActive = +new Date(); // update mouse coord\n\n      obj.pageX = e.pageX;\n      obj.pageY = e.pageY; // sync lastActive\n\n      if (e.type !== \"storage\" && obj.timerSyncId) {\n        if (typeof localStorage !== \"undefined\") {\n          localStorage.setItem(obj.timerSyncId, obj.lastActive);\n        }\n      } // set a new timeout\n\n\n      obj.tId = setTimeout(toggleIdleState, obj.timeout);\n    },\n\n    /**\n     * Restore initial settings and restart timer\n     * @return {void}\n     * @method reset\n     * @static\n     */\n    reset = function reset() {\n      var obj = $.data(elem, \"idleTimerObj\") || {}; // reset settings\n\n      obj.idle = obj.idleBackup;\n      obj.olddate = +new Date();\n      obj.lastActive = obj.olddate;\n      obj.remaining = null; // reset Timers\n\n      clearTimeout(obj.tId);\n\n      if (!obj.idle) {\n        obj.tId = setTimeout(toggleIdleState, obj.timeout);\n      }\n    },\n\n    /**\n     * Store remaining time, stop timer\n     * You can pause from an idle OR active state\n     * @return {void}\n     * @method pause\n     * @static\n     */\n    pause = function pause() {\n      var obj = $.data(elem, \"idleTimerObj\") || {}; // this is already paused\n\n      if (obj.remaining != null) {\n        return;\n      } // define how much is left on the timer\n\n\n      obj.remaining = obj.timeout - (+new Date() - obj.olddate); // clear any existing timeout\n\n      clearTimeout(obj.tId);\n    },\n\n    /**\n     * Start timer with remaining value\n     * @return {void}\n     * @method resume\n     * @static\n     */\n    resume = function resume() {\n      var obj = $.data(elem, \"idleTimerObj\") || {}; // this isn't paused yet\n\n      if (obj.remaining == null) {\n        return;\n      } // start timer\n\n\n      if (!obj.idle) {\n        obj.tId = setTimeout(toggleIdleState, obj.remaining);\n      } // clear remaining\n\n\n      obj.remaining = null;\n    },\n\n    /**\n     * Stops the idle timer. This removes appropriate event handlers\n     * and cancels any pending timeouts.\n     * @return {void}\n     * @method destroy\n     * @static\n     */\n    destroy = function destroy() {\n      var obj = $.data(elem, \"idleTimerObj\") || {}; //clear any pending timeouts\n\n      clearTimeout(obj.tId); //Remove data\n\n      jqElem.removeData(\"idleTimerObj\"); //detach the event handlers\n\n      jqElem.off(\"._idleTimer\");\n    },\n\n    /**\n    * Returns the time until becoming idle\n    * @return {number}\n    * @method remainingtime\n    * @static\n    */\n    remainingtime = function remainingtime() {\n      var obj = $.data(elem, \"idleTimerObj\") || {}; //If idle there is no time remaining\n\n      if (obj.idle) {\n        return 0;\n      } //If its paused just return that\n\n\n      if (obj.remaining != null) {\n        return obj.remaining;\n      } //Determine remaining, if negative idle didn't finish flipping, just return 0\n\n\n      var remaining = obj.timeout - (+new Date() - obj.lastActive);\n\n      if (remaining < 0) {\n        remaining = 0;\n      } //If this is paused return that number, else return current remaining\n\n\n      return remaining;\n    }; // determine which function to call\n\n\n    if (firstParam === null && typeof obj.idle !== \"undefined\") {\n      // they think they want to init, but it already is, just reset\n      reset();\n      return jqElem;\n    } else if (firstParam === null) {// they want to init\n    } else if (firstParam !== null && typeof obj.idle === \"undefined\") {\n      // they want to do something, but it isnt init\n      // not sure the best way to handle this\n      return false;\n    } else if (firstParam === \"destroy\") {\n      destroy();\n      return jqElem;\n    } else if (firstParam === \"pause\") {\n      pause();\n      return jqElem;\n    } else if (firstParam === \"resume\") {\n      resume();\n      return jqElem;\n    } else if (firstParam === \"reset\") {\n      reset();\n      return jqElem;\n    } else if (firstParam === \"getRemainingTime\") {\n      return remainingtime();\n    } else if (firstParam === \"getElapsedTime\") {\n      return +new Date() - obj.olddate;\n    } else if (firstParam === \"getLastActiveTime\") {\n      return obj.lastActive;\n    } else if (firstParam === \"isIdle\") {\n      return obj.idle;\n    }\n    /* (intentionally not documented)\n     * Handles a user event indicating that the user isn't idle. namespaced with internal idleTimer\n     * @param {Event} event A DOM2-normalized event object.\n     * @return {void}\n     */\n\n\n    jqElem.on($.trim((opts.events + \" \").split(\" \").join(\"._idleTimer \")), function (e) {\n      handleEvent(e);\n    });\n\n    if (opts.timerSyncId) {\n      $(window).bind(\"storage\", handleEvent);\n    } // Internal Object Properties, This isn't all necessary, but we\n    // explicitly define all keys here so we know what we are working with\n\n\n    obj = $.extend({}, {\n      olddate: +new Date(),\n      // the last time state changed\n      lastActive: +new Date(),\n      // the last time timer was active\n      idle: opts.idle,\n      // current state\n      idleBackup: opts.idle,\n      // backup of idle parameter since it gets modified\n      timeout: opts.timeout,\n      // the interval to change state\n      remaining: null,\n      // how long until state changes\n      timerSyncId: opts.timerSyncId,\n      // localStorage key to use for syncing this timer\n      tId: null,\n      // the idle timer setTimeout\n      pageX: null,\n      // used to store the mouse coord\n      pageY: null\n    }); // set a timeout to toggle state. May wish to omit this in some situations\n\n    if (!obj.idle) {\n      obj.tId = setTimeout(toggleIdleState, obj.timeout);\n    } // store our instance on the object\n\n\n    $.data(elem, \"idleTimerObj\", obj);\n    return jqElem;\n  }; // This allows binding to element\n\n\n  $.fn.idleTimer = function (firstParam) {\n    if (this[0]) {\n      return $.idleTimer(firstParam, this[0]);\n    }\n\n    return this;\n  };\n})(jQuery);\n\n//# sourceURL=webpack:///./wwwroot/vendor/libs/idletimer/idletimer.js?");

/***/ })

/******/ })));