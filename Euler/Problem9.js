/*
     Problem from Site

     A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

        a^2 + b^2 = c^2
        For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.
*/

var common = require("./common");

function isPythagoreanTriplet(a, b, c) {
    var aSquared = Math.pow(a, 2);
    var bSquared = Math.pow(b, 2);
    var cSquared = Math.pow(c, 2);

    return (aSquared + bSquared) == cSquared;
}

function isSum1000(a, b, c) {

    //console.log(`Examinging a = ${a} | b = ${b} | c = ${c}`);
    

    return (a + b + c) == 1000;
}

module.exports = {
    solveProblem: function () {

        // 1000 = 1 + 1 + 998;
        // 1000 = 2 + 1 + 997;
        // Look at it from the a < b < c, meaning that 5^2 with c = 5 then, b < 5, and a < b, so we can only test if a = [1, 2, 3] and b = [2, 3. 4] if c == 5

        console.log(`isPythagoreanTriplet(2, 4, 5) == ${isPythagoreanTriplet(2, 4, 5)}`);
        console.log(`isPythagoreanTriplet(3, 4, 5) == ${isPythagoreanTriplet(3, 4, 5)}`);

        var loops = 0;

        for (var c = 1000; c > 2; c--) {

            for(var b = 1000 - c; b > 1; b--) {

                for(var a = 1000 - (b + c); a > 0; a--) {

                    loops++;

                    if(isSum1000(a, b, c)) {

                        if(isPythagoreanTriplet(a, b, c)) {
                            console.log(`${a} + ${b} + ${c} == 1000 and a Pythagorean Triple | Product == ${a * b * c} | Took := ${loops}`);

                            return;
                        }
                    }
                }
            }
        }
    }
}.solveProblem();