//part 1
function createPhoneNumber(numarray) {
    var result = "+(";
    for (var i = 0; i < numarray.length; i++) {
        result += String(numarray[i]);
        if (i == 2)
            result += ") ";
        if (i == 5)
            result += "-";
    }
    return result;
}
var mass = [3, 7, 5, 2, 9, 1, 9, 6, 7, 3, 3, 5];
console.log(createPhoneNumber(mass));
//part 2
var Challenge = /** @class */ (function () {
    function Challenge() {
    }
    Challenge.solution = function (number) {
        var result = 0;
        if (number <= 0)
            return 0;
        for (var i = 0; i <= 10; i++) {
            if (i < number) {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
        }
        return result;
    };
    return Challenge;
}());
console.log(Challenge.solution(9));
//part 3
var mass2 = [1, 2, 3, 4, 5, 6, 7, 8, 9];
console.log(mass2);
function MassMover(number, numarray) {
    var mass_result = [];
    for (var i = 0; i < numarray.length; i++) {
        if (i + number >= numarray.length) {
            mass_result[i] = numarray[i + number - numarray.length];
        }
        else
            mass_result[i] = numarray[i + number];
    }
    return mass_result;
}
console.log(MassMover(3, mass2));
//part 4
var sortedmass1 = [1, 2, 4, 8];
var sortedmass2 = [3, 4, 5, 6];
function Mediana(numarr1, numarr2) {
    var result = 0;
    var counter = 0;
    var mass = [];
    var count1 = 0;
    var count2 = 0;
    var size = 0;
    while (true) {
        if (numarr2[count2] != null && numarr1[count1] >= numarr2[count2]) {
            mass[size] = numarr2[count2];
            count2++;
        }
        else if (numarr1[count1] != null) {
            mass[size] = numarr1[count1];
            count1++;
        }
        if (numarr1.length == count1 && numarr2.length == count2)
            break;
        size++;
    }
    console.log(mass);
    if (mass.length % 2 != 0) {
        result = mass[(mass.length / 2) - 1] + mass[mass.length / 2];
    }
    else {
        result = mass[mass.length / 2];
    }
    return result;
}
console.log(Mediana(sortedmass1, sortedmass2));
//part 5
function sudoku(matrix) {
    for (var i = 0; i < 9; i++) {
        for (var j = 0; j < 9; j++) {
            if (matrix[i][j] > 9 || matrix[i][j] < -1 || matrix[i][j] == 0) {
                return "Вышли за пределы";
            }
        }
    }
    for (var i = 0; i < 9; i++) {
        if (!RowChecking(matrix, i) || !ColChecking(matrix, i)) {
            return "False";
        }
    }
    return "True";
}
function RowChecking(matrix, k) {
    var set = new Set();
    for (var i = 0; i < 9; i++) {
        if (matrix[k][i] == null) {
            continue;
        }
        if (set.has(matrix[k][i])) {
            return false;
        }
        set.add(matrix[k][i]);
    }
    return true;
}
function ColChecking(matrix, k) {
    var set = new Set();
    for (var i = 0; i < 9; i++) {
        if (matrix[i][k] == null) {
            continue;
        }
        if (set.has(matrix[i][k])) {
            return false;
        }
        set.add(matrix[i][k]);
    }
    return true;
}
var sud = [
    [5, 3, null, null, 7, null, null, null, null],
    [6, null, null, 1, 9, 5, null, null, null],
    [1, 9, 8, null, null, null, null, 6, null],
    [8, null, null, null, 6, null, null, null, 3],
    [4, null, null, 8, null, 3, null, null, 1],
    [7, null, null, null, 2, null, null, null, 6],
    [null, 6, null, null, null, null, 2, 8, null],
    [null, null, null, 4, 1, 9, null, null, 5],
    [null, null, null, null, 8, null, null, 7, 9],
];
console.log("result " + sudoku(sud));
