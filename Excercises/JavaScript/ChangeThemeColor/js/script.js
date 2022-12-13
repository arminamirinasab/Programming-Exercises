// Colors Buttons
const btns = document.getElementsByClassName("btn");
// Set Click Event To All Buttons
for (let i = 0; i < btns.length; i++) {
  btns[i].addEventListener("click", function (e) {
    // Get Color From Dataset
    const datasetColor = e.target.dataset.color;
    // Change CSS Variable
    document.documentElement.style.setProperty("--theme-color", datasetColor);
  });
}