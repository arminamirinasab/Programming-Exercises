// Variables
const modalButton = document.getElementById("modalButton"),
modal = document.getElementsByClassName("modal-parent")[0],
section = document.getElementById("section"),
X = document.getElementsByClassName("X")[0];
// Open With Click
modalButton.addEventListener("click" , function() {
modal.style.display = "block";
section.style.filter = "blur(10px)";
});
// Close With X Icon
X.addEventListener("click" , function() {
    X.parentElement.parentElement.style.display = "none";
    section.style.filter = "inherit";
})
// Close With ESC Key
window.addEventListener("keyup" , function(e) {
    if(e.key === "Escape") {
        X.parentElement.parentElement.style.display = "none";
        section.style.filter = "inherit";
    }
})