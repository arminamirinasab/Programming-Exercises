// Variable
const switchElement = document.querySelector(".switch");
// Dark Mode Flag
let isDark = false;
// Get LocalStorage Item
const saveTheme = localStorage.getItem("theme");
// Check Dark Mode In LocalStorage
if(saveTheme === "dark") {
  /* Dark Mode Styles Are In The Style.css File
  & We Only Toggle Dark Class To Body */
  document.body.classList.add("dark");
  isDark = true;
}
// Dark Mode Toggle Event
switchElement.addEventListener("click", function () {
  // Check & Update LocalStorage
  if (isDark) {
    isDark = false;
    localStorage.setItem("theme" , "light");
  } else {
    isDark = true;
    localStorage.setItem("theme" , "dark");
  }
  // Toggle Class
  document.body.classList.toggle("dark");
});