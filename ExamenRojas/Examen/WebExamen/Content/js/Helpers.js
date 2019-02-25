(function (cibertec) {
    cibertec.helpers =
        {
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
            }
        }
})(window.cibertec = window.cibertec || {});