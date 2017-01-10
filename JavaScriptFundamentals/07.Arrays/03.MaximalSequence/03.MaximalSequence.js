solve(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);

function solve(args) {
    var inputArray = args.map(Number);
    var arr = [];
    let repeated = 0;

    for (let i = 0; i < inputArray.length - 1; i += 1) {
        if (inuptArray[i] === inputArray[i + 1]) {
            arr.push(inputArray[i]);
        }
    }
}