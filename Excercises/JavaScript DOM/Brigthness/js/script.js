const brightness = document.querySelector("#range"),
container = document.querySelector(".container");

brightness.value = 100;

brightness.addEventListener("change" , function() {
    container.style.filter = `brightness(${brightness.value}%)`;
})