const express = require("express");
const app = new express();
app.use(express.json());

// Simple data
let users = [
  {
    id: 1,
    name: "Ali Reza",
    email: "ali.reza@example.com",
    age: 30,
  },
  {
    id: 2,
    name: "Sara Mohammadi",
    email: "sara.mohammadi@example.com",
    age: 25,
  },
  {
    id: 3,
    name: "Mohammad Javad",
    email: "mohammad.javad@example.com",
    age: 28,
  },
];

// Routes
app.get("/users", (req, res) => {
  res.status(200).send(users);
});

app.get("/users/:id", (req, res) => {
  res.status(200).send(users.find((user) => user.id == req.params.id));
});

app.post("/users/add", (req, res) => {
  users.push(req.body);
  res.status(200).send("User added successfuly");
});

app.delete("/users/remove/:id", (req, res) => {
  users = users.filter((user) => user.id != req.params.id);
  res.status(200).send("User removed successfuly");
});

// Listen to server
app.listen(3000, () => {
  console.log("Server is running on port 3000 ...");
});
