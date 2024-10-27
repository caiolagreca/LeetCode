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

const isValid = (s: string): boolean => {
	const peers = new Map<string, string>([
		["(", ")"],
		["[", "]"],
		["{", "}"],
	]);

	const stack: string[] = [];

	//usamos for..of pois queremos iterar sobre cada item do array. O for..in eh usado para iterar sobre os indices do aray.
	for (const char of s) {
		//"({}"
		if (peers.has(char)) {
			stack.push(char); 
		} else {
			if (stack.length == 0) {
				return false;
			}
			const topStackItem = stack.pop();
			if (char != peers.get(topStackItem!)) {
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
