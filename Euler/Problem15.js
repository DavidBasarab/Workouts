/*
     Problem from Site
    
    Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
    there are exactly 6 routes to the bottom right corner.


    How many such routes are there through a 20×20 grid?

    -----------------------------------------------------------------------------------------------------

    https://www.robertdickau.com/manhattan.html

    Here are some diagrams that represent the possible paths of length 2n from one corner of an n-by-n grid to the opposite corner. The number of paths are the central binomial coefficients

    Binomial[2n, n] or  (2n)!/(n!)^2,

    central meaning they fall along the center line of Pascal’s triangle.
*/

var common = require("./common");

module.exports = {
    solveProblem: async function () {
        var number = 20;

        var top = common.factorial(2 * number);

        var bottom = Math.pow(common.factorial(number), 2);

        var paths = top / bottom;

        console.log(`For Grid size of ${number} there are ${paths} paths.`);
    }
}

