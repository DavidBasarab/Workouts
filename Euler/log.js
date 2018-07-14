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
    red: function (message) {
        console.log(colors.red(message));
    },
    green: function (message) {
        console.log(colors.green(message));
    },
    yellow: function (message) {
        console.log(colors.yellow(message));
    },
    blue: function (message) {
        console.log(colors.blue(message));
    },
    magenta: function (message) {
        console.log(colors.magenta(message));
    },
    cyan: function (message) {
        console.log(colors.cyan(message));
    },
    white: function (message) {
        console.log(colors.white(message));
    },
    gray: function (message) {
        console.log(colors.gray(message));
    },
    bgRed: function (message) {
        console.log(colors.bgRed(message));
    },
    bgGreen: function (message) {
        console.log(colors.bgGreen(message));
    },
    bgYellow: function (message) {
        console.log(colors.bgYellow(message));
    },
    bgBlue: function (message) {
        console.log(colors.bgBlue(message));
    },
    bgMagenta: function (message) {
        console.log(colors.bgMagenta(message));
    },
    bgCyan: function (message) {
        console.log(colors.bgCyan(message));
    },
    bgWhite: function (message) {
        console.log(colors.bgWhite(message));
    }
};