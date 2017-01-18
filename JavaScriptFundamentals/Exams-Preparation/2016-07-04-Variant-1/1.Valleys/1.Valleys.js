solve(["5 1 7 4 8"]); // 19
solve(["5 1 7 6 5 6 4 2 3 8"]); //24

function solve(args) {
    let heights = args[0].split(' ').map(Number);
    var peaks = [];
    var sums = [];
    let sum = 0;
    let result;

    if (heights[0] > heights[1]) {
        peaks.push(0);
    }

    for (let i = 1; i < heights.length - 1; i++) {
        if (heights[i] > heights[i + 1] && heights[i] > heights[i - 1]) {
            peaks.push(i);
        }
    }

    if (heights[heights.length - 1] > heights[heights.length - 2]) {
        peaks.push(heights.length - 1);
    }

    for (let i = 0; i < peaks.length - 1; i++) {
        for (let j = peaks[i]; j <= peaks[i + 1]; j++) {
            sum +=heights[j];
            i=j;
        }
        sums.push(sum);
    }

    console.log(sums);
}