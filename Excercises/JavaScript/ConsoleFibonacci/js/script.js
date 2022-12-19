// Variables
let num1 = +prompt("Enter Number One:" , 1);
let num2 = +prompt("Enter Number Two:" , 1);
// Third Variable to Save Sum & Last Number;
let num3 = 0;
// Inifinty Loop
while(true) {
    // Save Sum
    num3 = num1 + num2;
    // Show Result & Check For Break Loop
    if(!confirm(`Cancel To Break Fibonacci Sequence ➕ \n ${num1} + ${num2} = ${num3}`)) break;
    // Transfer Values
    num1 = num2;
    num2 = num3;
}
