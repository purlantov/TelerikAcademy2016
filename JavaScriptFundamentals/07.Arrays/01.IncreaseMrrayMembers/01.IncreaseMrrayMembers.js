solve(['5']);

function solve(args) {
    let n = args[0];
    let incerment = 5;
    var array = [];

    for (let i = 0; i < n; i++) {
        array.push(i * incerment);
    }

    for (let i = 0; i < array.length; i += 1)
        console.log(array[i]);
}