solve(['hello', 'halo']);
solve(['food', 'food']);
solve(['sls', 'slavejkov']);
solve(['asd', 'dsa']);


function solve(args) {
    var arr1 = args[0];
    var arr2 = args[1];

    let one = CalculateLettersSum(arr1);
    let two = CalculateLettersSum(arr2);

    if (one > two) {
        console.log('>')
    }
    else if(one < two){
        console.log('<');
    }
    else{
        console.log('=');
    }

    function CalculateLettersSum(arr) {
        let sum = 0;
        for (let i = 0; i < arr.length; i++) {
            sum = sum + arr[i].charCodeAt(0);
        }
        return sum;
    }
}