$(function () {
    var Origins = $("#Origins");
    var Destine = $("#Destine");
    var Airline = $("#Airline");
    var Flys = $("#Flys");

    $.post("/Select/City", function (data) {
        console.log(data);
        for (var i = 0; i < data.length; i++) {
            Origins.append(`<option value="${data[i].keys}">${data[i].vals}</option>`);
            Destine.append(`<option value="${data[i].keys}">${data[i].vals}</option>`);
        }

    })

    $.post("/Select/Airline", function (data) {
        console.log(data);
        for (var i = 0; i < data.length; i++) {
            Airline.append(`<option value="${data[i].keys}">${data[i].vals}</option>`);
        }
    })

    $("#Airline").change(function () {
        var Airline = ("#Airline").vals;
        $.post("/Select/Filter", { id: this.value }, function (data) {
            for (var i = 0; i < data.length; i++) {
                Flys.append(`<option value="${data[i].keys}">${data[i].vals}</option>`);
            }
        });


    })

})

function CambiaEstado(id, value) {
    $.post("/Vuelo/ChangeStatus", { Numero_Vuelo: id, Estado: value }, function (response) {
        alert("Se editó el estado del vuelo");
    })
}
