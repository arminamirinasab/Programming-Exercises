// Variables

const $ = document,
  bookForm = $.getElementById("book-form"),
  title = $.getElementById("title"),
  author = $.getElementById("author"),
  year = $.getElementById("year"),
  bookList = $.getElementById("book-list");
// LocalStorage Array

let books;

// Create Element In DOM ----------------------------------------------------------

function createElem(title, author, year) {
  const trElem = $.createElement("tr"),
    tdTitleElem = $.createElement("td"),
    tdAuthorElem = $.createElement("td"),
    tdYearElem = $.createElement("td"),
    tdXElem = $.createElement("td");

  tdTitleElem.innerHTML = title;
  tdAuthorElem.innerHTML = author;
  tdYearElem.innerHTML = year;
  tdXElem.innerHTML = "Remove Book";
  tdXElem.style.cssText = "color: red;cursor: pointer;";

  tdXElem.addEventListener("click", removeBook);

  trElem.appendChild(tdTitleElem);
  trElem.appendChild(tdAuthorElem);
  trElem.appendChild(tdYearElem);
  trElem.appendChild(tdXElem);

  bookList.appendChild(trElem);
}

// Check LocalStorage ------------------------------------------------

let lcBooks = localStorage.getItem("books");
if (lcBooks) {
  books = JSON.parse(lcBooks);
  for (let i = 0; i < books.length; i++) {
    createElem(books[i].name, books[i].author, books[i].year);
  }
} else {
  books = [];
}

// Remove Book Function ---------------------------------------------

function removeBook(e) {
  e.target.parentElement.remove();
  // Find Book Index
  let bookIndex = books.findIndex(function (book) {
    return book.name === e.target.parentElement.children[0].innerHTML;
  });
  // Remove From Books & Save In LocalStorage
  books.splice(bookIndex, 1);
  localStorage.setItem("books", JSON.stringify(books));
}

// Add Book Event ----------------------------------------------------

bookForm.addEventListener("submit", function (e) {
  e.preventDefault();
  createElem(title.value, author.value, year.value);
  // Send Book Data To LocalStorage
  books.push({ name: title.value, author: author.value, year: year.value });
  localStorage.setItem("books", JSON.stringify(books));
  // Empty Form
  title.value = "";
  author.value = "";
  year.value = "";
});