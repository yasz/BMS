window.MySetFocus = (ctrl) => {
    document.getElementById(ctrl).focus();
    //alert("hello")
    return ctrl;
}

window.MyPop = (msgs) => {
    alert(msgs);
}