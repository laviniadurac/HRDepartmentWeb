// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let tech = function () {
    $(function () {
        $("#technologies").selectpicker('refresh');
    });
}

let experiences = function () {
    $(function () {
        $("experiences").selectpicker();
    });
}


let ExperienceObject = function () {
    return {
        Tech: tech,
        Experiences: experiences
    };
}();

