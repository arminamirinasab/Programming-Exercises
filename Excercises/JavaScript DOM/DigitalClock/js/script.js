// Variables
const hour = document.getElementById("hour"),
  minute = document.getElementById("minute"),
  seconds = document.getElementById("seconds");
// Refresh Time
setInterval(function () {
  const time = new Date();
  // Second
  if (time.getSeconds() < 10) {
    seconds.innerHTML = "0" + time.getSeconds();
  } else {
    seconds.innerHTML = time.getSeconds();
  }
  // Minute
  if (time.getMinutes() < 10) {
    minute.innerHTML = "0" + time.getMinutes();
  } else {
    minute.innerHTML = time.getMinutes();
  }
  // Hour
  if (time.getHours() < 10) {
    hour.innerHTML = "0" + time.getHours();
  } else {
    hour.innerHTML = time.getHours();
  }
}, 1000);