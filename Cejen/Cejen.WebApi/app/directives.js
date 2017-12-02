angular.module('app')
app.directive('innerHtmlBind', function () {
    return {
        restrict: 'A',
        scope: {
            inner_html: '=innerHtml'
        },
        link: function (scope, element, attrs) {
            scope.inner_html = element.html();
        }
    }
})