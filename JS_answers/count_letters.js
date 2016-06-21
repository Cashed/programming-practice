function countLetters(str) {
  var returned = {};

  if (str.length === 0) {
    return returned;
  }

  for (var i = 0; i < str.length; i++) {
    if (!returned.hasOwnProperty(str.charAt(i))) {
      returned[str.charAt(i)] = 1;
    }
    else {
      returned[str.charAt(i)]++;
    }
  }
  return returned;
}

var str = 'abcabbcaa';

console.log(countLetters(str));
