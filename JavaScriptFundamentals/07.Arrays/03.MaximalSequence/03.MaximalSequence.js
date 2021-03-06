solve(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);// 3
solve(['2', '2', '2', '2', '2', '3', '3', '2', '2', '2', '1']);// 5
solve(['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11']);// 1
solve(['3', '3', '3', '3', '3', '3', '3', '3', '3', '3', '3']);// 11

function solve(args) {
    var inputArray = args.map(Number);
    var arr = [];
    let repeated = 1;

    for (let i = 0; i < inputArray.length - 1; i++) {
        if (inputArray[i] === inputArray[i + 1]) {
            repeated++;
            arr.push(repeated);
        }
        else {
            repeated = 1;
        }
    }

    // To sort Array numerical
    function sortNumber(a, b) {
        return a - b;
    }

    arr.sort(sortNumber);
    
    let result = arr[arr.length - 1] > 1 ? arr[arr.length - 1] : 1;
    
    console.log(result);
}  