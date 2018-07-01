/*
    The sum of the squares of the first ten natural numbers is,

    1^2 + 2^2 + ... + 10^2 = 385
    The square of the sum of the first ten natural numbers is,

    (1 + 2 + ... + 10)^2 = 55^2 = 3025
    Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

    Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

var common = require("./common");

function sumOfTheSquares(number) {
    var sum = 0;

    for(var i = 1; i <= number; i++) {
        sum += Math.pow(i, 2);
    }

    return sum;
}

function sumOfNumbers(number) {
    var sum = 0;

    for(var i = 1; i <= number; i++) {
        sum += i;
    }

    return sum;
}

var maxNumber = 100;

var squareSum = sumOfTheSquares(maxNumber);
var summedSquared = Math.pow(sumOfNumbers(maxNumber), 2);
var difference = summedSquared - squareSum;

console.log(`Sum of the Squares ${squareSum} up to ${maxNumber}`);
console.log(`Square Sum ${summedSquared} up to ${maxNumber}`);
console.log(`           Difference ${summedSquared} - ${squareSum} = ${difference}`);