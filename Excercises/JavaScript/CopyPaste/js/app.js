// Variables
const copy = document.querySelector("#copy");
const paste = document.querySelector("#paste");
const input = document.querySelector("#input");
// Focus TextArea
input.focus();
// Back To Default of Buttons Text
input.addEventListener("input" , () => {
    paste.firstElementChild.innerHTML = "Paste";
    copy.firstElementChild.innerHTML = "Copy";
});
// Copy
copy.addEventListener("click", () => {
  if (navigator.clipboard && input.value) {
    navigator.clipboard.writeText(input.value);
    // Change Button Text & Select
    copy.firstElementChild.innerHTML = "Copied";
    input.select();

  } else {
    alert("The textarea is empty or your browser does not support clipboard");
  }
});
// Paste
paste.addEventListener("click", () => {
  if (window.navigator.clipboard) {
    navigator.clipboard.readText().then(res => {input.value = res});
    // Change Button Text & Focus
    input.focus();
    paste.firstElementChild.innerHTML = "Pasted";
  } else {
    alert("your browser does not support clipboard");
  }
});