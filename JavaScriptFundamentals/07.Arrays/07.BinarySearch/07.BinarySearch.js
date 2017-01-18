solve(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32']);

function solve(args) {
    args = args.map(Number);
    let n = args.shift();
    let needed = args.pop();
    if (needed < args[0] || needed > args[args.length - 1]) {
        return '-1';
    }
    let min = 0;
    let max = args.length - 1;
    let mid;
    while (true) {
        if (min === max && args[min] !== needed) {
            return '-1';
        }
        mid = ((min + max) / 2) | 0;
        if (needed === args[mid]) {
            return mid;
        } else if (needed < +args[mid]) {
            max = mid - 1;
        } else {
            min = mid + 1;
        }
    }
}

// function solve(args) {

//     var arr = args.map(Number),
//         n = +arr[0],
//         x = +arr[arr.length - 1],
//         min = 0,
//         max = n - 1,
//         mid = 0;

//     arr.shift();
//     arr.pop();
//     while (min <= max) {

//         mid = ((min + max) / 2) | 0;

//         if (x === +arr[mid]) {
//             return mid;
//         }
//         else if (x < +arr[mid]) {
//             max = mid - 1;
//         }
//         else {
//             min = mid + 1;
//         }
//     }
//     console.log('-1');
// }