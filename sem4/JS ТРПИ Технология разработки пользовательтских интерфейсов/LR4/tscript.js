var Student = /** @class */ (function () {
    function Student(_name, _group, _marks) {
        this.group = _group;
        this.name = _name;
        this.id = Student.AmountStud;
        this.marks = _marks;
        Student.AmountStud = Student.AmountStud + 1;
    }
    Student.AmountStud = 0;
    return Student;
}());
var array = [
    new Student('Name', 1, 6),
    new Student('Name', 2, 7),
    new Student('Name', 3, 8)
];
var car = {};
car.manufacturer = "1manufacturer";
car.model = '1model';
var car1 = {};
car1.manufacturer = "2manufacturer";
car1.model = '2model';
var car2 = {};
car2.manufacturer = "3manufacturer";
car2.model = '3model';
var ArrayCarsType = /** @class */ (function () {
    function ArrayCarsType() {
    }
    return ArrayCarsType;
}());
var arrayCars = [
    {
        cars: [car1, car2],
        cars2: [car2]
    },
    {
        cars: [car1, car2],
        cars2: [car1]
    }
];
var DoneType;
(function (DoneType) {
    DoneType[DoneType["Done"] = 0] = "Done";
    DoneType[DoneType["NoDone"] = 1] = "NoDone";
})(DoneType || (DoneType = {}));
var MathMark = {
    subject: "Mathematica",
    mark: 5,
    done: DoneType.Done
};
var Physics = {
    subject: "Mathematica",
    mark: 7,
    done: DoneType.Done
};
var StudOne = {
    id: 0,
    name: "AAA",
    group: 1,
    marks: [MathMark, Physics]
};
var StudTwo = {
    id: 1,
    name: "BBB",
    group: 2,
    marks: [MathMark, Physics]
};
var AAA = {
    students: [StudOne, StudTwo],
    studentsFilter: function (_group) {
        return this.students.filter(function (value) { return value.group == _group; });
    },
    marksFilter: function (_marks) {
        return this.students.filter(function (student) { return student.marks.filter(function (marks) { return marks.mark === _marks; }).length > 0; });
    },
    deleteStudent: function (id) {
        this.students = this.students.filter(function (value) { return value.id != id; });
    },
    mark: 1,
    group: 1
};
