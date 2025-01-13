const fileSystem = require("fs");

// Read the contents of a simple text file
let note = fileSystem.readFileSync("note.txt", "utf-8");
console.log(note);
console.log("-----------------------------------");

// Read the contents of a JSON file
fileSystem.readFile("data.json", (error, data) => {
  // Error handling
  if (error) throw error;
  // Iterate over each brand in the JSON data
  JSON.parse(data).forEach((brand) => {
    console.log(`      ${brand.name} Cars:`);
    console.log("-----------------------------------");
    // Iterate over each car model in the brand
    brand.models.forEach((car) => {
      console.log(`   Name: ${car.name}`);
      console.log(`   Year: ${car.year}`);
      console.log(`   Engine: ${car.engine}`);
      console.log(`   Price: $${car.price}`);
      console.log("-----------------------------------");
    });
  });
});