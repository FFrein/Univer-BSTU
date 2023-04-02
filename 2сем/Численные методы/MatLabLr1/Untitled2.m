%18 вариант

clear all;

a = 0;%start
b = 1;%end
n = 100; %step
h = (b - a) / n;
x = a : h : b;

%a
aF = x .* sin(3 .* x - 2);
A1 = trapz(x, aF);
A1

A3 = quad('x .* sin(3 .* x - 2)', a, b, h);
A3

%b
bF = exp(-x.^2 - x + 2);
B1 = trapz(x, bF);
B1

B3 = quad('exp(-x.^2 - x + 2)', a, b, h);
B3