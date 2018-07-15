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
    if (number === 0) return 0;

    var factors = common.getFactors(number);

    removeItem(number, factors);

    return factors;
}

function getSumOfFactorsLessThanNumber(number) {
    var factors = getFactorsWithoutNumber(number);

    return common.sumArray(factors);
}

var factorSums = [];

module.exports = {
    solveProblem: async function () {

        log.debug(`Creating factor Sum Array`);

        for (var i = 0; i < 10000; i++) {
            var sumOfFactors = getSumOfFactorsLessThanNumber(i);

            factorSums.push(sumOfFactors);
        }

        log.debug(`Done creating factor sum array | factorSum.length := ${factorSums.length}`);

        log.debug(`factorSums[220] := ${factorSums[220]} | factorSums := ${factorSums[284]}`);

        var amicableNumbers = [];

        for (var i = 1; i < factorSums.length; i++) {
            var currentSum = factorSums[i];

            if (currentSum === 0 || currentSum === 1) continue;

            //log.cyan(`${i} sum := ${currentSum}`);

            var indexOfOther = factorSums.indexOf(currentSum);

            if (indexOfOther != -1) {

                var otherSum = factorSums[indexOfOther];

                if (i !== indexOfOther) {

                    log.cyan(`${i} sum := ${currentSum} | IndexOfOther := ${indexOfOther} | SumOfOther := ${otherSum}`);

                    if (!amicableNumbers.includes(i)) {
                        amicableNumbers.push(i);
                    }

                    if (!amicableNumbers.includes(indexOfOther)) {
                        amicableNumbers.push(indexOfOther);
                    }
                }
            }
        }

        log.magenta(`Sum of Amicable Numbers := ${common.sumArray(amicableNumbers)} | Amicable Count := ${amicableNumbers.length}`);
    }
}