//Block Developer Console
/*shortcut.add("Ctrl+Shift+C", function () {
    //
});*/

shortcut.add("F12", function () {
    return null;
});

//Block Save Page Function
shortcut.add("Ctrl+S", function () {
    return null;
});

//Block Print Function - Prile
shortcut.add("Ctrl+P", function () {
    return null;
});

//Change Color Example Function
var theme = "#ff5e00";
shortcut.add("Ctrl+Y", function () {

    if (theme == "#ff5e00") {
        theme = "deeppink";
    } else if (theme == "deeppink") {
        theme = "red";
    } else if (theme == "red") {
        theme = "green";
    } else if (theme == "green") {
        theme = "blue";
    } else if (theme == "blue") {
        theme = "yellow";
    } else if (theme == "yellow") {
        theme = "orange";
    } else if (theme == "orange") {
        theme = "#ff5e00";
    }

    $(':root').css('--MainColor', theme);
    document.cookie = "MainColor=" + theme;

});
