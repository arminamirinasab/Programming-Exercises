// With Function Declaration

function sum() {
  let sum = 0;
  let Args = Array.from(arguments);
  for (let i = 0; i < Args.length; i++) {
    sum += Args[i];
  }
  return sum;
}

// With Arrow Function
/*
let sum = (...args) => {
    let sum = 0;
    for (let i = 0; i < args.length; i++) {
      sum += args[i];
    }
    return sum;
}
*/
console.log(sum(10, 20, 5, 7, 47, 89, 36, 14, 15, 71, 23, 12, 39));
