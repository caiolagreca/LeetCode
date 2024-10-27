const getPrefix = (list: string[]): string => {
  if (list == null || list.length == 0) {
    return "";
  }

  let prefix: string = list[0];

  for (let i: number = 1; i < list.length; i++) {
    while (list[i].indexOf(prefix) != 0) {
      prefix = prefix.substring(0, prefix.length - 1);
      if (prefix == "") {
        return ""; 
      }
    }
  }
  return prefix;
};

let result = getPrefix(["flower", "fow", "flight"]);
console.log(`the prefix is: ${result}`);
