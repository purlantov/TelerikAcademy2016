solve(['2.5', '2']);
solve(['0', '1']);
solve(['2.5', '1']);
solve(['1', '2']);

function solve(args) {
    var kX = 1,
        kY = 1,
        kRadius = 1.5,
        rectangleTop = 1,
        rectangleLeft = -1,
        rectangleWidth = 6,
        rectangleHeight = 2;

    var x = args[0],
        y = args[1];
    
    // Distance formula between two pints
    // d=sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1))
    // LINK --> http://www.purplemath.com/modules/distform.htm
    var distance = Math.sqrt(Math.pow(x - kX, 2) + Math.pow(y - kY, 2));

    var isInCircle = distance <= kRadius ? true : false;

    var isInRectange = (rectangleLeft <= x) && (rectangleTop >= y) &&
        (rectangleTop - rectangleHeight <= y) && (rectangleWidth + rectangleLeft >= x);

    isInRectange = isInRectange ? true : false;

    var resultCircle = isInCircle ? 'inside' : 'outside';
    var resultRectange = isInRectange ? 'inside' : 'outside';

    console.log(resultCircle + ' ' + 'circle' + ' ' + resultRectange + ' ' + 'rectangle');
}