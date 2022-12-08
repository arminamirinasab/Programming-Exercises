// Hint
alert("Drag JS Frameworks To The Box");
// Variables
const box = document.getElementById("drop");
// Drag In & Send Data
function dragIn(event) {
  event.dataTransfer.setData("elem", event.target.id);
}
// Drop , Get Data & Append
box.addEventListener("drop", function (e) {
  let newElemId = document.getElementById(e.dataTransfer.getData("elem"));
  box.append(newElemId);
});
// PreventDefault For Drop
box.addEventListener("dragover", function (e) {
  e.preventDefault();
});
