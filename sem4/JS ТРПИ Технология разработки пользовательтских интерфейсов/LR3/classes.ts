class TypeScript {
    version: string;

    constructor(_version: string){
        this.version = _version
    }

    info(name: string){
        return '[${name}]: TypeScript version is ${this.version}'
    }
}
//=======================================
class Car{
    readonly model: String

    constructor(_model: string){
        this.model = _model
    }
}

class Car2{
    readonly mobel : string;
    constructor(readonly model: string){}
}
//=======================================

class Animal {
    protected voice: string = ""
    public color: string = "black"

    private go(){
        console.log('GO');
    }
}

class Cat extends Animal{
    public setVoice(_voice : string): void {
        this.voice = _voice;
    }
}

const cat = new Cat()
cat.setVoice('test')
// car.voice

//=======================================

abstract class Component{
    abstract render(): void
    abstract info(): string
}

class AppComponent extends Component{
    render(): void {
        console.log('Render Comp')
    }
    info(): string {
        return 'Info';
    }
}