/*
    Problem from Site

    n! means n × (n − 1) × ... × 3 × 2 × 1

    For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

    Find the sum of the digits in the number 100!
*/

var common = require("./common");
var log = require("./log");

function sumDigits(value) {
    var stringNumber = value.toString();

    log.debug(`String Number := ${stringNumber}`);

    var sum = 0;

    for(var i = 0; i < stringNumber.length; i++) {
        sum += parseInt(stringNumber[i]);
    }

    return sum;
}

module.exports = {
    solveProblem: async function () {
        var number = 100;
        
        var factorial = common.factorial(number);

        log.info(`${number}! = ${factorial} | Sum Of Digits := ${sumDigits(factorial)}`)
    }
}