let gallery = document.querySelector("#gallery");

for (let i = 1; i < 19; i++) {
  fetch(`https://jsonplaceholder.typicode.com/photos/${i}`)
    .then(function (response) {
      return response.json();
    })
    .then(function (data) {
      gallery.innerHTML += `
    <div class="column-xs-12 column-md-4">
      <figure class="img-container">
        <img src="${data.url}" />
        <figcaption class="img-content">
          <h2 class="title">${data.title}</h2>
          <h3 class="category">Showcase</h3>
        </figcaption>
        <span class="img-content-hover">
          <h2 class="title">${data.title}</h2>
          <h3 class="category">${data.url}</h3>
        </span>
      </figure>
    </div>`;
    
      // Mousehover effect style
      const imgContent = document.querySelectorAll(".img-content-hover");
      function showImgContent(e) {
        for (var i = 0; i < imgContent.length; i++) {
          x = e.pageX;
          y = e.pageY;
          imgContent[i].style.transform = `translate3d(${x}px, ${y}px, 0)`;
        }
      }
      document.addEventListener("mousemove", showImgContent);
    });
}
