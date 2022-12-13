// DataBase

const listItems = [
  { id: 1, name: "Amin", family: "Saeedi Rad" },
  { id: 2, name: "Amir", family: "Zehtab" },
  { id: 3, name: "Qadir", family: "Yolme" },
  { id: 4, name: "Babak", family: "Mohammadi" },
  { id: 5, name: "Hasan", family: "Ghahreman Zadeh" },

  { id: 6, name: "Ahmad", family: "Rezvani" },
  { id: 7, name: "Mahbod", family: "Zehtab" },
  { id: 8, name: "Adam", family: "Yolme" },
  { id: 9, name: "Afagh", family: "Mohammadi" },
  { id: 10, name: "Hasan", family: "Akari" },

  { id: 11, name: "Saeed", family: "Ehsani" },
  { id: 12, name: "Siamak", family: "Modiri" },
  { id: 13, name: "Mohsen", family: "Ansari" },
  { id: 14, name: "Mehran", family: "Ali Pour" },
  { id: 15, name: "Amir Hossein", family: "Mahtabi" },

  { id: 16, name: "Hossein", family: "Amino" },
  { id: 17, name: "Melika", family: "Ehsani" },
  { id: 18, name: "Qadir", family: "Yolme" },
  { id: 19, name: "Fatemeh", family: "Alilou" },
  { id: 20, name: "Ehsan", family: "Tayyebi" },

  { id: 21, name: "Zahra", family: "Gholami" },
  { id: 22, name: "Matin", family: "Sahebi" },
];

// Variables

const list = document.getElementById("list");
const pages = document.getElementById("pagination");

let currentPage = 1;
let row = 5;

// Return Related Users Function ---------------------------------------------------------------

function pagination(e) {
  // Empty Users List
  list.innerHTML = "";
  // Check Event For Run Function Before Click
  if (e) {
    currentPage = e.target.innerHTML;
  }
  // Calculate Start & End Point
  let start = currentPage * row - row;
  let end = currentPage * row;
  // Slice Selected Users
  let relatedUsers = listItems.slice(start, end);
  // Create Elements
  for (let i = 0; i < relatedUsers.length; i++) {
    const userElem = document.createElement("div");
    userElem.classList.add("item");
    userElem.innerHTML = relatedUsers[i].name + " " + relatedUsers[i].family;
    list.appendChild(userElem);
  }
}

pagination();

// Create Pagination Buttons -------------------------------------------------------------------

// Calcluate Pagination Count
let paginationCount = Math.ceil(listItems.length / row);
// Create Pagination Buttons
for (let i = 1; i <= paginationCount; i++) {
  const pageBtnElem = document.createElement("button");
  pageBtnElem.innerHTML = i;
  pageBtnElem.addEventListener("click", pagination);
  pages.appendChild(pageBtnElem);
}