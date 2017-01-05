solve(['0']);
solve(['9']);
solve(['10']);
solve(['12']);
solve(['19']);
//solve(['25']);
//solve(['98']);
// solve(['273']);
// solve(['400']);
// solve(['501']);
// solve(['617']);
// solve(['711']);
// solve(['999']);

function solve(args) {
    var number = args[0];
    console.log(numberAsWord(number));
}

function numberAsWord(number) {
    if (number > 99) {
        return hundreds(number);
    } else if (number > 9) {
        return tenths(number);
    } else {
        return digitAsWord(number);
    }
}

function tenths(number) {
    var tenth = "";
    var num = +number;
    // if (num[num.Length - 2] === '1') {
    //     tens += digitAsWord(num[num.Length - 2] + "" + num[num.Length - 1]);
    // } else {
    //     tens += digitAsWord(num[num.Length - 2] + "") * 10;
    //     if (number % 10 != 0) {
    //         tens += "-" + digitAsWord(num[num.Length - 1] + "");
    //     }
    // }

    
    if (num > 9 && num < 20) {
        console.log(digitAsWord(num));
    }
    //num = Math.floor(num / 10);
    console.log(num);
    //console.log( digitAsWord(num));
    //return tenth;
}

function hundreds(number) {
    var hundred = digitAsWord((number / 100) % 10) + " hundred";

    if (((number / 10) % 10) != 0 || (number % 10) != 0) {
        hundred += " and ";
        if ((number / 10) % 10 > 0) {
            hundred += tenths(number - (100 * ((number / 100) % 10)));
        } else {
            hundred += digitAsWord(number % 10);
        }
    }

    return hundred;
}

function digitAsWord(p) {
    var result;
    switch (+p) {
        case 0: result = "zero";
        case 1: result = "one";
        case 2: result = "two";
        case 3: result = "three";
        case 4: result = "four";
        case 5: result = "five";
        case 6: result = "six";
        case 7: result = "seven";
        case 8: result = "eight";
        case 9: result = "nine";
        case 10: result = "ten";
        case 11: result = "eleven";
        case 12: result = "twelve";
        case 13: result = "thirteen";
        case 14: result = "fourteen";
        case 15: result = "fifteen";
        case 16: result = "sixteen";
        case 17: result = "seventeen";
        case 18: result = "eighteen";
        case 19: result = "nineteen";
        case 20: result = "twenty";
        case 30: result = "thirty";
        case 40: result = "forty";
        case 50: result = "fifty";
        case 60: result = "sixty";
        case 70: result = "seventy";
        case 80: result = "eight";
        case 90: result = "ninety";
        default: result = "Invalid";
    }

    return result;
}