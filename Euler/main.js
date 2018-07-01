console.log("This is my NodeJs Project Euler Test Runner");

var problemNumber = process.argv[2];

console.log(`Going to run problem ${problemNumber}`);

var requiredFile = `Problem${problemNumber}.js`;

console.time('problemTime');

require(`./${requiredFile}`);

console.timeEnd('problemTime');