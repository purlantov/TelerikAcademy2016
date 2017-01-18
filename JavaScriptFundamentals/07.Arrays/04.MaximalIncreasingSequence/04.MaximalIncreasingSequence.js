solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);
solve(['1', '2', '3', '4', '5', '6', '2', '2', '4']);


function solve(args) {
    var inputArray = args.map(Number);
    var arr = [];
    let repeated = 1;

    for (let i = 0; i < inputArray.length - 1; i++) {
        if (inputArray[i] < inputArray[i + 1]) {
            repeated++;
            arr.push(repeated);

        }
        else {
            repeated = 1;
        }
    }

    function sortNumber(a, b) {
        return a - b;
    }

    arr.sort(sortNumber);
    //console.log(arr);
    let result = arr[arr.length - 1] > 1 ? arr[arr.length - 1] : 1;
    console.log(result);
}