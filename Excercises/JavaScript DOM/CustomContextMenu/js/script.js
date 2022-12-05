// Show With Right Click
document.body.addEventListener("contextmenu" , function(e) {
    e.preventDefault();
    contextMenu.classList.add("show");
    contextMenu.style.left = e.pageX + "px";
    contextMenu.style.top = e.pageY + "px";
});
// Hidden With Click
document.body.addEventListener("click" , function(e) {
    contextMenu.classList.remove("show");
});
// Hidden With ESC
document.body.addEventListener("keydown" , function(e) {
    if(e.key == "Escape") {
        contextMenu.classList.remove("show");
    }
});