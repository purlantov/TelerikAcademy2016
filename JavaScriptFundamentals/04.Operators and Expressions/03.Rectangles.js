var args = ['2.5', '3'];
solve(args);

function solve(args) {
    var width = args[0];
    var height = args[1];
    var perimeter = width * 2 + height * 2;
    var area = width * height;
    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}