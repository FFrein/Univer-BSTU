const str: string = 'Hello';

console.log(str);

const isFetching : boolean = true;
const isLoading : boolean = false;

const int: number = 42;
const float: number = 4.2;
const num: number = 3e10;

const message: string = 'Hello Typescript'

const numberArray: number[] = [1,2,3,4,5];
const numberArray2 : Array<number> = [1,2,3,4,5];

const words: string[] = ['hello','TypeScript'];

//Tuple
const contact: [string, number] = ['asdasd', 123];

//Any
let variable: any = 42;
variable = '12312';

function sayMyName(name: string): void{
    console.log(name);
}

sayMyName("Name");

//Never
function throwErroe(message:string){
    throw new Error(message)
}

function infiniti():never{
    while(true){
        
    }
}

// Type

type Login = string

const login: Login = 'Admin'
//const login2: Login = 2

type ID = string | number
const id1: ID = 1234
const id2: ID = '1234'

type SomeType = string | null | undefined

const ob : SomeType = "123"