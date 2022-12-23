let months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

let days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

// Varibales
const $ = document,
  searchBox = $.querySelector(".search-box"),
  city = $.querySelector(".city"),
  date = $.querySelector(".date"),
  temp = $.querySelector(".temp"),
  weather = $.querySelector(".weather"),
  hiLow = $.querySelector(".hi-low");

  window.addEventListener("load" , () => {
    let time = new Date();
    date.innerHTML = `${days[time.getDay()]} ${time.getDay()} ${months[time.getMonth()]} ${time.getFullYear()}`;
  });

searchBox.addEventListener("keydown", (e) => {
  let userCity = searchBox.value;

  if (e.keyCode == 13) {
    fetch(
      `https://api.openweathermap.org/data/2.5/weather?q=${userCity}&appid=287533872c770b4e243d06e2311dd32e`,
      { method: "GET" }
    )
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        city.innerHTML = data.name + " , " + data.sys.country;
        weather.innerHTML = data.weather[0].main;
        temp.innerHTML = `${Math.floor(data.main.temp - 273.15)} °c`;
        hiLow.innerHTML = `${(data.main.temp_min - 273.15).toFixed(1)} / ${(
          data.main.temp_max - 273.15
        ).toFixed(1)} °c`;
      }).catch(err => {
city.innerHTML = "Country Or City Not Founded :(";
      
      });
  }
});
