var app = {};

$(function () {
    app.iniciarlizar();
});


app.iniciarlizar = function () {

    $('#main-menu').smartmenus();
    app.ObterEsportes();
    app.ObterMarcas();
    app.ClubesInternacionais();
    app.ClubesNacionais();
    app.Selecoes();
}



app.ObterEsportes = function () {

    $.getJSON('/menu/obteresportes', function (data) {

        $(data).each(function () {
            $("#esportes").append("<li><a href='#'>" + this.CategoriaDescricao + "</a></li>");
        });

    });

};

app.ObterMarcas = function () {

    $.getJSON('/menu/obtermarcas', function (data) {

        $(data).each(function () {
            $(".marcas").append("<li><a href='#'>" + this.MarcaDescricao + "</a></li>");
        });

    });

};

app.ClubesNacionais = function () {

    $.getJSON('/menu/ClubesNacionais', function (data) {

        $(data).each(function () {
            $("#clubesnacionais").append("<li><a href='/nav/times/" + this.ClubeCodigo + "/" + this.ClubeSeo + "'>" + this.Clube + "</a></li>");

        });

    });

};


app.ClubesInternacionais = function () {

    $.getJSON('/menu/ClubesInternacionais', function (data) {

        $(data).each(function () {
           $("#clubesinternacionais").append("<li><a href='/nav/times/" + this.ClubeCodigo + "/" + this.ClubeSeo + "'>" + this.Clube + "</a></li>");
        });

    });

};

app.Selecoes = function () {

    $.getJSON('/menu/Selecoes', function (data) {

        $(data).each(function () {
            $("#selecoes").append("<li><a href='/nav/times/" + this.SelecaoCodigo + "/" + this.SelecaoSeo + "'>" + this.Selecao + "</a></li>");
        });

    });

};


