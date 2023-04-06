class Student{
    id: number;
    name:string;
    group:number;
    marks:number;
    static AmountStud : number = 0; 
    constructor(_name : string, _group: number, _marks: number){
        this.group = _group;
        this.name = _name;
        this.id = Student.AmountStud;
        this.marks = _marks;
        Student.AmountStud = Student.AmountStud + 1;
    }
}


const array : Array<Student> = [
    new Student('Name', 1, 6),
    new Student('Name', 2, 7),
    new Student('Name', 3, 8)
]

interface CarsType{
    [key: string] : string
}

const car : CarsType = {};
car.manufacturer = "1manufacturer";
car.model = '1model';

const car1 : CarsType = {};
car1.manufacturer = "2manufacturer";
car1.model = '2model';

let car2 : CarsType = {};
car2.manufacturer = "3manufacturer";
car2.model = '3model';

class ArrayCarsType{
    [key: string] : Array<CarsType>
}

const arrayCars : Array<ArrayCarsType> = [
    {
        cars: [car1, car2],
        cars2: [car2]
    },
    {
        cars: [car1, car2],
        cars2: [car1]
    }
]

type MarkFilterType =  1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10;

enum DoneType{
    Done,
    NoDone
}

type MarkType = {
    subject: string,
    mark: MarkFilterType,
    done: DoneType,
}

type GroupFilterType = 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12;

type StudentType = {
    id: number,
    name: string,
    group: GroupFilterType,
    marks: Array<MarkType>
}

type GroupType = {
    students: Array<StudentType>; //массив студентов типа StudentType
    studentsFilter: (group: number) => Array<StudentType>, // фиьтр по группе
    marksFilter: (marks: number) => Array<StudentType>,//фильтр по оценке
    deleteStudent: (id: number) => void
    mark: MarkFilterType
    group: GroupFilterType
}

let MathMark : MarkType = {
    subject: "Mathematica",
    mark: 1,
    done: DoneType.Done
}

let StudOne : StudentType = {
    id: 0,
    name: "AAA",
    group: 1,
    marks: [MathMark]
}

let StudTwo : StudentType = {
    id: 1,
    name: "BBB",
    group: 2,
    marks: [MathMark]
};

let AAA : GroupType = {
    students: [StudOne, StudTwo],
    studentsFilter: function (_group: number): StudentType[] {
        return this.students.filter((value) => value.group == _group);
    },

    marksFilter: function (_marks: number): StudentType[] {
        return this.students.filter((value) => value._marks == _marks);
    },
    deleteStudent: function (id: number): void {
        this.students = this.students.filter((value) => value.id != id);
    },
    mark: 5,
    group: 1
};