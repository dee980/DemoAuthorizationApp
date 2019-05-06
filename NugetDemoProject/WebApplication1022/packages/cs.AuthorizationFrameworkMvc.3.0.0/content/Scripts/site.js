// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var popup;

function PopupForm(url, title) {
    var formDiv = $('<div/>');
    $.get(url)
        .done(function (response) {
            formDiv[0].innerHTML = response;

            popup = formDiv.dialog({
                autoOpen: true,
                resizable: false,
                title: title,
                height: 500,
                width: 700,
                modal: true,
                close: function () {
                    popup.dialog('destroy').remove();
                }
            });
        }) 
    .fail(function (e) {
            $.notify(e.statusText, {
                globalPosition: 'top center',
                className: 'error'
            });
        });
}
(function ($) {
    $.fn.serializeFormJSON = function () {

        var o = {};
        var a = this.serializeArray();
        $.each(a, function () {
            if (o[this.name]) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
        });
        return o;
    };
})(jQuery);
