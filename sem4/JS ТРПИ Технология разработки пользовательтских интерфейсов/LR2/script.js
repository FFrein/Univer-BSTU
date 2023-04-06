//https://refactoring.guru/ru/design-patterns/iterator/typescript/example#:~:text=%D0%98%D1%82%D0%B5%D1%80%D0%B0%D1%82%D0%BE%D1%80%20%E2%80%94%20%D1%8D%D1%82%D0%BE%20%D0%BF%D0%BE%D0%B2%D0%B5%D0%B4%D0%B5%D0%BD%D1%87%D0%B5%D1%81%D0%BA%D0%B8%D0%B9%20%D0%BF%D0%B0%D1%82%D1%82%D0%B5%D1%80%D0%BD%2C%20%D0%BF%D0%BE%D0%B7%D0%B2%D0%BE%D0%BB%D1%8F%D1%8E%D1%89%D0%B8%D0%B9,%D1%81%D0%BF%D0%BE%D1%81%D0%BE%D0%B1%D0%BE%D0%BC%2C%20%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D1%83%D1%8F%20%D0%B5%D0%B4%D0%B8%D0%BD%D1%8B%D0%B9%20%D0%B8%D0%BD%D1%82%D0%B5%D1%80%D1%84%D0%B5%D0%B9%D1%81%20%D0%B8%D1%82%D0%B5%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BE%D0%B2.
var ShoesType;
(function (ShoesType) {
    ShoesType["boots"] = "\u0411\u043E\u0442\u0438\u043D\u043A\u0438";
    ShoesType["crossowki"] = "\u041A\u0440\u043E\u0441\u0441\u043E\u0432\u043A\u0438";
    ShoesType["sandali"] = "\u0421\u0430\u043D\u0434\u0430\u043B\u0438";
})(ShoesType || (ShoesType = {}));
var Shoes = /** @class */ (function () {
    function Shoes(_type, _price, _size, _color, _discount) {
        if (_discount === void 0) { _discount = 0; }
        this.Id = 0;
        this.Type = _type;
        this.Price = _price;
        this.Id = Shoes.AmountCounter++;
        this.Size = _size;
        this.Color = _color;
        this.discount = _discount;
        this.finallyPrice = _price;
    }
    Object.defineProperty(Shoes.prototype, "finallyPrice", {
        get: function () {
            return this._finallyPrice;
        },
        set: function (n) {
            if (this.discount > 0 && this.discount <= 100)
                this._finallyPrice = this.Price - (this.Price / 100) * this.discount;
            else
                this._finallyPrice = this.Price;
        },
        enumerable: false,
        configurable: true
    });
    Shoes.AmountCounter = 0;
    return Shoes;
}());
var AlphabeticalOrderIterator = /** @class */ (function () {
    function AlphabeticalOrderIterator(collection, reverse) {
        if (reverse === void 0) { reverse = false; }
        this.position = 0;
        this.reverse = false; //Эта переменная указывает направление обхода.
        this.collection = collection;
        this.reverse = reverse;
        if (reverse) {
            this.position = collection.getCount() - 1;
        }
    }
    AlphabeticalOrderIterator.prototype.rewind = function () {
        this.position = this.reverse ?
            this.collection.getCount() - 1 : 0;
    };
    AlphabeticalOrderIterator.prototype.current = function () {
        return this.collection.getItems()[this.position];
    };
    AlphabeticalOrderIterator.prototype.key = function () {
        return this.position;
    };
    AlphabeticalOrderIterator.prototype.next = function () {
        var item = this.collection.getItems()[this.position];
        this.position += this.reverse ? -1 : 1;
        return item;
    };
    AlphabeticalOrderIterator.prototype.valid = function () {
        if (this.reverse) {
            return this.position >= 0;
        }
        return this.position < this.collection.getCount();
    };
    return AlphabeticalOrderIterator;
}());
var ShoesCollection = /** @class */ (function () {
    function ShoesCollection() {
        this.items = [];
    }
    ShoesCollection.prototype.getItems = function () {
        return this.items;
    };
    ShoesCollection.prototype.getCount = function () {
        return this.items.length;
    };
    ShoesCollection.prototype.addItem = function (item) {
        this.items.push(item);
    };
    ShoesCollection.prototype.getIterator = function () {
        return new AlphabeticalOrderIterator(this);
    };
    ShoesCollection.prototype.getReverseIterator = function () {
        return new AlphabeticalOrderIterator(this, true);
    };
    return ShoesCollection;
}());
var collection = new ShoesCollection();
collection.addItem(new Shoes(ShoesType.boots, 150, 10, "Red", 0));
collection.addItem(new Shoes(ShoesType.crossowki, 120, 12, "Green", 5));
collection.addItem(new Shoes(ShoesType.sandali, 100, 15, "Blue", 10));
function questionOne() {
    var result = "";
    var iterator = collection.getIterator();
    while (iterator.valid()) {
        var app = document.getElementById("QH1");
        var p = document.createElement("p");
        result = "";
        var obj = iterator.next();
        result += "Color: " + obj.Color + '</br>';
        result += "Id: " + obj.Id + '</br>';
        result += "Price: " + obj.Price + '</br>';
        result += "Size: " + obj.Size + '</br>';
        result += "Type: " + obj.Type + '</br>';
        result += "discount: " + obj.discount + '</br>';
        result += "finallyPrice: " + obj.finallyPrice + '</br></br>';
        p.innerHTML = result;
        app === null || app === void 0 ? void 0 : app.appendChild(p);
    }
}
function questionTwo() {
    var PriceMax = document.getElementById("PriceMax");
    var PriceMin = document.getElementById("PriceMin");
    var Color = document.getElementById("Color");
    var Size = document.getElementById("Size");
    var arrayprod = collection.getItems();
    var counter = 0;
    counter = 0;
    var app = document.getElementById("QH1");
    var p = document.createElement("p");
    var result = "";
    arrayprod.forEach(function (obj) {
        if (Number(PriceMax.value) >= obj.Price &&
            Number(PriceMin.value) <= obj.Price &&
            Number(Size.value) == obj.Size &&
            Color.value == obj.Color) {
            var app_1 = document.getElementById("QH2");
            var p_1 = document.createElement("p");
            result = "";
            result += "Color: " + obj.Color + '</br>';
            result += "Id: " + obj.Id + '</br>';
            result += "Price: " + obj.Price + '</br>';
            result += "Size: " + obj.Size + '</br>';
            result += "Type: " + obj.Type + '</br>';
            result += "discount: " + obj.discount + '</br>';
            result += "finallyPrice: " + obj.finallyPrice + '</br></br>';
            p_1.innerHTML = result;
            app_1 === null || app_1 === void 0 ? void 0 : app_1.appendChild(p_1);
        }
    });
}
