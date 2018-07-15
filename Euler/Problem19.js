/*
    Problem from Site

    You are given the following information, but you may prefer to do some research for yourself.

    ->  1 Jan 1900 was a Monday.
    ->  Thirty days has September,
        April, June and November.
        All the rest have thirty-one,
        Saving February alone,
        Which has twenty-eight, rain or shine.
        And on leap years, twenty-nine.
    ->  A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

    How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
*/

var common = require("./common");
var log = require("./log");

module.exports = {
    solveProblem: async function () {
        var jan1st1901 = new Date('01/01/1901');

        log.info(`First Date := ${jan1st1901.getFullYear()} | ${jan1st1901.getDay()}`);

        var numberOfSundays = 0;

        for (var year = 1901; year <= 2000; year++) {
            for (var month = 1; month <= 12; month++) {
                var currentDate = new Date(`${month}/01/${year}`);

                if (currentDate.getDay() == 0) {
                    numberOfSundays++;
                }
            }
        }

        log.magenta(`Number of Sundays := ${numberOfSundays}`);
    }
}