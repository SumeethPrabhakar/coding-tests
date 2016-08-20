'use strict';

//https://learn.jquery.com/plugins/basic-plugin-creation/
(function ($) {
    $.fn.openInNewWindow = function (options) {
        var pattern = new RegExp('/' + window.location.host+'|#' + '/');
        var settings = $.extend({
            // These are the defaults.
            toolbar: "no",
            location: "no",
            status: "no",
            menubar: "no",
            scrollbars: "yes",
            position: "center",
            resizable: "yes",
            width: "200px",
            height: "200px"
        }, options);

        this.filter("a").each(function () {
                var link = $(this);
                if (!pattern.test(link.href)) {
                    link.click(function (event) {
                        event.preventDefault();
                        event.stopPropagation();
                        window.open(this.href, '_blank', settings);
                    });
                }
            });
        return this;
    }
}(jQuery));