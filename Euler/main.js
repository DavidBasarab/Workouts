var log = require("./log");

log.info("This is my NodeJs Project Euler Test Runner")

var problemNumber = process.argv[2];

log.info(`Going to run problem ${problemNumber}`);

var timeLabel = `Time for Problem ${problemNumber}`;

var requiredFile = `Problem${problemNumber}.js`;

console.time(timeLabel);

var solver = require(`./${requiredFile}`);

solver.solveProblem().then(function () {
    console.timeEnd(timeLabel);
}).catch(error => {
    log.error(error);
});