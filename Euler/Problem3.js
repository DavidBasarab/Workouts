/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/

var common = require("./common");

var primes = common.getPrimes();

function findPrimesOfANumber(number) {
    var factors = [];

    if (primes.includes(number)) {
        
        factors.push(number);
        
        return factors;
    }

    for (i = 0; i < primes.length; i++) {
        var currentPrime = primes[i];

        if (number % currentPrime == 0) {
            factors.push(currentPrime);

            factors = factors.concat(findPrimesOfANumber(number / currentPrime));

            break;
        }
    }

    return factors;
}

process.argv.forEach(function (val, index, array) {
    console.log(index + ': ' + val);
});

var number = process.argv[2];

console.log(`Going to find prime factors of ${number}`);

console.log(`2 := ${findPrimesOfANumber(2)}`);
console.log(`3 := ${findPrimesOfANumber(3)}`);
console.log(`4 := ${findPrimesOfANumber(4)}`);
console.log(`12 := ${findPrimesOfANumber(12)}`);
console.log(`147 := ${findPrimesOfANumber(147)}`);

var finalProblem = findPrimesOfANumber(number);
var total = 1;

finalProblem.forEach(function(element){
    total *= element;
});




console.log(`${number} := ${finalProblem} | total := ${total}`);