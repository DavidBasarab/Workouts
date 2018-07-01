/*
     Problem from Site

     A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

        a^2 + b^2 = c^2
        For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.
*/

var common = require("./common");

module.exports = {
    solveProblem: function () {
        console.log("Go and get some sleep");

        // 1000 = 1 + 1 + 998;
        // 1000 = 2 + 1 + 997;
        // Look at it from the a < b < c, meaning that 5^2 with c = 5 then, b < 5, and a < b, so we can only test if a = [1, 2, 3] and b = [2, 3. 4] if c == 5
    }
}.solveProblem();