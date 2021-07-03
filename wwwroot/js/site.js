// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $('[data-toggle="tooltip"]').tooltip()
});

function Evento(e){
    $('#modalEvento').modal('show');
    e.preventDefault();
};

function Dica(e){
    $('#modalDicas').modal('show');
    e.preventDefault();
};

function Apoio(e){
    $('#modalApoio').modal('show');
    e.preventDefault();
};