solve(['15']);
solve(['1024']);
solve(['4']);
solve(['7']);

function solve(args) {
    var number = args[0];
    number = number >> 3;
    var mask = 1;
    var result = number & mask;
    console.log(result);
}