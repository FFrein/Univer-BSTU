//1
class product{
    static class_id = 0
    type
    skidka = 15
    _price
    _ID = 0

    set finnaly_price(value){
        this.skidka = value
    }

    get finnaly_price(){
        return this.price - ((this.price / 100) * this.skidka)
    }

    constructor(prod, price){
        this._ID = new Object();
        Object.defineProperty(this._ID, 'id', {
            value: ++product.class_id,
            writable: false,
            configurable: false,
          });
        
          this._ID
          this.type = prod 
          this._price = price
          this.ID
    }
    
    //запрет на изменения
    get ID() {return this._ID.id}
    get price() {return this._price}
}

class boot{
    size
    color
    sub_type

    get size() {return this.size;}
    get color() {return this.color;}
    get sub_type() {return this.sub_type;}

    constructor(size, color, type){
        this.size = size
        this.color = color
        this.sub_type = type
    }
}

//2
let products = {

    Shoes:{
        prod_one : new product(new boot(27, "yellow", "Кроссовки"), 15),
        prod_two : new product(new boot(25, "green", "Сандали"), 6),
        prod_thee : new product(new boot(32, "red", "Ботинки"), 23),    
    },
}

products[Symbol.iterator] = function() {
    let current = products.Shoes.prod_one.ID // текущее значение
    let last = products.Shoes.prod_thee.ID // последнее значение

        return {
            next() {
                if (current <= last) {
                    return { done: false, value: current++ }; 
                } else {
                    return { done: true };
                }
            }
        };
};

//3
function find_product(filter){
    switch(filter){
        case "color":
            let color = prompt("Введите color")  
            for(var item in products.Shoes){
                if(products.Shoes[item].type.color == color)
                    console.log(products.Shoes[item].ID)
            }
            break;

        case "price":
            let price = Number(prompt("Введите price"))
            for(let item in products.Shoes){
                if(products.Shoes[item].price <= price)
                    console.log(products.Shoes[item].ID)
            }
            break;

        case "size":
            let size = Number(prompt("Введите size"))
            for(let item in products.Shoes){
                if(products.Shoes[item].type.size == size)
                    console.log(products.Shoes[item].ID)
            }
            break;

        default:
            console.log("Ошибка фильтра")
    }
}
function FindObjects(){
    let filter = prompt("Параметр поиска");
    find_product(filter)
}

FindObjects()

console.log(products.Shoes.prod_one.finnaly_price)

