let singleTitle = document.querySelector("#singleTitle");
let singlePrice = document.querySelector("#singlePrice");
let singleDescription = document.querySelector("#singleDescription");
let singleImage = document.querySelector("#singleImage");

let breadTitle = document.querySelector("#breadTitle");
let breadCategory = document.querySelector("#breadCategory");

async function getSingleProdcut() {
  let rand = Math.floor(Math.random() * 20) + 1;
  const response = await fetch(`https://fakestoreapi.com/products/${rand}`);
  let data = await response.json();
  console.log(data);
  singleTitle.innerHTML = breadTitle.innerHTML = data.title;
  singlePrice.innerHTML = "$" + data.price;
  singleDescription.innerHTML = data.description;
  singleImage.src = data.image;
  breadCategory.innerHTML = data.category;
}

let releated = document.querySelector("#releated");
async function getReleatedProduct() {
  const response = await fetch("https://fakestoreapi.com/products?limit=3");
  let data = await response.json();
  for (let i = 0; i < data.length; i++) {
    releated.innerHTML += `
    <div class="column-xs-12 column-md-4">
   <img src="${data[i].image}"/>
    <h4>${data[i].title}</h4>
    <p class="price">$${data[i].price}</p>
  </div>
`;
  }

  console.log(data);
}
getSingleProdcut();
getReleatedProduct();
