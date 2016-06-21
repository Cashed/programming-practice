// reversing a string

function reverse(str) {
  // check if str is already reversed
  if (str.length == 1) {
    return str;
  }

  // iterate backwards through string and return new reversed string
  var reversed = '';
  for (var i = str.length-1; i >= 0; i--) {
    reversed += str.charAt(i);
  }
  return reversed;
}

var str = 's';
var reverseMe = 'happyhappy';

console.log(reverse(reverseMe));
