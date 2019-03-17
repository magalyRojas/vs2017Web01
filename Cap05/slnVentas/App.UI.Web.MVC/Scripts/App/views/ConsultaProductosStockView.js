(function (app) {
    app.ConsultaProductosStockView =
        {
            Init: function () {
                $(".ConsultaProductosStock .Buscar").on("click", this.Buscar);
                jsGrid.locale("es");
                $("#ListaProductos").jsGrid(
                    {
                        width: "100%",
                        height: "400px",
                        paging: true,
                        pageSize: 200,
                        pageIndex: 1,
                        autoload: true,
                        pageLoading: true,
                        fields: [
                            {
                                itemTemplate: function (_, item) {
                                    return $("<input>").attr("type", "radio")
                                        .attr("name", "productos")
                                        .on("change", function () {
                                            app.helpers.closeModal("BusquedaProductoPopupID",item);
                                        }); /*para eliegir solo uno attr("name", "productos")*/
                                }
                            },
                            { name: "Nombre", title: "Nombre", type: "text", width: 150 },
                            { name: "PrecioMenor", title: "Precio", type: "text", width: 150 },
                            { name: "StockActual", title: "Stock", type: "text", width: 150 },


                        ],
                        controller:
                            {
                                loadData: function (filter) {


                                    var d = $.Deferred(); //resultado diferido

                                    $.ajax(
                                        {
                                            url: "/Producto/BuscarProductosStock",
                                            data: filter,
                                            dataType: "json"
                                        }
                                    ).done(
                                        function (response) {
                                            var data = {
                                                data: response.Listado, itemsCount: response.TotalRows
                                            }
                                            d.resolve(data);
                                        }
                                    );
                                    //retorna resulatdo diferido
                                    return d.promise();

                                }
                            }
                    }
                );
            },
            Buscar: function () {
                var filtros = {
                    Nombre: $(".ConsultaProductosStock .Nombre").val(),
                    Stock: $(".ConsultaProductosStock .Stock").val()
                }
                var grid = $("#ListaProductos").jsGrid("search", filtros);


            }
        }

})(window.app = window.app || {});