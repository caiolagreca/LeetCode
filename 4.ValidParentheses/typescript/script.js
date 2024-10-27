/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.

Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

Example 4:
Input: s = "([])"
Output: true

Constraints:
1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
 */
var isValid = function (s) {
    var peers = new Map([
        ["(", ")"],
        ["[", "]"],
        ["{", "}"],
    ]);
    var stack = [];
    // "({})"
    for (var _i = 0, s_1 = s; _i < s_1.length; _i++) {
        var char = s_1[_i];
        //"({}"
        if (peers.has(char)) {
            stack.push(char); //"({"
        }
        else {
            //"}"
            if (stack.length == 0) {
                return false;
            }
            var topStackItem = stack.pop(); //"{"
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
