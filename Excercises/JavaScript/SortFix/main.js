let numbers = [51, 9 , 101, 198, 45]
console.log("Our numbers: ", numbers)
console.log("Our numbers if we use sort without callback function:", numbers.sort())
console.log("Our number when we use callback function: ", numbers.sort((n1, n2) => n1 - n2))
// Check https://www.w3schools.com/js/js_array_sort.asp for the reason