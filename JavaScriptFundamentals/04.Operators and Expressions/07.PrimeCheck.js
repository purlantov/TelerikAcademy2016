solve(['2']);
solve(['23']);
solve(['-3']);
solve(['0']);
solve(['1']);
solve(['101']);
solve(['111']);
function solve(args) {
    var number = +args[0];
    var isPrime = true;
    if (number > 1) {
        for (var i = 2; i <= Math.sqrt(number); i += 1) {
            if ((number % i) === 0) {
                isPrime = false;
                break;
            }
        }
        console.log(isPrime);
    }
    else {
        console.log("false");
    }
}
