numToWord(['0']);
numToWord(['9']);
numToWord(['10']);
numToWord(['12']);
numToWord(['19']);
numToWord(['25']);
numToWord(['98']);
numToWord(['273']);
numToWord(['400']);
numToWord(['501']);
numToWord(['617']);
numToWord(['711']);
numToWord(['999']);

function numToWord(args) {
	var number = args[0];
	var digits = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
	var special = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixtheen", "seventeen", "eighteen", "nineteen"];
	var dec = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];

	if (number >= 0 && number < 1000) {
		var digit = number % 10;
		var tens = parseInt(number / 10) % 10;
		var hundred = parseInt(number / 100) % 10;
		var result='';

		if (hundred !== 0) {
			result += (digits[hundred] + " hundred ");

			if (tens !== 0 && tens !== 1 && number >= 20) {

				result += ("and " + dec[tens] + " ");

				if (digit != 0) {
					result += (digits[digit] + " ");
				}
			}
			else if (tens === 1) {
				result += ("and " + special[digit]);
			}
			else {
				if (digit !== 0) {
					result += ("and " + digits[digit] + " ");
				}
			}
		}
		else {
			// hundreds = 0
			if (tens !== 0 && tens !== 1 && number >= 20) {
				result +=(dec[tens] + " ");
				if (digit !== 0) {
					result +=(digits[digit] + " ");
				}

			}
			else if (tens === 1) {
				result +=(special[digit]);
			}
			else {
				result +=(digits[digit] + " ");
			}
		}

		//console.log(result);
		var firstLetter = result[0].toLocaleUpperCase();
		var res = result.substr(1,result.length);
		console.log(firstLetter + res);
	}
}