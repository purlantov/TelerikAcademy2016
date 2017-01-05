solve(['5', '2']);
solve(['3', '4']);
solve(['5.5', '4.5']);

function solve(args) {
    var a = +args[0],
        b = +args[1];

    if (a < b) {
        console.log(a + ' ' + b);
    }
    else {
        console.log(b + ' ' + a);
    }
}