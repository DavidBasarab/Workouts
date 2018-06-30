function isMultipleOf(value, multipleNumber) {
    return value % multipleNumber == 0;
}

function isMultipleOf5(value) {
    return isMultipleOf(value, 5);
}

function isMultipleOf3(value) {
    return isMultipleOf(value, 3);
}

console.log("This is going to be Problem 1");

var sum = 0;
var stoppingNumber = 1000;

for(var i = 0; i < stoppingNumber; i++) {
    if(isMultipleOf3(i) || isMultipleOf5(i)) {
        sum += i;
    }
}

console.log(`Sum to ${stoppingNumber} is ${sum}`);