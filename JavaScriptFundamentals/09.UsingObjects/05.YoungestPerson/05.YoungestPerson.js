solve([
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
]);

solve([
    'Penka', 'Hristova', '61',
    'System', 'Failiure', '88',
    'Bat', 'Man', '16',
    'Malko', 'Kote', '72'
]);

function solve(args) {
    var persons = [];

    for (let i = 0; i < args.length; i += 3) {
        persons.push({
            firstname: args[i],
            lastname: args[i + 1],
            age: +args[i + 2]
        });
    }

    function findYoungest() {
        var youngest = persons[0];
        for (let i in persons) {
            if (youngest.age > persons[i].age) {
                youngest = persons[i];
            }
        }
        return youngest.firstname + ' ' + youngest.lastname;
    }
    console.log(findYoungest());
}