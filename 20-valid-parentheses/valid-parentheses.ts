function isValid(s: string): boolean {
  if (s.length % 2 !== 0) {
    return false;
  }

  let stack: string[] = [];

  const parenthesesMap: { [key: string]: string } = {
    '(': ')',
    '{': '}',
    '[': ']',
  };

  for (let i = 0; i < s.length; i++) {
    const currentChar = s[i];

    if (parenthesesMap.hasOwnProperty(currentChar)) {
      stack.push(parenthesesMap[currentChar]);
    } else {
      const expectedClosing = stack.pop();
      if (expectedClosing !== currentChar) {
        return false;
      }
    }
  }

  return stack.length === 0;
}
