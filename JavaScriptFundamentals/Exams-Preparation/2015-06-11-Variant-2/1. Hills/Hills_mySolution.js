solve(['5 1 7 4 8']);// 2
solve(['5 1 7 6 3 6 4 2 3 8']);// 4
solve(['10 1 2 3 4 5 4 3 2 1 10']);// 5
solve(['79096 1629 34868']);// 2

function solve(args) {
    'use strict';
    var peaks = [];

    var arr = args[0].split(' ').map(Number);

    let max = Number.MIN_SAFE_INTEGER;

    // Take first peak
    if (arr[0] > arr[1]) {
        peaks.push(0);
    }

    // Take middle peaks
    for (let i = 1; i < arr.length - 1; i++) {
        if (isBiggerThanNeighbors(i, arr)) {
            peaks.push(i);
        }
    }

    // Take last peak
    if (arr[arr.length - 1] > arr[arr.length - 2]) {
        peaks.push(arr.length - 1);
    }

    for (let i = 0; i < peaks.length - 1; i++) {
        max = Math.max(max, Math.abs(peaks[i] - peaks[i + 1]));
    }
    
    console.log(max);    

    function isBiggerThanNeighbors(index, arr) {
        return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
    }
}