var getPrefix = function (list) {
    if (list == null || list.length == 0) {
        return "";
    }
    var prefix = list[0];
    for (var i = 1; i < list.length; i++) {
        while (list[i].indexOf(prefix) != 0) {
            prefix = prefix.substring(0, prefix.length - 1);
            if (prefix == "") {
                return "";
            }
        }
    }
    return prefix;
};
var result = getPrefix(["flower", "fow", "flight"]);
console.log("the prefix is: ".concat(result));
