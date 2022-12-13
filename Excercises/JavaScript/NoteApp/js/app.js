// Variables
const btnDelete = document.getElementById("btnDelete"),
  inputField = document.getElementById("inputField"),
  btnSave = document.getElementById("btnSave"),
  listed = document.getElementById("listed"),
  forDelete = document.getElementsByClassName("forDelete");

let saveColored = "#FFF";

// Functions
function setColor(bgColor, textColor = "#333") {
  inputField.style.backgroundColor = bgColor;
  saveColored = bgColor;
  // Create CSS Variable For Placeholder
  inputField.style.setProperty("--c", textColor);
  // (Better Accessibility)
  inputField.focus();
}

function addNote() {
  // Create Note Container
  let noteContainer = document.createElement("div");
  noteContainer.setAttribute("class", "card shadow-sm rounded forDelete");
  noteContainer.style.backgroundColor = saveColored;
  // Create Note Content
  let noteContent = document.createElement("p");
  noteContent.setAttribute("class", "card-text p-3");
  noteContent.innerHTML = inputField.value;
  // Append
  noteContainer.appendChild(noteContent);
  listed.appendChild(noteContainer);
  // Set Remove Event
  noteContainer.addEventListener("click", function (e) {
    e.target.parentElement.remove();
  });
  // (Better Accessibility)
  inputField.value = "";
  inputField.focus();
}

// Clear Button
btnDelete.addEventListener("click", function () {
  inputField.value = "";
  inputField.focus();
});
// Add With Enter
btnSave.addEventListener("click", addNote);
inputField.addEventListener("keyup", function (e) {
  if (e.key === "Enter") addNote();
});
