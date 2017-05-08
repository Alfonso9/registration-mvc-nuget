$(document).ready(function () {
    //Conjunto de funciones extendidas
    jQuery.fn.extend({
        setRegexOnInput: function () {
            $(this).find('input').each(function () {
                var _Regex = $(this).attr('data-val-regex-pattern');
                console.log(_Regex);
            });
        },
    });
});