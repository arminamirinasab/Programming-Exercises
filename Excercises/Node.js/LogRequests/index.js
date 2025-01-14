const http = require("http");
const fs = require("fs");
const url = require("url");

// Creating an HTTP server
const server = http.createServer((req, res) => {
  let date = new Date();
  let parsedURL = url.parse(req.url, 1);

  // Request block
  let logRequest = {
    method: req.method,
    status_code: String(req.statusCode),
    status_message: String(req.statusMessage),
    host: req.headers["host"],
    date: date.toLocaleString(),
    query: JSON.stringify(parsedURL.query),
    full_url: req.headers["host"] + req.url,
  };

  // Response information for this request
  res.writeHead(200, { "Content-type": "application/json" });
  res.end(JSON.stringify(logRequest));

  fs.readFile("log.json", (error, data) => {
    // Error handling
    if (error) {
      throw error;
    } else {
      // Getting logs and add new log
      let logs = JSON.parse(data);
      logs.push(logRequest);
      // Writing to the log.json
      fs.writeFile("log.json", JSON.stringify(logs), (error) => {
        // Error handling
        if (error) {
          throw error;
        } else {
          console.log("+ New Log Added");
        }
      });
    }
  });
});

// Listening to the server
server.listen(3000, () => {
  console.log("Server is running ...");
});
