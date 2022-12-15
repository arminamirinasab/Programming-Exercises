// DOM Variables
const $ = document;
const search = $.querySelector("#search");
const searchContainer = $.querySelector(".search-input");
const autocom = $.querySelector(".autocom-box");
// Send Suggestion Value To Input
function setValueToSearchInput(event) {
  searchContainer.classList.remove("active");
  search.value = event.target.innerText;
}
// Input Event
search.addEventListener("input", function () {
  // Get Real Input Value
  let searched = search.value;
  // Check Empty Value
  if (searched) {
    searchContainer.classList.add("active");
    // Filter Data
    let filteredProducts = suggestions.filter(function (word) {
      // Convert To Lowercase & Get Suggestion With Include
      return word.toLowerCase().includes(searched.toLowerCase());
      // Convert To Lowercase & Get Suggestions But  Only Offers That Start With The Input Value
      //   return word.toLowerCase().startsWith(searched.toLowerCase());
    });

    autocom.innerHTML = "";
    if (filteredProducts != "") {
        // Create Suggestion Item
      filteredProducts.forEach(function (item) {
        autocom.insertAdjacentHTML("afterbegin", `<li onclick='setValueToSearchInput(event)'>${item}</li>`);
      });
    } else {
        // Create User Search Item
      autocom.insertAdjacentHTML("afterbegin",`<li onclick='setValueToSearchInput(event)'>${searched}</li>`);
    } // Remove AutoComplete Box
  } else {
    searchContainer.classList.remove("active");
  }
});