/*
     Problem from Site

    If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

    If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

    NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) 
          contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*/

var common = require("./common");
var converter = require('number-to-words');

function toWords(number) {
    var words = converter.toWords(number);

    console.log(`Before Change ${words}`);

    return words.replace("hundred", "hundred and");
}

function countLettersForNumber(number) {
    var words = toWords(number);

    var item = words.replace('-', '');

    item = item.replace(/\s/g,'');

    console.log(item);

    return item.length;
}

module.exports = {
    solveProblem: async function () {
        var number = 115;

        console.log(`${number} is ${countLettersForNumber(number)}`);
        
    }
}