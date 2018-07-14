var colors = require('colors/safe');

module.exports = {
    error: function (message) {
        console.log(colors.red(message));
    },
    info: function (message) {
        console.log(colors.green(message));
    },
    warn: function (message) {
        console.log(colors.yellow(message));
    },
    debug: function (message) {
        console.log(message);
    },
};