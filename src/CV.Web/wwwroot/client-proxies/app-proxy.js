/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module app

(function(){

  // controller manager.service.candidate.candidate

  (function(){

    abp.utils.createNamespace(window, 'manager.service.candidate.candidate');

    manager.service.candidate.candidate.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/candidate',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    manager.service.candidate.candidate.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/candidate/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    manager.service.candidate.candidate['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/candidate/' + id + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    manager.service.candidate.candidate.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/candidate/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    manager.service.candidate.candidate.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/candidate' + abp.utils.buildQueryString([{ name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

  })();

  // controller cV.service.degree.degree

  (function(){

    abp.utils.createNamespace(window, 'cV.service.degree.degree');

    cV.service.degree.degree.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/degree',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    cV.service.degree.degree.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/degree/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    cV.service.degree.degree['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/degree/' + id + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    cV.service.degree.degree.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/degree/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    cV.service.degree.degree.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/app/degree' + abp.utils.buildQueryString([{ name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

  })();

})();

