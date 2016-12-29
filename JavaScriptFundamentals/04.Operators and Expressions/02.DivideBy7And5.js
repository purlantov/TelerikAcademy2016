//solve(['5']);

function solve(args) {
    var temp = +args[0];
    if (temp % 7 == 0 && temp % 5 == 0) {
        console.log('true' + ' ' + temp);
    }
    else {
        console.log('false ' + temp.toString());
    }
}