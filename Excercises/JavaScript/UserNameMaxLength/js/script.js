// Variables
const UserName = document.querySelector("#UserName"),
  Counter = document.querySelector("#Counter");
// Get Max Length
let UserNameLengthNumber = UserName.getAttribute("maxlength");
// Event
UserName.addEventListener("keyup", function () {
  Counter.innerHTML = UserNameLengthNumber - UserName.value.length;
});