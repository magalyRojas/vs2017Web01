﻿(function (app) {
    var me =
        {
            DetalleVenta: [],
            productoSeleccionado: {},
            Init: function () {
                $("#registrarVenta .btn-buscar-producto").on("click", me.MostrarPopupProductos);
                $("#registrarVenta .agregar").on("click", me.AgregarLista);
                $("#registrarVenta .guardar").on("click", me.Guardar);
            },

            MostrarPopupProductos: function () {

                app.helpers.showModal('BusquedaProductoPopupID',
                    '/Producto/ConsultaProductosStock',
                    me.MostrarProducto
                );
            },
            MostrarProducto: function () {
                me.productoSeleccionado = app.helpers.stateModal;
                $("#registrarVenta .nombre-producto").val(me.productoSeleccionado.Nombre);
                $("#registrarVenta .precio-producto").val(me.productoSeleccionado.PrecioMenor);
            },

            AgregarLista: function () {
                me.productoSeleccionado.Precio = me.productoSeleccionado.PrecioMenor;
                me.productoSeleccionado.Cantidad = $("#registrarVenta .cantidad-producto").val();
                me.productoSeleccionado.SubTotal = me.productoSeleccionado.Cantidad * me.productoSeleccionado.PrecioMenor;

                me.DetalleVenta.push(me.productoSeleccionado);

                var templateDetalle = $("#RegistrarVentaDetalle").html();
                Mustache.parse(templateDetalle);
                var htmlDetalle = Mustache.render(templateDetalle,
                    {
                        Detalle: me.DetalleVenta
                    }
                );

                $("#registrarVenta .detalle-venta").html(htmlDetalle);
            },

            Guardar: function () {
                // haciendo una llamada ajax para recuperar la venta

                var venta = {
                    ClienteId: 1,
                    VentaDetalle: me.DetalleVenta
                };
                // obj tine q tener el mismo nombre public JsonResult Guardar(Venta model)controller
                $.post("/Venta/Guardar", { model: venta },
                    function (response) {
                        if (response) {
                            app.helpers.ShowMessageSuccess("se registro correctamente la venta");
                        }

                    });
            }
        }

};
app.RegistrarVentaView = me;

}) (window.app = window.app || {});