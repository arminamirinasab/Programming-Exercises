// GET Data
const getMethodData = location.search;
// Complete Data
let data = getMethodData;
// Split Data Like username=Armin
data = data.slice(1, data.length);
data = data.split("&");
// Split Data To Key | Value
let dataArray = [];
for (let i = 0; i < data.length; i++) {
  // Create Object & Push
  let newObject = {
    key: data[i].split("=")[0],
    value: data[i].split("=")[1],
  };
  dataArray.push(newObject);
}
// Show In Console
console.table(dataArray);

// Check & Add GET Data To URL
if (getMethodData) {
  alert("Open Console To See The Result");
} else {
  location.href += "?username=Armin&password=12345678";
}