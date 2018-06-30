/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/

var common = require("./common");

process.argv.forEach(function (val, index, array) {
    console.log(index + ': ' + val);
});

var number = process.argv[2];

console.log(`Going to find prime factors of ${number}`);

var primes = common.getPrimes();

primes.forEach(function(element){
    console.log(`Prime := ${element}`);
});