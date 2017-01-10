'use strict';

solve(['5']);
solve(['1']);

function solve(args) {
    var array = [];

    for (var index = 1; index <= args[0]; index++) {
        array += index + ' ';
    }

    console.log(array);
}