var common = require("./common");

module.exports = {
    solveProblem : function() {
        function isMultipleOf5(value) {
            return common.isMultipleOf(value, 5);
        }
        
        function isMultipleOf3(value) {
            return common.isMultipleOf(value, 3);
        }
        
        console.log("This is going to be Problem 1");
        
        var sum = 0;
        var stoppingNumber = 1000;
        
        for(var i = 0; i < stoppingNumber; i++) {
            if(isMultipleOf3(i) || isMultipleOf5(i)) {
                sum += i;
            }
        }
        
        console.log(`Sum to ${stoppingNumber} is ${sum}`);
    }
}.solveProblem();