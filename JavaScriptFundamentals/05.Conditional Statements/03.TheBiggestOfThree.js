solve(['5', '2', '2']);
solve(['-2', '-2', '1']);
solve(['-2', '4', '3']);
solve(['0', '-2.5', '5']);
solve(['-0.1', '-0.5', '-1.1']);

function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    if (a >= b && a >= c) { console.log(a); return; }

    if (b >= a && b >= c) { console.log(b); return; }

    if (c >= a && c >= b) { console.log(c); return; }
}