/*
     Problem from Site

By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

3
7 4
2 4 6
8 5 9 3

That is, 3 + 7 + 4 + 9 = 23.

Find the maximum total from top to bottom of the triangle below:

75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23

NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route. However, Problem 67, is the same challenge with a triangle containing one-hundred rows; it cannot be solved by brute force, and requires a clever method! ;o)

*/

var common = require("./common");
var Node = require("./treeNodeModule");

const fs = require('fs');
const util = require('util');

// Convert fs.readFile into Promise version of same    
const readFile = util.promisify(fs.readFile);

async function getData() {
    return await readFile("./Problem18Data.txt");
}

module.exports = {
    solveProblem: async function () {
        /*
            TODO

            1) Need to create a tree from given data
            2) Traverse the tree only taking the "greater nodes"
            3) Sum the values of the nodes
        */

        var data = await getData();

        var lines = data.toString().split("\n");

        var dataArray = [];

        for (var i = 0; i < lines.length; i++) {
            dataArray.push(lines[i].trim().split(' '));
        }

        // dataArray.forEach((element, index) => {
        //     console.log(`[${index}] := ${element}`);
        // });

        function addChildren(node, row, column) {

            console.log(`addingChildren to node row := ${row} | column := ${column}`);

            var nextRow = row + 1;

            if (nextRow >= dataArray.length) return;

            var nextRowData = dataArray[nextRow];

            node.addLeft(nextRowData[column]);
            node.addRight(nextRowData[column + 1]);

            addChildren(node.left, row + 1, column);
            addChildren(node.right, row + 1, column + 1);
        }

        var topNode = new Node(dataArray[0][0]);

        addChildren(topNode, 0, 0);

        console.log(`${JSON.stringify(topNode, null, '    ')}`);
    }
}