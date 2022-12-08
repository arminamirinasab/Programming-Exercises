// Select HTML Elements
const addForm = document.getElementsByClassName("add")[0],
  todos = document.getElementsByClassName("todos")[0];
// Focus Input For Better Accessibility
addForm.children[1].focus();
// Add Todo
addForm.addEventListener("submit", function (e) {
  e.preventDefault();
  // Create Element & Get Input Value
  let taskContent = addForm.children[1].value;
  let taskItem = document.createElement("li");
  let taskDelete = document.createElement("i");
  // // Add Delete Event to Delete Task Icon
  taskDelete.addEventListener("click", function (e) {
    e.target.parentElement.remove();
  });
  // Set Classes
  taskItem.className =
    "list-group-item d-flex justify-content-between align-items-center";
  taskDelete.className = "fa fa-trash-o delete";
  // Import Datas To Node & Append
  taskItem.innerHTML = `<span>${taskContent}</span>`;
  taskItem.appendChild(taskDelete);
  todos.appendChild(taskItem);
  addForm.children[1].value = "";
});
