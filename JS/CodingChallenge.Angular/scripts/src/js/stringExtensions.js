'use strict';

String.prototype.startsWith = function (input) {
    return this.indexOf(input) === 0;
}

String.prototype.endsWith = function (input) {
    if (this.length < input.length)
        return false;
    return this.lastIndexOf(input) === this.length - input.length;
}

String.prototype.stripHtml = function () {
    //got regex from http://www.dotnetperls.com/remove-html-tags
    var pattern = /<.*?>/g;
    return this.replace(pattern, "");
}



