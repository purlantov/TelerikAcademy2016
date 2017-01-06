solve(['2', '5', '-3']);
solve(['-1', '3', '0']);
solve(['-0.5', '4', '-8']);
solve(['5', '2', '8']);
solve(['0.2', '9.572', '0.2']);

function solve(args) {
    var x1, x2;
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    x1 = (-b + Math.sqrt(b * b - 4 * a * c)) / (2 * a);
    x2 = (-b - Math.sqrt(b * b - 4 * a * c)) / (2 * a);

    if (x1 === x2) {
        console.log('x1=x2=' + x1.toFixed(2));
        return;
    }

    if (x1 > x2) {
        console.log('x1=' + x2.toFixed(2) + '; ' + 'x2=' + x1.toFixed(2));
    }
    else {
        if (x1.toString() === 'NaN' || x2.toString() === 'NaN') {
            console.log('no real roots'); return;
        }
        console.log('x1=' + x1.toFixed(2) + '; ' + 'x2=' + x2.toFixed(2));
    }
}