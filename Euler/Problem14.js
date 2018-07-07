/*
     Problem from Site

    The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.

*/

var common = require("./common");
const _progress = require('cli-progress');
var colors = require('colors/safe');

function evenRule(number) {
    return number / 2;
}

function oddRule(number) {
    return (3 * number) + 1;
}

function processChain(startingNumber) {
    var chain = [];

    chain.push(startingNumber);

    var currentNumber = startingNumber;

    while (currentNumber != 1) {
        var nextNumber = nextInChain(currentNumber);

        chain.push(nextNumber);

        currentNumber = nextNumber;
    }

    return chain;
}

function nextInChain(number) {
    if (number % 2 == 0) return evenRule(number);

    return oddRule(number);
}

var oneMillion = 1000000;

module.exports = {
    solveProblem: async function () {

        var progressBar = new _progress.Bar({
            barsize: 65
        }, _progress.Presets.shades_grey);

        progressBar.start(oneMillion, 0);

        var maxChainLength = 1;
        var maxChainNumber = 2;

        for (var i = 2; i < oneMillion; i++) {
            var chain = processChain(i);

            if (chain.length > maxChainLength) {
                maxChainLength = chain.length;
                maxChainNumber = i;
            }

            progressBar.update(i);
        }

        progressBar.stop();

        console.log(colors.green(`${maxChainNumber} has the largest chain of ${maxChainLength}`));
    }
}