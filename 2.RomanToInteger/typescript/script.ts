const romanToInteger = (s: string): number => {
  const dic: Record<string, number> = {
    I: 1,
    V: 5,
    X: 10,
    L: 50,
    C: 100,
    D: 500,
    M: 1000,
  };

  let total: number = 0;
  let i: number = 0;

  while (i < s.length) {
    const currentChar: string = s[i];
    const currentValue: number = dic[currentChar];

    if (i + 1 < s.length) {
      const nextChar: string = s[i + 1];
      const nextValue: number = dic[nextChar];
      if (nextValue > currentValue) {
        total += nextValue - currentValue;
        i += 2;
      } else {
        total += currentValue;
        i += 1;
      }
    } else {
      total += currentValue;
      i += 1;
    }
  }
  return total;
};

console.log(romanToInteger("MMMCMXCIX"));
//Output = 3999
