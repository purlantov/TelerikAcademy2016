solve(['5']);
solve(['701']);
solve(['9703']);
solve(['877']);
solve(['777877']);
solve(['9999799']);

function solve(args) {
    var number = args[0];

    var digit = (number / Math.pow(10, 3 - 1)) % 10;

    digit = Math.floor(digit);

    if (digit == 7) {
        console.log(true);
    }
    else {
        console.log(false + " " + digit);
    }
}