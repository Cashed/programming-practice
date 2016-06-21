// Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
var str = 'cat';
var repeat = 'paddle';
var another = 'p';
var blank = '';
var strange = '!!';
var test = 'garage';

function unique(str) {
  // initialize return value
  var allUnique = true;

  // test if duplicates by size
  if (str.length > 100) {
    allUnique = false;
  }

  // create array of unique characters
  var uniqueChars = [];

  for (var i = 27; i < 127; i++) {
    uniqueChars.push(i);
  }

  // place each char from str in uniqueChars array where index == charCode
  for (var i = 0; i < str.length; i++) {
    if (uniqueChars.includes(str.charAt(i))) {
      allUnique = false;
    }
    else {
      uniqueChars.splice(str.charCode(str.charAt(i)), 1, str.charAt(i));
    }
  }
  console.log(uniqueChars);
  return allUnique;
}

console.log(unique(test));
