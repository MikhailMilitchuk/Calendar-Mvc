// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('.overlay, .modal-close').click(function () {
    $('.modal, .overlay').removeClass('shown');
});

$('.open-modal').click(function () {
    let modalId = $(this).data('modal-id');
    $('.overlay, #' + modalId).addClass('shown');
});

