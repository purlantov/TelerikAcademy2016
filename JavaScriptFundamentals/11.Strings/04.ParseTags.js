function solve(args) {
    let str = args[0];

    let upcase = (string) => {
        return string.replace(/<upcase>(.*?)<\/upcase>/ig, (a, b) => {
            return b.toUpperCase();
        });
    };

    let lowcase = (string) => {
        return string.replace(/<lowcase>(.*?)<\/lowcase>/ig, (a, b) => {
            return b.toLowerCase();
        });
    };

    let orgcase = (string) => {
        return string.replace(/<orgcase>(.*?)<\/orgcase>/ig, (a, b) => {
            return b;
        });
    };

    let parsers = [upcase, lowcase, orgcase];

    let parseTags = (string) => {
        for (const parser of parsers) {
            string = parser(string);
        }

        return string;
    }

    
    str = parseTags(str);
    console.log(str);
}

// start 
text = ['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.'];
// We are liViNg in a YELLOW SUBMARINE. We doN't have anything else.

solve(text);


// New solution
// 100/100
function solve(args) {
    let text = args[0],
        inTag = false,
        currentTag = '',
        tags = [],
        result = [];

    for (var i = 0; i < text.length; i++) {
        if (text[i] === '<') {
            inTag = true;
        } else if (text[i] === '>' && inTag) {
            inTag = false;
            currentTag += text[i];
            tags.push(currentTag);
            currentTag = '';
        } else if (!inTag) {
            if (tags.length === 0) {
                result.push(text[i]);
            } else if (tags[tags.length - 1].indexOf('upcase') !== -1) {
                result.push(text[i].toUpperCase());
            } else if (tags[tags.length - 1].indexOf('lowcase') !== -1) {
                result.push(text[i].toLowerCase());
            } else {
                result.push(text[i]);
            }
        }

        if (inTag || text[i] === '>') {
            currentTag += text[i];
        }

        if (tags.length !== 0 && tags[tags.length - 1].indexOf('</') !== -1) {
            tags.pop();
            tags.pop();
        }
    }

    console.log(result.join(''));
    //console.log(tags);
}