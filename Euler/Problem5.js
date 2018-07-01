/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

var common = require("./common");

module.exports = {
    solveProblem : async function() {
        function findMaxThatCanBeEvenlyDivided(maxNumber) {
            var currentNumber = maxNumber;
        
            while(true) {
                var allMatch = true;
                for(var n = 3; n < maxNumber; n++) {
                    if(currentNumber % n != 0) {
                        allMatch = false;
                        break;
                    }
                }
        
                if(allMatch) return currentNumber;
        
                currentNumber += maxNumber;
            }
        }
        
        var stoppingNumber = 20;
        
        var smallest = findMaxThatCanBeEvenlyDivided(20);
        
        console.log(`Smallest number that can deviced 1 to ${stoppingNumber} is ${smallest}`);
    }
};