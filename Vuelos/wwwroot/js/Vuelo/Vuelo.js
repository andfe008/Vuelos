$(function () {
    var Origins = $("#Origins");
    var Destine = $("#Destine");
    var Airline = $("#Airline");
    var Flys = $("#Flys");

    $.post("/Select/City", function (response) {
        for (var i = 0; i < response.length; i++) {
            debugger
            Origins.append(`<option value="${response[i].keys}">${response[i].vals}</option>`);
            Destine.append(`<option value="${response[i].keys}">${response[i].vals}</option>`);
        }

    })

    $.post("/Select/Airline", function (response) {
        for (var i = 0; i < response.length; i++) {
            Airline.append(`<option value="${response[i].keys}">${response[i].vals}</option>`);
        }
    })

    $("#Airline").change(function () {
        var Airline = ("#Airline").vals;
        $.post("/Select/Filter", { id: this.value }, function (response) {
            for (var i = 0; i < response.length; i++) {
                Flys.append(`<option value="${response[i].keys}">${response[i].vals}</option>`);
            }
        });


    })

})

function CambiaEstado(id, value) {
    $.post("/Vuelo/ChangeStatus", { Numero_Vuelo: id, Estado: value }, function (response) {
        alert("Se editó el estado del vuelo");
    })
}
