const container = $.getElementsByClassName("container")[0];

// Show Products
products.forEach(function(product) {
    container.insertAdjacentHTML("afterbegin" , `<div class="product-card">
    <h1>${product.name}</h1>
    <p>${product.desc}</p>
    <div class="product-pic" style="background-image: url(${imgDir + product.src});"></div>
    <div class="product-info">
      <div class="product-price">$${product.price}</div>
      <a href="product.html?id=${product.id}" class="product-button">See More</a>
    </div>
    </div>`);
});

