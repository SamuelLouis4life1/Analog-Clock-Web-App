// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


jQuery(function ($) {
    console.log('hi');
    //   $("#date").mask("99/99/9999",{placeholder:"mm/dd/yyyy"});
       $("#phone").mask("(999) 999-9999");
    //   $("#tin").mask("99-9999999");
    //   $("#ssn").mask("999-99-9999");
    $('.telephone').mask("(999)-999-9999");
});

$(":input").inputmask();

$("#phone").inputmask({ "mask": "(999) 999-9999" });
