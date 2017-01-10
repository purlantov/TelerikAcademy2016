solve(['2', '5', '1']);
solve(['2', '-1', '4']);
solve(['1', '2', '3', '4', '5', '6', '7', '8', '9', '10']);

function solve(params) {
    var min = -Number.MAX_VALUE,
        max = Number.MIN_VALUE,
        sum = 0,
        avg = Number.MIN_VALUE;

    params.sort();

    min = parseFloat(params[0]);
    max = parseFloat(params[params.length - 1]);

    for (var i = 0; i < params.length; i++) {
        sum += parseFloat(params[i]);
    }

    avg = sum / params.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
    //console.log();
}