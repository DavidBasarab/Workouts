/*
     Problem from Site

    Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

    For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

    What is the total of all the name scores in the file?
*/

var common = require("./common");
var log = require("./log");

const fs = require("fs");
const util = require("util");

// Convert fs.readFile into Promise version of same
const readFile = util.promisify(fs.readFile);

var letterValues = [
    'A',
    'B',
    'C',
    'D',
    'E',
    'F',
    'G',
    'H',
    'I',
    'J',
    'K',
    'L',
    'M',
    'N',
    'O',
    'P',
    'Q',
    'R',
    'S',
    'T',
    'U',
    'V',
    'W',
    'X',
    'Y',
    'Z'
];

async function getData() {
    return await readFile("./Problem22Data.txt");
}

function getLetterValue(letter) {
    var index = letterValues.indexOf(letter);

    return index + 1;
}

function findWordValue(word) {
    var value = 0;

    for (var i = 0; i < word.length; i++) {
        var letterValue = getLetterValue(word[i]);

        value += letterValue;
    }

    return value;
}

module.exports = {
    solveProblem: async function () {
        var data = await getData();

        var list = data.toString().split(",");

        log.info(`The list has ${list.length} items`);

        list.sort();

        for (var i = 0; i < list.length; i++) {
            list[i] = list[i].replace("\"", "");
            list[i] = list[i].replace("\"", "");
        }

        var totalValue = 0;

        for (var i = 0; i < list.length; i++) {
            var wordValue = findWordValue(list[i]);

            var score = wordValue * (i + 1);

            totalValue += score;
        }

        log.magenta(`Total Scores := ${totalValue}`);
    }
}