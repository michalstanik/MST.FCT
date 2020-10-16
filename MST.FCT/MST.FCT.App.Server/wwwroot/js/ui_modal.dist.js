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
/******/ 	return __webpack_require__(__webpack_require__.s = "./wwwroot/js/ui_modal.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./wwwroot/js/ui_modal.js":
/*!********************************!*\
  !*** ./wwwroot/js/ui_modal.js ***!
  \********************************/
/*! no static exports found */
/***/ (function(module, exports) {

eval("// Bootstrap modals\n$(function () {\n  $('[name=modals-default-size]').on('change', function () {\n    $('#modals-default .modal-dialog').removeClass('modal-sm').removeClass('modal-lg');\n\n    if (this.value !== 'md') {\n      $('#modals-default .modal-dialog').addClass('modal-' + this.value);\n    }\n  });\n  $('[name=modals-top-size]').on('change', function () {\n    $('#modals-top .modal-dialog').removeClass('modal-sm').removeClass('modal-lg');\n\n    if (this.value !== 'md') {\n      $('#modals-top .modal-dialog').addClass('modal-' + this.value);\n    }\n  });\n  $('[name=modals-fill-in-size]').on('change', function () {\n    $('#modals-fill-in .modal-dialog').removeClass('modal-sm').removeClass('modal-lg');\n\n    if (this.value !== 'md') {\n      $('#modals-fill-in .modal-dialog').addClass('modal-' + this.value);\n    }\n  });\n}); // Bootbox\n\n$(function () {\n  $('#bootbox-alert').on('click', function () {\n    bootbox.alert({\n      message: 'Hello world!',\n      className: 'bootbox-sm',\n      callback: function callback() {\n        alert('Hello world callback');\n      }\n    });\n  });\n  $('#bootbox-confirm').on('click', function () {\n    bootbox.confirm({\n      message: 'Are you sure?',\n      className: 'bootbox-sm',\n      callback: function callback(result) {\n        alert('Confirm result: ' + result);\n      }\n    });\n  });\n  $('#bootbox-prompt').on('click', function () {\n    bootbox.prompt({\n      title: 'What is your name?',\n      callback: function callback(result) {\n        if (result === null) {\n          alert('Prompt dismissed');\n        } else {\n          alert('Hi ' + result + '!');\n        }\n      }\n    });\n  });\n  $('#bootbox-custom').on('click', function () {\n    bootbox.dialog({\n      title: 'Custom title',\n      message: 'I am a custom dialog',\n      className: 'bootbox-lg',\n      buttons: {\n        success: {\n          label: 'Success!',\n          className: 'btn-success',\n          callback: function callback() {\n            alert('great success');\n          }\n        },\n        danger: {\n          label: 'Danger!',\n          className: 'btn-danger',\n          callback: function callback() {\n            alert('uh oh, look out!');\n          }\n        },\n        main: {\n          label: 'Click ME!',\n          className: 'btn-primary',\n          callback: function callback() {\n            alert('Primary button');\n          }\n        }\n      }\n    });\n  });\n}); // SweetAlert2\n\n$(function () {\n  $('#sweetalert-example-1').click(function () {\n    Swal.fire({\n      title: 'Here\\'s a message!',\n      text: 'It\\'s pretty, isn\\'t it?',\n      footer: '<a href=\"javascript:void(0)\">Why do I have this issue?</a>'\n    });\n  });\n  $('#sweetalert-example-2').click(function () {\n    Swal.fire({\n      title: 'Are you sure?',\n      text: 'You will not be able to recover this imaginary file!',\n      icon: 'warning',\n      allowOutsideClick: false,\n      showCancelButton: true,\n      confirmButtonText: 'Yes, delete it!',\n      cancelButtonText: 'No, cancel plx!'\n    }).then(function (result) {\n      if (result.value) {\n        Swal.fire('Deleted!', 'Your imaginary file has been deleted.', 'success');\n      } else {\n        Swal.fire('Cancelled', 'Your imaginary file is safe :)', 'error');\n      }\n    });\n  });\n  $('#sweetalert-example-3').click(function () {\n    Swal.fire({\n      title: 'Ajax request example',\n      text: 'Submit to run ajax request',\n      icon: 'info',\n      showCancelButton: true,\n      showLoaderOnConfirm: true,\n      allowOutsideClick: function allowOutsideClick() {\n        return !Swal.isLoading();\n      },\n      preConfirm: function preConfirm() {\n        return new Promise(function (resolve) {\n          setTimeout(function () {\n            resolve(true);\n          }, 2000);\n        });\n      }\n    }).then(function (result) {\n      if (result.value) {\n        Swal.fire('Ajax request finished!');\n      }\n    });\n  });\n  $('#sweetalert-example-4').click(function () {\n    Swal.mixin({\n      input: 'text',\n      confirmButtonText: 'Next &rarr;',\n      showCancelButton: true,\n      progressSteps: ['1', '2', '3']\n    }).queue([{\n      title: 'Question 1',\n      text: 'Chaining swal2 modals is easy'\n    }, 'Question 2', 'Question 3']).then(function (result) {\n      if (result.value) {\n        Swal.fire({\n          title: 'All done!',\n          html: 'Your answers: <pre><code>' + JSON.stringify(result.value) + '</code></pre>',\n          confirmButtonText: 'Lovely!'\n        });\n      }\n    });\n  });\n  $('#sweetalert-example-5').click(function () {\n    Swal.fire({\n      title: 'Are you sure?!',\n      text: 'You will not be able to recover this imaginary file!',\n      icon: 'info',\n      showCancelButton: true,\n      customClass: {\n        confirmButton: 'btn btn-info btn-lg',\n        cancelButton: 'btn btn-default btn-lg'\n      }\n    });\n  });\n  $('#sweetalert-example-6').click(function () {\n    Swal.fire({\n      title: 'Are you sure?',\n      text: 'You will not be able to recover this imaginary file!',\n      icon: 'success',\n      showCancelButton: true,\n      customClass: {\n        confirmButton: 'btn btn-success btn-lg',\n        cancelButton: 'btn btn-default btn-lg'\n      }\n    });\n  });\n  $('#sweetalert-example-7').click(function () {\n    Swal.fire({\n      title: 'Are you sure?',\n      text: 'You will not be able to recover this imaginary file!',\n      icon: 'warning',\n      showCancelButton: true,\n      customClass: {\n        confirmButton: 'btn btn-warning btn-lg',\n        cancelButton: 'btn btn-default btn-lg'\n      }\n    });\n  });\n  $('#sweetalert-example-8').click(function () {\n    Swal.fire({\n      title: 'Are you sure?',\n      text: 'You will not be able to recover this imaginary file!',\n      icon: 'error',\n      showCancelButton: true,\n      customClass: {\n        confirmButton: 'btn btn-danger btn-lg',\n        cancelButton: 'btn btn-default btn-lg'\n      }\n    });\n  });\n});\n\n//# sourceURL=webpack:///./wwwroot/js/ui_modal.js?");

/***/ })

/******/ })));