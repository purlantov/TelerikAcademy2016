solve(['-2', '0']);
solve(['-1', '2']);
solve(['1.5', '-1']);
solve(['-1.5', '-1.5']);
solve(['100', '-30']);
solve(['0', '0']);
solve(['0.2', '-0.8']);
solve(['0.9', '-1.93']);
solve(['1', '1.655']);
solve(['0', '1']);

function solve(args) {
    var radius = 2;
    var basePointX = 0;
    var basePointY = 0;

    var x = +args[0];
    var y = +args[1];

    var distance = Math.sqrt(Math.pow(x - basePointX, 2) + Math.pow(y - basePointY, 2));
    if (distance > 2) {
        console.log('no ' + distance.toFixed(2));
    }
    else {
        console.log('yes ' + distance.toFixed(2));
    }
}