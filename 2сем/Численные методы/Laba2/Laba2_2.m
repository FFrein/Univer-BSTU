%lab2
%метод наименьших квадртаов
%Вариант 18
%часть 2
%это метод для прямых
clear all;
%переменные варианта
X = [-3, -6, -8, -12, -13, -15, -21, -22, -27];
Y = [0.5, 0.7, 1, 1.4, 1.6, 2, 2.8, 3.3, 4];

f=least_squares_method(X,Y);
plot(X,f(X),X,Y);

function y=least_squares_method(X,Y)%объявление функции с параметрами
    n=size(X,2);
    A=[n sum(X); sum(X) sum(X.^2)];
    b=[sum(Y);sum(X.*Y)];
    Koef=inv(A)*b;
    a0=Koef(1);
    a1=Koef(2);
    y=@(x)a0+a1.*x;
end
