/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/

var common = require("./common");

module.exports = {
    solveProblem: function () {
        process.argv.forEach(function (val, index, array) {
            console.log(index + ': ' + val);
        });

        var number = process.argv[3];

        console.log(`Going to find prime factors of ${number}`);

        console.log(`2 := ${common.getPrimeFactors(2)}`);
        console.log(`3 := ${common.getPrimeFactors(3)}`);
        console.log(`4 := ${common.getPrimeFactors(4)}`);
        console.log(`12 := ${common.getPrimeFactors(12)}`);
        console.log(`147 := ${common.getPrimeFactors(147)}`);

        var finalProblem = common.getPrimeFactors(number);
        var total = 1;

        finalProblem.forEach(function (element) {
            total *= element;
        });

        console.log(`${number} := ${finalProblem} | total := ${total}`);
    }
}.solveProblem();