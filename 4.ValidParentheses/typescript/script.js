var isValid = function (s) {
    var peers = new Map([
        ["(", ")"],
        ["[", "]"],
        ["{", "}"],
    ]);
    var stack = [];
    // we use for..of because we want to iterate over each item in the array. for..in is used to iterate over the indices of the array.
    for (var _i = 0, s_1 = s; _i < s_1.length; _i++) {
        var char = s_1[_i];
        //"({}"
        if (peers.has(char)) {
            stack.push(char);
        }
        else {
            if (stack.length == 0) {
                return false;
            }
            var topStackItem = stack.pop();
            if (char != peers.get(topStackItem)) {
                return false;
            }
        }
    }
    return stack.length == 0;
};
console.log(isValid("([])"));
console.log(isValid("([]){}"));
console.log(isValid("([({})])"));
console.log(isValid("([]{}"));
