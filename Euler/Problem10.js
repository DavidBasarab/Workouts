/*
     Problem from Site

     The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    Find the sum of all the primes below two million.

*/

var common = require("./common");

module.exports = {
    solveProblem: async function () {
        var maxNumber = 2000000;

        var primes = common.calulatePrimes(maxNumber);

        var sum = common.sumArray(primes);

        console.log(`Primes under ${maxNumber} sums to ${sum}`);

    }
};