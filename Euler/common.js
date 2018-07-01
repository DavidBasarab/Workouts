var primes = null;

module.exports = {
    isMultipleOf: function (value, multipleNumber) {
        return value % multipleNumber == 0;
    },
    isEven: function (value) {
        return this.isMultipleOf(value, 2);
    },
    isPrime: function (number) {
        for (var i = 2; i < Math.sqrt(number); i++) {
            if (value % i == 0) {
                return false;
            }
        }

        return (number > 1);
    },
    getPrimes: function () {

        if (primes != null) return primes;

        var max = 10000;

        console.log(`Loading all the primes up to ${max}`);

        primes = [];

        var sieve = [], i, j = [];

        for (i = 2; i <= max; ++i) {
            if (!sieve[i]) {

                // i has not been marked -- it is prime
                primes.push(i);

                for (j = i << 1; j <= max; j += i) {
                    sieve[j] = true;
                }
            }
        }
        return primes;
    },
    runOnLoad: function () {
        this.getPrimes();

        return this;
    }
}.runOnLoad();