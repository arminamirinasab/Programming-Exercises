function sum() {
  let sum = 0;
  for (let i = 0; i < arguments.length; i++) {
    sum += arguments[i];
  }
  return sum;
}

console.log(sum(10 , 20 , 5 , 7 , 47 , 89 , 36 , 14 , 15 , 71 , 23 , 12 , 39));
