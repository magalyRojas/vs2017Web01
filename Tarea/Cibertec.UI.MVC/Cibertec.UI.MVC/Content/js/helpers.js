(function (cibertec) {
    cibertec.helpers =
        {
            replaceAll: function (string, find, replace) {
                var result = string.replace(
                    new RegExp(find, 'g'), replace
                );
                return result;

            },
            getAniosArray: function (anioInicio) {
                var hoy = new Date();
                var anios = [];
                for (i = anioInicio; i <= hoy.getFullYear(); i++) {
                    anios.push(i);
                }
                return anios;
            },
            BloquearControls: function () {
                $("input,select,textarea").attr("disabled", "disabled");
                $("#btnGrabar").attr("disabled", "disabled");
            },
            DesbloquearControls: function () {
                $("input,select,button,textarea").removeAttr("disabled");
            },
            SetObjectLocalStorage: function (jsObject, keyStorage) {
                var json = JSON.stringify(jsObject);
                localStorage.setItem(keyStorage, json);
            },
            GetObjectLocalStorage: function (keyStorage) {
                var json = localStorage.getItem(keyStorage);
                return JSON.parse(json);
            },
            validarNumero: function (string) {
                if (isNaN(string)) {
                    //entonces (no es numero) devuelvo el valor cadena vacia 
                    alert("No ingresó un número");
                } else {
                    //En caso contrario (Si era un número) devuelvo el valor 
                    alert("ingresó el número: " + string);
                }
            },
            validarDni: function (dni) {

                if (dni.length == 8 && Number(dni) && dni % 1 == 0) {
                    var expresion_regular_dni = /^\d{8}/;
                    if (expresion_regular_dni.test(dni) == true) {

                        alert('Dni corresponde');
                    }


                    else {
                        alert('Dni no corresponde');
                    }
                }
                else {
                    alert("DNI no corresponde");
                }
            },


            validarTarjeta: function (tarjeta) {
                if (Number(tarjeta)) {
                    if (tarjeta >= 40 && tarjeta <= 49) {
                        alert("Tarjeta Visa");
                    }
                    else
                        if (tarjeta >= 51 && tarjeta <= 55) {
                            alert("Tarjeta Mastercard");
                        }
                        else {
                            alert("Tarjeta no identificada");
                        }
                }
                else {
                    alert("INGRESE NÚMERO VALIDO");
                }


            },
            validarRuc: function (ruc) {
                if (Number(ruc) && ruc % 1 === 0 && ruc.length == 11) {
                    if (ruc.substr(0, 2) == '10' || ruc.substr(0, 2) == '20' || ruc.substr(0, 2) == '15' || ruc.substr(0, 2) == '17') {
                        alert('ES UN RUC VALIDO');
                    }
                    else
                        alert('NO ES UN RUC VALIDO');
                }
                else
                    alert('NO ES UN RUC VALIDO');
            },
            validarFecha: function (string) {
                if (string.length == 10) {
                    var fecha = string.split("/");
                    var dia = fecha[0];
                    var mes = fecha[1];
                    var anio = fecha[2];
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) {
                        if ((dia >= 1 && dia <= 31) && (mes >= 1 && Number(mes) <= 12) && (anio >= 0 && anio <= 9999))
                            alert("ES UNA FECHA VALIDA");
                    }
                    else if (mes == 2) {
                        if ((dia >= 1 && dia <= 28) && (mes >= 1 && Number(mes) <= 12) && (anio >= 0 && anio <= 9999))
                            alert("ES UNA FECHA VALIDA");
                    }
                    else
                        if ((dia >= 1 && dia <= 30) && (mes >= 1 && Number(mes) <= 12) && (anio >= 0 && anio <= 9999))
                            alert("ES UNA FECHA VALIDA");
                        else
                            alert("Cadena no es valida");
                }
                else
                    alert("Cadena no es valida");

            }

        }

})(window.cibertec = window.cibertec || {});