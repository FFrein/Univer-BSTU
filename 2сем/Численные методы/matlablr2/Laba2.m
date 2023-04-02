%Вариант 18
X = [-3, -6, -8, -12, -13, -15, -21, -22, -27];
Y = [0.5, 0.7, 1, 1.4, 1.6, 2, 2.8, 3.3, 4];
N = 9;
plot(X, Y, 'b--');

%Блок переменных
sum_x = 0; %сумма x
sum_x_sqr = 0; %сумма x^2
sum_x_cube = 0; %сумма x^3
sum_x_4 = 0; %сумма х^4
sum_xy = 0; %сумма х * у
sum_x2y = 0; %сумма х^2 * y 
sum_y = 0; %сумма y
middle_x = 0; %x среднее
middle_y = 0; %y среднее
chislitel_a = 0; %числитель коэффициента а
znamenatel_a = 0; %знаменатель коэффициента а

%Блок вычислений
for i = 1:N
    sum_x = sum_x + X(i);
    sum_x_sqr = sum_x_sqr + X(i) .^ 2;
    sum_x_cube = sum_x_cube + X(i) .^ 3;
    sum_x_4 = sum_x_4 + X(i) .^ 4;
    sum_x2y = sum_x2y + (X(i)).^2 .* Y(i);
    sum_xy = sum_xy + X(i) .* Y(i);
    middle_x = sum_x ./ N;
    sum_y = sum_y + Y(i);
    middle_y = sum_y ./ N;
end

for i = 1:N
   chislitel_a = chislitel_a + ((X(i) - middle_x) .* (Y(i) - middle_y));
   znamenatel_a = znamenatel_a + (X(i) - middle_x).^2;
end

a = chislitel_a ./ znamenatel_a;
b = middle_y - a .* middle_x;


%Построение МНК для линейной функции
f = Y;
for i = 1:N
    f(i) = a .* X(i) + b;
end
hold on;
plot(X, f);
hold off;


%МНК для квадратической функции
%https://excel2.ru/articles/mnk-kvadratichnaya-zavisimost-v-ms-excel#:~:text=%D0%9C%D0%B5%D1%82%D0%BE%D0%B4%20%D0%BD%D0%B0%D0%B8%D0%BC%D0%B5%D0%BD%D1%8C%D1%88%D0%B8%D1%85%20%D0%BA%D0%B2%D0%B0%D0%B4%D1%80%D0%B0%D1%82%D0%BE%D0%B2%20(%D0%9C%D0%9D%D0%9A)%20%D0%BE%D1%81%D0%BD%D0%BE%D0%B2%D0%B0%D0%BD,%D0%9C%D0%B5%D1%82%D0%BE%D0%B4%20%D0%BD%D0%B0%D0%B8%D0%BC%D0%B5%D0%BD%D1%8C%D1%88%D0%B8%D1%85%20%D0%BA%D0%B2%D0%B0%D0%B4%D1%80%D0%B0%D1%82%D0%BE%D0%B2%20(%D0%B0%D0%BD%D0%B3%D0%BB.
matr = [N sum_x sum_x_sqr;
        sum_x sum_x_sqr sum_x_cube;
        sum_x_sqr sum_x_cube sum_x_4;];

%Решение системы через обратную матрицу
invMatr = inv(matr);
sums = [sum_y; sum_xy; sum_x2y];


%Элементы матрицы  = коэффициенты a b c
A = invMatr * sums;
c_1 = A(1);
b_1 = A(2);
a_1 = A(3);

%Построение МНК для квадратической функции
F(9) = 1;
for i = 1:N
    F(i) = a_1 .* (X(i))^2 + b_1 .* X(i) + c_1;
end


hold on;
plot(X, F);
grid on;
title('МНК');
legend('Первоначальная функция', '-0.1505х - 0.2012', '0.0023x^2 -0.0817x + 0.1796') 
hold off;

