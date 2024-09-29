var romanToInteger = function (s) {
    var dic = {
        I: 1,
        V: 5,
        X: 10,
        L: 50,
        C: 100,
        D: 500,
        M: 1000,
    };
    var total = 0;
    var i = 0;
    while (i < s.length) {
        var currentChar = s[i];
        var currentValue = dic[currentChar];
        if (i + 1 < s.length) {
            var nextChar = s[i + 1];
            var nextValue = dic[nextChar];
            if (nextValue > currentValue) {
                total += nextValue - currentValue;
                i += 2;
            }
            else {
                total += currentValue;
                i += 1;
            }
        }
        else {
            total += currentValue;
            i += 1;
        }
    }
    return total;
};
console.log(romanToInteger("MMMCMXCIX"));
//Output = 3999
