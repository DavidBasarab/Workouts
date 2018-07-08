/*
     Problem from Site

    215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

    What is the sum of the digits of the number 21000?

*/

var common = require("./common");

var bigInt = require("big-integer");

module.exports = {
    solveProblem: async function () {
        var two = bigInt(2);

        var poweredNumber =  two.pow(1000);

        var arrayOfPower = poweredNumber.toArray(10);

        console.log(poweredNumber.toString(10));

        console.log(`For Array   2 ^${1000} sum is ${common.sumArray(arrayOfPower.value)}`);
        
    }
}