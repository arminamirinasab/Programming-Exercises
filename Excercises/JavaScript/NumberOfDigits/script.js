var num = prompt('Please Enter Digits Number: ',0);
var counter = 0;

while(num){
    num = Math.floor(num/10);
    counter++;
}

var element = document.querySelector('#demo');
element.innerHTML += counter;