const isValid = (s: string): boolean => {
	const peers = new Map<string, string>([
		["(", ")"],
		["[", "]"],
		["{", "}"],
	]);

	const stack: string[] = [];

	// we use for..of because we want to iterate over each item in the array. for..in is used to iterate over the indices of the array.
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
