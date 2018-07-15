/*
     Problem from Site

    Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
    If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

    For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

    Evaluate the sum of all the amicable numbers under 10000.
*/

var common = require("./common");
var log = require("./log");

function removeItem(item, array) {
    var index = array.indexOf(item);
    
    if (index !== -1) array.splice(index, 1);
}

function getFactorsWithoutNumber(number) {
    var factors = common.getFactors(number);

    removeItem(number, factors);

    return factors;
}

function getSumOfFactorsLessThanNumber(number) {
    var factors = getFactorsWithoutNumber(number);

    return common.sumArray(factors);
}

module.exports = {
    solveProblem: async function () {
        var number = 220;
        var secondNumber = 284;

        log.info(`For ${number} has factors if ${getFactorsWithoutNumber(number)} | Sum of Factors := ${getSumOfFactorsLessThanNumber(number)}`);
        log.info(`For ${secondNumber} has factors if ${getFactorsWithoutNumber(secondNumber)} | Sum of Factors := ${getSumOfFactorsLessThanNumber(secondNumber)}`);
    }
}