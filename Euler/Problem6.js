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

var squareSum = sumOfTheSquares(10);

console.log(`Sum of the Squares ${squareSum}`);