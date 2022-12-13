const cursor = document.getElementById("cursor");
document.addEventListener("mousemove" , function(e) {
cursor.style.top = e.pageY + "px";
cursor.style.left = e.pageX + "px";
});