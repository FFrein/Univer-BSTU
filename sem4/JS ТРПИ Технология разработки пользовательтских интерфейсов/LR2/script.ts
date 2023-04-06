//https://refactoring.guru/ru/design-patterns/iterator/typescript/example#:~:text=%D0%98%D1%82%D0%B5%D1%80%D0%B0%D1%82%D0%BE%D1%80%20%E2%80%94%20%D1%8D%D1%82%D0%BE%20%D0%BF%D0%BE%D0%B2%D0%B5%D0%B4%D0%B5%D0%BD%D1%87%D0%B5%D1%81%D0%BA%D0%B8%D0%B9%20%D0%BF%D0%B0%D1%82%D1%82%D0%B5%D1%80%D0%BD%2C%20%D0%BF%D0%BE%D0%B7%D0%B2%D0%BE%D0%BB%D1%8F%D1%8E%D1%89%D0%B8%D0%B9,%D1%81%D0%BF%D0%BE%D1%81%D0%BE%D0%B1%D0%BE%D0%BC%2C%20%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D1%83%D1%8F%20%D0%B5%D0%B4%D0%B8%D0%BD%D1%8B%D0%B9%20%D0%B8%D0%BD%D1%82%D0%B5%D1%80%D1%84%D0%B5%D0%B9%D1%81%20%D0%B8%D1%82%D0%B5%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BE%D0%B2.

enum ShoesType {
        boots = "Ботинки",
        crossowki =  "Кроссовки",
        sandali = "Сандали"
    }

class Shoes{
    static AmountCounter : number = 0;

    public readonly Id : number = 0;
    public readonly Size : number;
    public readonly Color : string;

    public Type : ShoesType;
    public Price : number;
    public discount : number;

    private _finallyPrice : number

    public get finallyPrice(): number {
        return this._finallyPrice;
    }

    public set finallyPrice(n: number) {
        if(this.discount > 0 && this.discount <= 100)
            this._finallyPrice = this.Price - (this.Price / 100) * this.discount;
        else
        this._finallyPrice = this.Price;
    }

    constructor(_type : ShoesType, _price : number, _size : number, _color : string, _discount = 0){
        this.Type = _type;
        this.Price = _price;
        this.Id = Shoes.AmountCounter++;
        this.Size = _size;
        this.Color = _color;
        this.discount = _discount;
        this.finallyPrice = _price;    
    }
}

interface Iterator<T> {
    current(): T;  

    next(): T;    

    key(): number;    

    valid(): boolean;   

    rewind(): void;  //к началу
}

interface Aggregator {
    getIterator(): Iterator<Shoes>;    // Получить внешний итератор.
}

class AlphabeticalOrderIterator implements Iterator<Shoes> {
    private collection: ShoesCollection;

    private position: number = 0;

    private reverse: boolean = false; 
    
    constructor(collection: ShoesCollection, reverse: boolean = false) {
        this.collection = collection;
        this.reverse = reverse;

        if (reverse) {
            this.position = collection.getCount() - 1;
        }
    }

    public rewind() {
        this.position = this.reverse ?
            this.collection.getCount() - 1 : 0;
    }

    public current(): Shoes {
        return this.collection.getItems()[this.position];
    }

    public key(): number {
        return this.position;
    }

    public next(): Shoes {
        const item = this.collection.getItems()[this.position];
        this.position += this.reverse ? -1 : 1;
        return item;
    }

    public valid(): boolean {
        if (this.reverse) {
            return this.position >= 0;
        }

        return this.position < this.collection.getCount();
    }
}

class ShoesCollection implements Aggregator {
    private items: Shoes[] = [];

    public getItems(): Shoes[] {
        return this.items;
    }

    public getCount(): number {
        return this.items.length;
    }

    public addItem(item: Shoes): void {
        this.items.push(item);
    }

    public getIterator(): Iterator<Shoes> {
        return new AlphabeticalOrderIterator(this);
    }

    public getReverseIterator(): Iterator<Shoes> {
        return new AlphabeticalOrderIterator(this, true);
    }
}

const collection = new ShoesCollection();
collection.addItem(new Shoes(ShoesType.boots, 150, 10, "Red", 0));
collection.addItem(new Shoes(ShoesType.crossowki, 120, 12, "Green", 5));
collection.addItem(new Shoes(ShoesType.sandali, 100, 15, "Blue", 10));

function questionOne() {
    let result : string = "";
    const iterator = collection.getIterator();

    while (iterator.valid()) {
        const app = document.getElementById("QH1");
        const p = document.createElement("p");
        result = "";

        let obj = iterator.next()

        result += "Color: " +  obj.Color + '</br>';
        result += "Id: " +  obj.Id + '</br>';
        result += "Price: " +  obj.Price + '</br>';
        result += "Size: " +  obj.Size + '</br>';
        result += "Type: " +  obj.Type + '</br>';
        result += "discount: " + obj.discount + '</br>';
        result += "finallyPrice: " +  obj.finallyPrice + '</br></br>';

        p.innerHTML = result;
        app?.appendChild(p);
    }
}

function questionTwo() {
    const PriceMax = <HTMLInputElement>document.getElementById("PriceMax");
    const PriceMin = <HTMLInputElement>document.getElementById("PriceMin");
    const Color = <HTMLInputElement>document.getElementById("Color");
    const Size = <HTMLInputElement>document.getElementById("Size");

    let arrayprod = collection.getItems();
    let counter : number = 0;
    counter = 0;

    const app = document.getElementById("QH1");
    const p = document.createElement("p");
    let result : string = "";
    arrayprod.forEach(function(obj){
        if(
            Number(PriceMax.value) >= obj.Price &&
            Number(PriceMin.value) <= obj.Price &&
            Number(Size.value) == obj.Size &&
            Color.value == obj.Color
        ){
            const app = document.getElementById("QH2");
            const p = document.createElement("p");
            result = "";
    
            result += "Color: " +  obj.Color + '</br>';
            result += "Id: " +  obj.Id + '</br>';
            result += "Price: " +  obj.Price + '</br>';
            result += "Size: " +  obj.Size + '</br>';
            result += "Type: " +  obj.Type + '</br>';
            result += "discount: " + obj.discount + '</br>';
            result += "finallyPrice: " +  obj.finallyPrice + '</br></br>';
    
            p.innerHTML = result;
            app?.appendChild(p);
        }

    })
}