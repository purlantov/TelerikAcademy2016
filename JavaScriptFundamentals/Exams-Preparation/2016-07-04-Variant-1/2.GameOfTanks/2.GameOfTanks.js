solve(
    [
        '5 5',
        '2 0;2 1;2 2;2 3;2 4',
        '13',
        'mv 7 2 l',
        'x 7 u',
        'x 0 d',
        'x 6 u',
        'x 5 u',
        'x 2 d',
        'x 3 d',
        'mv 4 1 u',
        'mv 4 4 l',
        'mv 1 1 l',
        'x 4 u',
        'mv 4 2 r',
        'x 2 d'
    ]);

solve(
    [
        '10 10',
        '1 0;1 1;1 2;1 3;1 4;4 1;4 2;4 3;4 4',
        '8',
        'mv 4 9 u',
        'x 4 l',
        'x 4 l',
        'x 4 l',
        'x 0 r',
        'mv 0 9 r',
        'mv 5 1 r',
        'x 5 u'
    ]);

function solve(args) {
    let EMPTY = -1;
    let DEBRIS = 'x';
    var RC = args[0].split(' ').map(Number),
        rows = RC[0],
        cols = RC[1],
        field = new Array(rows);
    field.fill(0);

    for (let i in field) {
        field[i] = new Array(cols);
        field[i].fill(-1);
    }

    //let debris = args[1].split(';').map(pair => pair.split(' ').map(Number)),
    let debris = args[1].split(';').forEach(function (coord) {
        const arr = coord.split(' ').map(Number);
        const x = arr[0];
        const y = arr[1];
        field[x][y] = DEBRIS;
    });

    let tankPosition = [
        { row: 0, col: 0 }, // tank 0
        { row: 0, col: 1 }, // tank 1
        { row: 0, col: 2 }, // tank 2
        { row: 0, col: 3 }, // tank 3
        { row: rows - 1, col: cols - 1 }, // tank 4
        { row: rows - 1, col: cols - 2 }, // tank 5
        { row: rows - 1, col: cols - 3 }, // tank 6
        { row: rows - 1, col: cols - 4 } // tank 7
    ];

    // tanks position lame way
    //field[0][0] = 0; field[0][1] = 1; field[0][2] = 2; field[0][3] = 3;
    //field[rows - 1][cols - 1] = 4; field[rows - 1][cols - 2] = 5; field[rows - 1][cols - 3] = 6; field[rows - 1][col - 4] = 7;

    let playerTanks = [4, 4];

    for (var i in tankPosition) {
        field[tankPosition[i].row][tankPosition[i].col] = i;
    }

    let n = +args[2];

    //console.log(field);

    for (let i = 3; i < n + 3; i += 1) {
        let commandsSplit = args[i].split(' ');

        if (commandsSplit[0] === 'mv') {
            moveTank(+commandsSplit[1], +commandsSplit[2], commandsSplit[3]);
        }
        else if (commandsSplit[0] === 'x') {
            shootWithTank(+commandsSplit[1], commandsSplit[2]);
        }

    }

    function moveTank(id, n, dir) {
        let deltaRow = 0,
            deltaCol = 0;

        if (dir === 'u') {
            deltaRow = -1;
        }
        else if (dir === 'd') {
            deltaRow = +1;
        }
        else if (dir === 'l') {
            deltaCol = -1;
        }
        else if (dir === 'd') {
            deltaCol = +1;
        }
        else {
            // Nothing to do 
        }

        let tankRow = tankPosition[id].row;
        let tankCol = tankPosition[id].col;

        field[tankRow][tankCol] = EMPTY;

        while (n > 0) {
            const newPosRow = tankRow + deltaRow;
            const newPosCol = tankCol + deltaCol;

            if (newPosRow < 0 || newPosRow >= rows) {
                break;
            }
            if (newPosCol < 0 || newPosCol >= cols) {
                break;
            }
            if (field[newPosRow][newPosCol] !== EMPTY) {
                break;
            }

            tankRow = newPosRow;
            tankCol = newPosCol;

            n -= 1;
        }

        tankPosition[id].row = tankRow;
        tankPosition[id].col = tankCol;

        field[tankRow][tankCol] = id;
    }

    var deltas = [
        { u: [-1, 0] }, // row, col
        { d: [1, 0] },
        { r: [0, 1] },
        { l: [0, -1] }
    ];

    function shootWithTank(id, dir) {
        let deltaRow = 0,
            deltaCol = 0;

        if (dir === 'u') {
            deltaRow = -1;
        }
        else if (dir === 'd') {
            deltaRow = +1;
        }
        else if (dir === 'l') {
            deltaCol = -1;
        }
        else if (dir === 'd') {
            deltaCol = +1;
        }
        else {
            // Nothing to do 
        }

        let shootRow = tankPosition[id].row; // first step is important
        let shootCol = tankPosition[id].col;

        while ((0 <= shootRow && shootRow < rows) && (0 <= shootCol && shootCol < cols)) {
            if (field[shootRow][shootCol] === EMPTY) {
                shootRow += deltaRow;
                shootCol += deltaCol;
            }
            else if (field[shootRow][shootCol] === DEBRIS) {
                field[shootRow][shootCol] = EMPTY;
                break;
                // no console.log here
            }
            else {
                const deadTankId = field[shootRow][shootCol];
                field[shootRow][shootCol] = EMPTY;
                console.log(`Tank ${deadTankId} is gg`);
                const playerID = deadTankId < 4 ? 0 : 1;
                playerTanks[playerID] -= 1;

                if (playerTanks[playerID] === 0) {
                    const loserName = ['Koceto', 'Cuki'][playerID];
                    console.log(`Tank ${loserName} is gg`);

                }
                break;
            }
        }

    }
}