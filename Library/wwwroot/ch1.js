window.MySetFocus = (ctrl) => {
    document.getElementById(ctrl).focus();
    //alert("hello")
    return ctrl;
}

window.MyPop = (msgs) => {
    alert(msgs);
}

window.MyAwait = () => {
    console.log("await...");
}
var scrollFunc = function (e) {
    e = e || window.event;
    if (e.wheelDelta && event.ctrlKey) {//IE/Opera/Chrome
        event.returnValue = false;
    } else if (e.detail) {//Firefox
        event.returnValue = false;
    }
}


/*注册事件*/
if (document.addEventListener) {
    document.addEventListener('DOMMouseScroll', scrollFunc, false);
}//W3C
window.onmousewheel = document.onmousewheel = scrollFunc;