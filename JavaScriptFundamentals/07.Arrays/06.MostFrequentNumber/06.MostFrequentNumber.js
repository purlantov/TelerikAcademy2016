mostfrequent(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);

function mostfrequent(args) {

    var input = args.map(Number),
        n = input[0],
        numbers = input.slice(1),
        current = numbers[0],
        counter = 1,
        bestNum = 0;
    bestCounter = 0;

    numbers.sort();

    for (var i = 0; i < n; i += 1) {

        if (current === numbers[i + 1]) {
            counter++;
        }
        else {
            if (counter > +bestCounter) {
                bestCounter = counter;
                bestNum = numbers[i];
            }
            counter = 1;
        }
        current = numbers[i + 1];
    }
    console.log(bestNum + " (" + bestCounter + " times)");
}