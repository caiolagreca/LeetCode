const TwoSum = (nums: number[], target: number): number[] | null => {
  for (let i = 0; i < nums.length - 1; i++) {
    for (let j = i + 1; j < nums.length; j++) {
      if (nums[i] + nums[j] === target) {
        return [i, j];
      }
    }
  }

  return null;
};

console.log(TwoSum([3, 2, 4], 6)); // [1, 2]
console.log(TwoSum([3, 3], 6)); // [0, 1]
console.log(TwoSum([2, 5, 5, 11], 10)); // [1, 2]
