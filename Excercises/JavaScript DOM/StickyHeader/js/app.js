// Variable
const mainNav = document.getElementById("mainNav");
// Scroll Event On Document
document.addEventListener("scroll", function () {
  if (document.documentElement.scrollTop != 0) {
    mainNav.classList.add("bg-black", "txt-white");
    mainNav.children[1].children[0].src = "images/white.svg";
    mainNav.children[1].children[0].style.height = "50px";
    mainNav.children[1].children[0].style.margin = "5px";
  } else {
    mainNav.classList.remove("bg-black", "txt-white");
    mainNav.children[1].children[0].src = "images/logo.svg";
    mainNav.children[1].children[0].style.height = "84px";
    mainNav.children[1].children[0].style.margin = "0px";
  }
});
