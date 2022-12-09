// Select HTML Elements
const addForm = document.getElementsByClassName("add")[0],
  todos = document.getElementsByClassName("todos")[0];
// Focus Input For Better Accessibility
addForm.children[1].focus();
// Tasks Array
let tasks = [];

// Update Tasks With Set Tasks Array To LocalStorage
function updateTasks() {
  localStorage.setItem("tasks", JSON.stringify(tasks));
}

function createElem(taskValue) {
  let taskItem = document.createElement("li");
  let taskDelete = document.createElement("i");
  // Add Delete Event to Delete Task Icon
  taskDelete.addEventListener("click", function (e) {
    e.target.parentElement.remove();
    // Find Index To Remove
    const indexOfTask = tasks.findIndex(function (task) {
      return task === e.target.parentElement.children[0].innerHTML;
    });
    // Check Index & Splice In Array
    if (indexOfTask !== -1) {
      tasks.splice(indexOfTask, 1);
    }
    // Update Tasks & Focus
    updateTasks();
    addForm.children[1].focus();
  });

  // Set Classes
  taskItem.className =
    "list-group-item d-flex justify-content-between align-items-center";
  taskDelete.className = "fa fa-trash-o delete";
  // Import Datas To Node & Append
  taskItem.innerHTML = `<span>${taskValue}</span>`;
  taskItem.appendChild(taskDelete);
  todos.appendChild(taskItem);
}

//  Check Local Storage
if (localStorage.getItem("tasks") !== null) {
  // Convert To Array
  tasks = JSON.parse(localStorage.getItem("tasks"));
  // Create Elements Of LocalStorage
  for (x of tasks) {
    createElem(x);
  }
}

// Add Todo
addForm.addEventListener("submit", function (e) {
  e.preventDefault();
  // Create Element & Get Input Value
  let taskContent = addForm.children[1].value;
  // Check Empty Value
  if(taskContent) {
    tasks.push(taskContent);
    updateTasks();
    createElem(taskContent);
  } else {
    alert("Your Input Is Empty :/");
  }

  addForm.children[1].value = "";
});

