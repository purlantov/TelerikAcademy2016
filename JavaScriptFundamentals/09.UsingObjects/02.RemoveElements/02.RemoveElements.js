solve(['1', '2', '3', '2', '1', '2', '3', '2']);
solve([
    '_h/_',
    '^54F#',
    'V',
    '^54F#',
    'Z285',
    'kv?tc`',
    '^54F#',
    '_h/_',
    'Z285',
    '_h/_',
    'kv?tc`',
    'Z285',
    '^54F#',
    'Z285',
    'Z285',
    '_h/_',
    '^54F#',
    'kv?tc`',
    'kv?tc`',
    'Z285'
]);

// function solve(args) {
//     Array.prototype.remove = function (x) {
//         for (var index = 0; index < this.length; index += 1) {
//             if (this[index] === x) {
//                 this.splice(index, 1);
//             }
//         }
//         return this;
//     };

//     var inputArray = args.remove(args[0]);

//     inputArray.forEach(function(element) {
//         console.log(element);
//     }, this);
// }

function solve(args) {
var result = args.filter(rem);
console.log(result.join('\n'));

    function rem(item, index, args) {
        return item !== args[0];
    }
}