$(function() {
    $.get("/api/info/version").then(function (version) {
        document.querySelector("#netversion").innerText = version;
    });

    $.get("/api/info/machine").then(function (version) {
        document.querySelector("#machine").innerText = version;
    });
});