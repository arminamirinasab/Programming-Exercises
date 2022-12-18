// Get String
let userInput = prompt("Enter Your String:");
// Use SET To Remove Duplicate Chars
let removeChars = new Set(userInput.toUpperCase());

// Assign Chars to Result Variable
let result = "";
for (const key of removeChars) {
  result += key + " ";
}
// Check Empty Value & Show Result
result ? alert(result) : alert("Your Input Is Empty");