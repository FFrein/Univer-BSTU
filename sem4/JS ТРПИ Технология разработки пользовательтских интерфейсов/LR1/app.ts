//part 1
function createPhoneNumber(numarray : number[]){
    let result : string = "+(";

    for(let i = 0; i < numarray.length; i++){
        result += String(numarray[i]);

        if(i == 2)
            result += ") ";
        if(i == 5)
            result += "-";
    }
    return result;
}

let mass : number[] = [3, 7, 5, 2, 9, 1, 9, 6, 7, 3, 3, 5]

console.log(createPhoneNumber(mass));

//part 2
class Challenge {
    static solution(number : number){
        let result : number = 0;
        if(number <= 0)
            return 0;
        for(let i = 0; i <= 10; i++){
            if(i < number){
                if(i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
        }
        return result;
    }
}

console.log(Challenge.solution(9));

//part 3
let mass2 : number[] = [1,2,3,4,5,6,7,8,9];
console.log(mass2);

function MassMover(number : number, numarray: number[]){
    let mass_result : number[] = [];
    for (var i = 0; i < numarray.length; i++) {
        if(i + number >= numarray.length){
            mass_result[i] = numarray[i + number - numarray.length];
        }
        else
        mass_result[i] = numarray[i + number];
    }
    return mass_result;
}

console.log(MassMover(3, mass2));

//part 4
let sortedmass1 : number[] = [1, 2, 4, 8];
let sortedmass2 : number[] = [3, 4, 5, 6];
function Mediana(numarr1 : number[], numarr2 : number[]){
    let result = 0;
    let counter = 0
    let mass : number[] = [];

    let count1 = 0;
    let count2 = 0;
    let size = 0;

    while(true){
        if(numarr2[count2] != null && numarr1[count1] >= numarr2[count2]){
            mass[size] = numarr2[count2];
            count2++;
        }
        else if(numarr1[count1] != null){
            mass[size] = numarr1[count1]
            count1++
        }

        if(numarr1.length == count1 && numarr2.length == count2)
            break;

        size++;
    }
    console.log(mass)

    if(mass.length % 2 != 0){
        result = mass[(mass.length / 2) - 1] + mass[mass.length / 2];
    }
    else{
        result = mass[mass.length / 2];
    }
    return result;
}

console.log(Mediana(sortedmass1, sortedmass2));

//part 5

function sudoku(matrix:number[][]) : string
{
    for(let i = 0; i < 9; i++)
    {
        for(let j = 0; j < 9; j++)
        {
            if(matrix[i][j] > 9 || matrix[i][j] < -1 || matrix[i][j] == 0)
            {
                return "Вышли за пределы";
            }
        }
    }

    for(let i = 0; i < 9; i++)
    {
        if(!RowChecking(matrix, i) || !ColChecking(matrix, i))
        {
            return "False";
        }
    }

    return "True";
}

function RowChecking(matrix:number[][], k: number) : boolean
{
    let set = new Set<number>();

    for(let i = 0; i < 9; i++)
    {
        if(matrix[k][i] == null)
        {
            continue;
        }

        if(set.has(matrix[k][i]))
        {
            return false;
        }

        set.add(matrix[k][i]);
    }
    return true;
}

function ColChecking(matrix:number[][], k:number) : boolean
{
    let set = new Set<number>();

    for(let i = 0; i < 9; i++)
    {
        if(matrix[i][k] == null)
        {
            continue;
        }

        if(set.has(matrix[i][k]))
        {
            return false;
        }

        set.add(matrix[i][k]);
    }
    return true;
}

let sud: number[][] = [
    [5,3,null, null,7,null, null,null,null],
    [6,null,null, 1,9,5, null,null,null],
    [1,9,8, null,null,null, null,6,null],

    [8,null,null, null,6,null, null,null,3],
    [4,null,null, 8,null,3, null,null,1],
    [7,null,null, null,2,null, null,null,6],

    [null,6,null, null,null,null, 2,8,null],
    [null,null,null, 4,1,9, null,null,5],
    [null,null,null, null,8,null, null,7,9],
]

console.log("result "+ sudoku(sud));