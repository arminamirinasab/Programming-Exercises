const fileSystem = require("fs");

// Write the contents of a simple text file
fileSystem.writeFileSync("note.txt", "This is a simple text write by Node.js from a text file.");

fileSystem.readFile("data.json", (error, data) => {
  if (error) throw error;
  let books = JSON.parse(data);
  books.push({
    title: "Rostam and Sohrab",
    author: "Ferdowsi",
    publisher: "Amir Kabir Publications",
    year: 1010,
    pages: 160,
  });
  // Write JSON array in data.json file
  fileSystem.writeFile("data.json", JSON.stringify(books), (error) => {
    if (error) {
      throw error;
    } else {
      console.log("Files writed successfuly");
    }
  });
});
