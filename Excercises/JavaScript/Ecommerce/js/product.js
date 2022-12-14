// Back Button
const back = $.getElementById("back");
back.addEventListener("click" , function() {
history.back();
});
// Get ID
const getMethod = new URLSearchParams(location.search);
const productID = getMethod.get("id");
// Check If ID Exist
if(productID) {
    // DOM Elements
    const prTitle = $.getElementById("prTitle");
    const prDesc = $.getElementById("prDesc");
    const prImg = $.getElementById("prImg");
    const prPrice = $.getElementById("prPrice");
    // Find Product
    let selectedProduct = products.find(function(prd) {
    return prd.id == Number(productID);
    });
    // Assign Product
    prTitle.innerHTML = selectedProduct.name;
    document.title = selectedProduct.name;
    prDesc.innerHTML = selectedProduct.desc;
    prImg.src = imgDir + selectedProduct.src;
    prPrice.innerHTML = "$" + selectedProduct.price;
    // Redirect To Previous Page
} else {
   history.back();
}