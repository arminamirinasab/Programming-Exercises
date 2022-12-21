// Variables
const $ = document;
const profileImage = $.querySelector("#profile");
const profileName = $.querySelector("#name");
const profileAge = $.querySelector("#age");
const profileLocation = $.querySelector("#location");
const profileEmail = $.querySelector("#email");
const profilePhone = $.querySelector("#phone");
const profilenat = $.querySelector("#nat");

const loading = $.querySelector(".loading");

// Random User API
fetch("https://randomuser.me/api/", {
  method: "GET",
})
  .then((response) => {
    return response.json();
  })
  .then((data) => {
    data = data.results[0];
    // Show In DOM
    profileImage.src = data.picture.large;
    profileName.innerHTML = `${data.name.first} ${data.name.last}`;
    profileAge.innerHTML = data.dob.age;
    profileLocation.innerHTML = `${data.location.country} , ${data.location.city}`;
    profileEmail.innerHTML = data.email;
    profilePhone.innerHTML = data.phone;
    profilenat.innerHTML = data.nat;
    // Log Data
    console.log(data);
    // Delete Loading
    loading.style.opacity = "0";
    loading.style.visibility = "hidden";
    setTimeout(() => {
      loading.remove();
    }, 700);
  });
