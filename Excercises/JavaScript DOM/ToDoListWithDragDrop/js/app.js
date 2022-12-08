// Variables
const $ = document,
  addBtn = $.getElementById("addBtn"),
  noStatus = $.getElementById("noStatus"),
  Status = $.getElementsByClassName("status");
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
    // Create To Do Element
    const toDoElem = $.createElement("div");
    // Assign Class For Styles
    toDoElem.classList.add("todo");
    // Add Draggable Attribute
    toDoElem.draggable = true;
    // Add Unique ID For Select In Drop
    toDoElem.id = "todo" + idIndex;
    // Send Value To Element
    toDoElem.innerHTML = userInput;
    // Create X Icon
    const toDoX = $.createElement("span");
    // Assign Class For Styles
    toDoX.classList.add("close");
    // Send X To Element
    toDoX.innerHTML = "&times;";
    // Close Event To Remove To Do
    toDoX.addEventListener("click", function (e) {
      e.target.parentElement.remove();
    });
    // Add Drag Start Event To Send ID To Data Transfer
    toDoElem.addEventListener("dragstart", function (e) {
      e.dataTransfer.setData("elem", e.target.id);
    });
    // Append Elements
    toDoElem.appendChild(toDoX);
    noStatus.appendChild(toDoElem);
    // Alert Error For Empty Value
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