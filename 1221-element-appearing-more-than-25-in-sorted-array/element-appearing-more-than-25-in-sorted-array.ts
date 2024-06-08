function findSpecialInteger(arr: number[]): number {
   const arrLength = arr.length;
   const percentage = arrLength >> 2;

   for (let i = 0; i < arrLength; i++) {
    const currentNumber = arr[i];
    let count = 1;

    for (let j = i + 1; j < arrLength && arr[j] === currentNumber; j++) {
      count++;
    }

    if (count > percentage) {
      return currentNumber;
    }

    i += count - 1;
  }

  return -1; 
};