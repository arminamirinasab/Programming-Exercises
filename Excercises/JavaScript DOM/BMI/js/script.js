// Variables
const $ = document,
  weight = $.getElementById("weight"),
  height = $.getElementById("height"),
  weightVal = $.getElementById("weight-val"),
  heightVal = $.getElementById("height-val"),
  result = $.getElementById("result"),
  category = $.getElementById("category");
// Calculate Function
function calculate() {
  // Change Labels
  weightVal.innerHTML = `${weight.value} KG`;
  heightVal.innerHTML = `${height.value} CM`;
  // BMI Formula
  const formula = weight.value / ((height.value / 100) * (height.value / 100));
  // Change Result
  result.innerHTML = formula.toFixed(1);
  // Color & Status Conditions
  switch (true) {
    case formula < 18.5:
      result.style.cssText = "color: #15a7d9;";
      category.innerHTML = "Underweight";
      break;
    case formula > 18.5 && formula < 24.9:
      result.style.cssText = "color: #0be881;";
      category.innerHTML = "Normal Weight";
      break;
    case formula > 24.9 && formula < 29.9:
      result.style.cssText = "color: rgb(256 , 136 , 77)";
      category.innerHTML = "Overweight";
      break;
    case formula > 29.9:
      result.style.cssText = "color: rgb(255 , 94 , 87)";
      category.innerHTML = "Obese";
      break;
  }
}