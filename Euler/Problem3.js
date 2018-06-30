/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/

var common = require("./common");

var primes = common.getPrimes();

function findPrimesOfANumber(number) {
    var factors = [];

    //console.log(`findPrimesOfANumber := ${number}`);

    if (primes.includes(number)) {
        
        factors.push(number);

        //console.log(`Returning ${factors}`);
        
        return factors;
    }

    for (i = 0; i < primes.length; i++) {
        var currentPrime = primes[i];

        if (number % currentPrime == 0) {
            factors.push(currentPrime);
        }
    }

    var currentFactorsTotal = 1;

    factors.forEach(function (element) {
        currentFactorsTotal *= element;
    });

    //console.log(`currentFactorsTotal := ${currentFactorsTotal}`);

    if (currentFactorsTotal == number) return factors;

    var nextFactors = findPrimesOfANumber(number - currentFactorsTotal);

    //console.log(`NEXT ${nextFactors}`);

    var finalArray = factors.concat(nextFactors);

    //console.log(`FINAL ${finalArray}`);

    return finalArray;
}

process.argv.forEach(function (val, index, array) {
    console.log(index + ': ' + val);
});

var number = process.argv[2];

console.log(`Going to find prime factors of ${number}`);



primes.forEach(function (element) {
    console.log(`Prime := ${element}`);
});

//console.log(`2 := ${findPrimesOfANumber(2)}`);
//console.log(`3 := ${findPrimesOfANumber(3)}`);
//console.log(`4 := ${findPrimesOfANumber(4)}`);
console.log(`12 := ${findPrimesOfANumber(12)}`);
//console.log(`147 := ${findPrimesOfANumber(147)}`);