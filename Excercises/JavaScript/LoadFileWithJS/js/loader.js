// Document Variable
const $ = document;
// Help
alert("See The Source Code :)");
// File Loader Function
function fileLoader(source) {
  // Use Promise
  return new Promise((resolve, reject) => {
    // Create Element
    let file = $.createElement("link");
    file.rel = "stylesheet";
    file.href = source;
    // File Events
    file.addEventListener("error", () => {
      reject("Error In Load File");
    });
    file.addEventListener("load", () => {
      resolve("File Loaded Successfuly");
    });
// Append To Head
    $.head.appendChild(file);
  });
}

fileLoader("css/style.css")
  .then((message) => {
    // Show Success Message
    console.log(message);
  })
  .catch((message) => {
    // Show Error
    console.error(new Error(message));
  });