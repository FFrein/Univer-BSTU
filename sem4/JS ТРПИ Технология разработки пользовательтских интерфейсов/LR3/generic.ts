const arrayNum : Array<number> = [1,2,3,4,5]
const arrayStr : Array<string> = ['1','2']

function reverse<T>(array : T[]): T[]{
    return array.reverse();
}

reverse(arrayNum)
reverse(arrayStr)