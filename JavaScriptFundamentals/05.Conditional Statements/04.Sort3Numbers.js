solve(['5', '1', '2']);
solve(['-2', '-2', '1']);
solve(['-2', '4', '3']);
solve(['0', '-2.5', '5']);
solve(['-1.1', '-0.5', '-0.1']);
solve(['10', '20', '30']);
solve(['1', '1', '1']);

function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        biggest = Number.MIN_SAFE_INTEGER,
        middle = Number.MIN_SAFE_INTEGER,
        smallest = Number.MIN_SAFE_INTEGER;

    if (a >= b && a >= c) {
        biggest = a;
        if (b >= c) {
            middle = b;
            smallest = c;
        }
        else {
            middle = c;
            smallest = b;
        }
    }

    if (b >= a && b >= c) {
        biggest = b;
        if (a >= c) {
            middle = a;
            smallest = c;
        }
        else {
            middle = c;
            smallest = a;
        }
    }

    if (c >= a && c >= b) {
        biggest = c;
        if (a >= b) {
            middle = a;
            smallest = b;
        }
        else {
            middle = b;
            smallest = a;
        }
    }

    console.log(biggest + ' ' + middle + ' ' + smallest);

}