const $ = document;
const imagesDir = "./images/";

let products = [
  { id: 1, name: "Beautiful Color", src: "p1.png", price: 12.49 },
  { id: 2, name: "Dark Color", src: "p2.png", price: 15.99 },
  { id: 3, name: "Light Room", src: "p3.png", price: 40.25 },
  { id: 4, name: "Blue Color", src: "p4.png", price: 7.5 },
];

let shopingCart = [
  { id: 1, count: 2 },
  { id: 4, count: 4 }
];

const shopItems = $.getElementsByClassName("shop-items")[0];
const cartItems = $.getElementsByClassName("cart-items")[0];

// Add To Cart Function ------------------------------------------------------

function addToCart(id) {
  let filteredPrd = products.filter(function (prd) {
    return prd.id === id;
  });

  let duplicatePrd = shopingCart.find(function (fnd) {
    return fnd.id === id;
  });

  if (duplicatePrd) {
    let findDuplicateprd = shopingCart.findIndex(function (sh) {
      return sh == duplicatePrd;
    });
    shopingCart[findDuplicateprd].count++;
  } else {
    let newObject = { id: filteredPrd[0].id, count: 1 };
    shopingCart.push(newObject);
  }

  refreshProducts();
}

// Create & Show Products In DOM ---------------------------------------------

function createDOMproduct(pid, pname, psource, pprice) {
  let shopItem = $.createElement("div");
  shopItem.classList.add("shop-item");
  let shopItemTitle = $.createElement("span");
  shopItemTitle.classList.add("shop-item-title");
  shopItemTitle.innerText = pname;
  shopItem.appendChild(shopItemTitle);
  let shopItemImage = $.createElement("img");
  shopItemImage.classList.add("shop-item-image");
  shopItemImage.src = `${imagesDir}${psource}`;
  shopItem.appendChild(shopItemImage);
  let shopItemDetails = $.createElement("div");
  shopItemDetails.classList.add("shop-item-details");
  shopItem.appendChild(shopItemDetails);
  let shopItemPrice = $.createElement("b");
  shopItemPrice.classList.add("shop-item-price");
  shopItemPrice.innerText = `$${pprice}`;
  shopItemDetails.appendChild(shopItemPrice);
  let shopItemButton = $.createElement("button");
  shopItemButton.className = "btn btn-primary shop-item-button";
  shopItemButton.innerText = "Add To Cart";
  shopItemDetails.appendChild(shopItemButton);

  shopItemButton.addEventListener("click", function () {
    addToCart(pid);
  });

  return shopItem;
}

for (const prd of products) {
  shopItems.appendChild(createDOMproduct(prd.id, prd.name, prd.src, prd.price));
}

// Show Shoping Cart ---------------------------------------------------------

function createshopingCartItems(sname, ssource, sprice, scount, sid) {
  let cartRow = $.createElement("div");
  cartRow.classList.add("cart-row");
  let cartItem = $.createElement("div");
  cartItem.className = "cart-item cart-column";
  let cartItemImage = $.createElement("img");
  cartItemImage.src = imagesDir + ssource;
  cartItemImage.width = "100";
  cartItemImage.height = "100";
  let cartItemTitle = $.createElement("span");
  cartItemTitle.classList.add("cart-item-title");
  cartItemTitle.innerText = sname;
  let cartPrice = $.createElement("span");
  cartPrice.className = "cart-price cart-column";
  cartPrice.innerText = `$${sprice}`;
  let cartQuantity = $.createElement("div");
  cartQuantity.className = "cart-quantity cart-column";
  let cartQuantityInput = $.createElement("input");
  cartQuantityInput.classList.add("cart-quantity-input");
  cartQuantityInput.type = "number";
  cartQuantityInput.value = scount;
  let cartRemoveBtn = $.createElement("button");
  cartRemoveBtn.className = "btn btn-danger";
  cartRemoveBtn.innerText = "Remove";
  cartRemoveBtn.addEventListener("click", function () {
    removeProduct(sid);
  });
  cartQuantity.append(cartQuantityInput, cartRemoveBtn);
  cartRow.append(cartItem, cartPrice, cartQuantity);
  cartItem.append(cartItemImage, cartItemTitle);

  return cartRow;
}

// Show & Update Shoping Cart Prodcuts ---------------------------------------

function refreshProducts() {
  cartItems.innerHTML = "";
  for (const prod of shopingCart) {
    let selectedPrd = products.filter(function (prd) {
      return prd.id === prod.id;
    });

    cartItems.appendChild(
      createshopingCartItems(
        selectedPrd[0].name,
        selectedPrd[0].src,
        selectedPrd[0].price,
        prod.count,
        selectedPrd[0].id
      )
    );
  }
}
refreshProducts();

// Remove Product Function -------------------------------------------------------

function removeProduct(id) {
  let removeIndexOf = shopingCart.findIndex(function (prd) {
    return prd.id === id;
  });
  shopingCart.splice(removeIndexOf, 1);
  refreshProducts();
}