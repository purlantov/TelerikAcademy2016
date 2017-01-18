selectionSort(['6', '3', '4', '1', '5', '2', '6']);
selectionSort(['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']);

function selectionSort(items) {

    let len = items.length,
        min, i, j;

    for (i = 0; i < len; i++) {

        //set minimum to this position
        min = i;

        //check the rest of the array to see if anything is smaller
        for (j = i + 1; j < len; j += 1) {
            if (items[j] < items[min]) {
                min = j;
            }
        }

        //if the minimum isn't in the position, swap it
        if (i != min) {
            swap(items, i, min);
        }
    }

    var array = [];

    for (let index = 0; index < items.length-1; index += 1) {
        if (items[index] !== items[index + 1]) {
            array.push(items[index]);
        }
    }
    array.push(items[items.length-1]);

    //console.log(items);

    array.forEach(function (element) {
        console.log(element);
    });

    function swap(items, firstIndex, secondIndex) {
        var temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;
    }
}