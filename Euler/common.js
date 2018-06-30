module.exports = {
    isMultipleOf : function(value, multipleNumber) {
        return value % multipleNumber == 0;
    },
    isEven : function(value) {
        return this.isMultipleOf(value, 2);
    }
}