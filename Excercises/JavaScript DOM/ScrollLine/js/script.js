// Help
alert("Scroll To See Scroll Line :)");
// Variables
const scrollLine = document.getElementById("scroll-line");
// Minus Total Page Height From Window InnerHeight To Detect From ScrollY
const pageHeight = document.body.clientHeight - window.innerHeight;
// Scroll Event
window.addEventListener("scroll", function () {
  // Calculate Height Percentage
  let heightPercent = Math.floor(window.scrollY / (pageHeight / 100));
  // Change Style
  scrollLine.style.width = `${heightPercent}%`;
});