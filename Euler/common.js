var primes = null;



module.exports = {
    isMultipleOf: function (value, multipleNumber) {
        return value % multipleNumber == 0;
    },
    factorial : function(number) {
        if(number === 0) return 1;

        return number * this.factorial(number -1);
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

        primes = this.calulatePrimes(max);

        return primes;
    },
    isSquare: function (n) {
        return n > 0 && Math.sqrt(n) % 1 === 0;
    },
    sumArray: function (array) {
        var sum = 0;

        for (var i = 0; i < array.length; i++) {
            sum += array[i];
        }

        return sum;
    },
    productOfArray: function (array) {
        var product = 1;

        array.forEach(value => product *= value);

        return product;
    },
    calulatePrimes: function (max) {

        console.log(`Calculating all the primes up to ${max}`);

        var primeArray = [];
        var sieve = [], i, j = [];

        for (i = 2; i <= max; ++i) {
            if (!sieve[i]) {

                // i has not been marked -- it is prime
                primeArray.push(i);

                for (j = i << 1; j <= max; j += i) {
                    sieve[j] = true;
                }
            }
        }
        return primeArray;
    },
    getPrimeFactors: function (number) {
        var factors = [];

        if (primes.includes(number)) {

            factors.push(number);

            return factors;
        }

        for (i = 0; i < primes.length; i++) {
            var currentPrime = primes[i];

            if (number % currentPrime == 0) {
                factors.push(currentPrime);

                factors = factors.concat(this.getPrimeFactors(number / currentPrime));

                break;
            }
        }

        return factors;
    },
    getFactors: function (number) {
        var primeFactors = this.getPrimeFactors(number).sort((a, b) => a - b);

        var factors = this.getArrayProductCombinations(primeFactors);

        factors.push(1);

        factors.sort((a, b) => a - b);

        return factors;
    },
    runOnLoad: function () {
        this.getPrimes();

        return this;
    },
    getArrayProductCombinations : function(array) {
        var result = [];
    
        var internalCombiner = function (prefix, current, productOfArray) {
            for (var i = 0; i < current.length; i++) {
                var tempArray = prefix.concat(current[i]);
    
                var product = productOfArray(tempArray);
    
                if (!result.includes(product)) result.push(product);
    
                internalCombiner(prefix.concat(current[i]), current.slice(i + 1), productOfArray);
            }
        }
    
        internalCombiner([], array, this.productOfArray);
    
        return result;
    }
}.runOnLoad();