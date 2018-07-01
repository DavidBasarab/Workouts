/*
     Problem from Site

     By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    What is the 10 001st prime number?
*/

var common = require("./common");

module.exports = {
    solveProblem: async function () {
        var primes = common.calulatePrimes(110000);

        console.log(`Prime Length := ${primes.length}`);

        var tenThousandAndOnePrime = primes[10000];

        console.log(`lastItem ${tenThousandAndOnePrime}`);
    }
};