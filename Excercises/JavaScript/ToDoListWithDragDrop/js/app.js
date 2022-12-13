// Variables
const $ = document,
  addBtn = $.getElementById("addBtn"),
  noStatus = $.getElementById("noStatus"),
  Status = $.getElementsByClassName("status");
// Remove Task Function
function removeTask(event) {
  event.target.parentElement.remove();
}
// Send Drag Data Function
function sendDragData(event) {
  event.dataTransfer.setData("elem", event.target.id);
}
// ID Index To Create Unique ID
let idIndex = 0;
// Add To Do Event
addBtn.addEventListener("click", function () {
  // Add Id Index
  idIndex++;
  // Get User To Do Content
  const userInput = prompt("Enter Your To Do Name:");
  // Check Value
  if (userInput) {
    // Create HTML Element & Assign Functions
    noStatus.insertAdjacentHTML(
      "beforeend",
      `<div ondragstart="sendDragData(event)" id="todo${idIndex}" class="todo"
     draggable="true">${userInput}<span class="close" onclick="removeTask(event)">&times;</span></div>`
    );
  } else {
    alert("You Should Type Your Task Name :/");
  }
});

for (let i = 0; i < Status.length; i++) {
  // Drag Enter Event For Scale To 1.1 Of Status Box
  Status[i].addEventListener("dragenter", function (e) {
    Status[i].style.transform = "scale(1.1)";
  });
  // Drag Leave Event For Change Scale To 1
  Status[i].addEventListener("dragleave", function () {
    Status[i].style.transform = "scale(1)";
  });
  // Get Data Transfer & Append
  Status[i].addEventListener("drop", function (e) {
    // Change Scale To 1 After Drop
    Status[i].style.transform = "scale(1)";
    let newElemId = $.getElementById(e.dataTransfer.getData("elem"));
    Status[i].append(newElemId);
  });
  // PreventDefault For Dragover Event
  Status[i].addEventListener("dragover", function (e) {
    e.preventDefault();
  });
}