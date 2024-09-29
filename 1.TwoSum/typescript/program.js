var TwoSum = function (nums, target) {
    for (var i = 0; i < nums.length - 1; i++) {
        for (var j = i + 1; j < nums.length; j++) {
            if (nums[i] + nums[j] === target) {
                return [i, j];
            }
        }
    }
    return null;
};
console.log(TwoSum([3, 2, 4], 6)); // Saída: [1, 2]
console.log(TwoSum([3, 3], 6)); // Saída: [0, 1]
console.log(TwoSum([2, 5, 5, 11], 10)); // Saída: [1, 2]
