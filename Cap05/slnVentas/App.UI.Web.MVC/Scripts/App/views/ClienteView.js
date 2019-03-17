(function (app) {
    app.ClienteView =
        {
            RefreshLista: function () {
                $(".buscar").click();
                app.helpers.closeModal("ClienteCreatePopup");
            }
        }
})(window.app = window.app || {});