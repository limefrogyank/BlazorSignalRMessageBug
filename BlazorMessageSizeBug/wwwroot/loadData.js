//function from https://stackoverflow.com/a/2117523/1938624
function uuidv4() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        var r = Math.random() * 16 | 0, v = c === 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
}


function getData(count) {
    var data = [];
    for (var i = 0; i < count; i++) {
        data.push(uuidv4());
    }
    return data;
}