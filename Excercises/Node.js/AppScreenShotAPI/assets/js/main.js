let demo = document.querySelector("#demo");

(async function getFromAPI() {
  let Apps = await fetch("http://localhost:3333/images/");
  let AppsArray = await Apps.json();
  AppsArray = AppsArray.sort();
  // Show app cards
  await AppsArray.forEach((app) => {
    demo.innerHTML += `
    <a href="${app.link}" class="item" id="${app.id}">
    <figure title="${app.name}">
      <img src="./api/images/${app.image}" />
    </figure>
  </a>
`;
  });
})();

// Other JS
demo.onclick = (event) => {
  let target = event.target.closest(".item");

  if (target) {
    demo.scrollTo({
      left: target.offsetLeft,
      behavior: "smooth",
    });
  }
};
