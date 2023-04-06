function add(a: number, b: number): number{
    return a=b;
}

function toUpperCase(str: string): string{
    return str.trim().toUpperCase();
}

interface MyPosition {
    x: number | undefined
    y: number | undefined
}

interface MyPositionDefault extends MyPosition{
    default: string
}

function position(): MyPosition
function position(a: number): MyPositionDefault
function position(a:number, b: number): MyPosition

function position(a?: number, b?: number){
    if(!a && !b){
        return {x:undefined, y: undefined}
    }

    if(a && !b){
        return {x:a, y: undefined, default: a.toString()}
    }
    return {x: a, y:b}
}

console.log('Empty: ', position());
console.log('One parm: ', position(32));
console.log('Two parm: ', position(10, 15));