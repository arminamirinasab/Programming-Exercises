window.addEventListener("online" , function() {
document.getElementById("status").innerText = "You Are Online";
});

window.addEventListener("offline" , function() {
    document.getElementById("status").innerText = "You Are Offline";
    });