solve(['2', '5', '1']);
solve(['2', '-1', '4']);
solve(['1', '2', '3', '4', '5', '6', '7', '8', '9', '10']);

function solve(args){
    var array = args.map(Number),
        min = Math.min(array),
        max = Math.max(array),
        sum = 0,
        avg = 0;

    for (var i = 0; i < args.length; i+=1){
        sum+= +args[i];
    }
    avg = sum / args.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}