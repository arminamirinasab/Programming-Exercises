// Variables
const Input = document.getElementById("Input"),
  Convert = document.getElementById("Convert"),
  Reset = document.getElementById("Reset"),
  Change = document.getElementById("Change"),
  Message = document.getElementById("Message");

  // Operation
let isFahrenheit = false;

// Set Value With Operation
(function(){
    if (isFahrenheit) {
        document.title = "🔥 Fahrenheit To Celsius";
        Message.innerHTML = "Fahrenheit is 0 ℃"
      } else {
        document.title = "🔥 Celsius To Fahrenheit";
        Message.innerHTML = "Celsius is 0 ℉";
      }
})();

// Celsius & Fahrenheit Functions
function toCelsius(num = 0) {
    return (num - 32) / 1.8;
}

function toFahrenheit(num = 0) {
  return num * 1.8 + 32;
}

// Document Events
Reset.addEventListener("click", function () {
  Input.value = "";
  Input.focus();
});

Convert.addEventListener("click" , function() {
    if (isFahrenheit) {
        Message.innerHTML = `Fahrenheit is ${toCelsius(Input.value).toFixed(2)} ℃`;
      } else {
        Message.innerHTML = `Celsius is ${toFahrenheit(Input.value)} ℉`;
      }
      Input.focus();
});

Change.addEventListener("click", function () {
  if (!isFahrenheit) {
    isFahrenheit = true;
    document.title = "🔥 Fahrenheit To Celsius";
    Message.innerHTML = "Fahrenheit is 0 ℃";
  } else {
    isFahrenheit = false;
    document.title = "🔥 Celsius To Fahrenheit";
    Message.innerHTML = "Celsius is 0 ℉";
  }
  Input.focus();
});
