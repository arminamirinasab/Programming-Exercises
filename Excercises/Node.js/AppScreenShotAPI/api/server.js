const http = require("http");
const Apps = require("./apps.js");
// Create server with Node
const server = http.createServer((request, response) => {
  response.setHeader("Access-Control-Allow-Origin", "*");
  // Check method and URL for write JSON
  if ((request.url == "/images/" || request.url == "/images") && request.method == "GET") {
    response.writeHead(200, { "Content-type": "application/json" });
    response.write(JSON.stringify(Apps.Apps));
  } else {
    // 406 code for invalid responses
    response.writeHead(406, { "Content-type": "text/plain" });
    response.write("Welcome to my first API :) \n Please send request to localhost:3333/images/");
  }
  response.end();
});
// Listen to port
server.listen(3333, () => {
  console.log("Server running successfully");
});
