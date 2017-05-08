$(document).ready(function () {
    //Función extendida de JQUERY para generar una solicitud con un objeto form
    jQuery.fn.extend({
        request: function () {
            var f = $(this), r = $.ajax({
                type: f.attr('method'),
                url: f.attr('action'),
                data: f.serialize(),
                async: true
            })
                .done(function (d) {                  
                    var r = JSON.parse(d);
                    if (r.Codigo === "1") {
                        //Personalizar
                        alert('Done');
                    }
                    else if (r.Codigo === "2") {
                        //var sErrores = "", i = 0;
                        //$.each(r.Error, function (key, data) {
                        //    if (data.length > 0) {
                        //        sErrores += $('[for $=' + removerPuntos(key) + ']').first().text() + '\n' + data[0] + '\n';
                        //        return false;
                        //    }
                        //});

                        //alert('Errors: \n' + sErrores);
                    }
                })
               .fail(function () {
                   //Personalizar
                   alert('fail');
               });

            return r;
        }
        
    });
});