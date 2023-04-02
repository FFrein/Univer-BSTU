%Вариант 18
%Функции А и В
f = @(x) x.* sin(3 .* x - 2);
g = @(x) exp(-x.^2 - x + 2);

%Объявление переменных
a = 0;
b = 1;
n1 = 10;
n2 = 100;


%Создание массива с результатами f =x.* sin(3 .* x - 2);
arr(1)=integral(f,a,b); % Вычисление интеграла
arr(2)=trapezoid(a,b,f,n1); % Вычисление по формуле трапеций с шагом 10
arr(3)=trapezoid(a,b,f,n2); % Вычисление по формуле трапеций с шагом 100
arr(4)=rectangle(a,b,f,n1); % Вычисление по формуле прямоугольников(средних) с шагом 10
arr(5)=rectangle(a,b,f,n2); % Вычисление по формуле прямоугольников(средних) с шагом 100
arr(6)=simpson(a,b,f,n1); % Вычисление по формуле Симпсона с шагом 10
arr(7)=simpson(a,b,f,n2); % Вычисление по формуле Симпсона с шагом 100

disp('Интеграл A');
disp(arr(1));

disp('Интеграл A, по формуле трапеций с шагом 10 и 100');
disp(arr(2));
disp(arr(3));

disp('Интеграл A, по формуле прямоугольников(средних) с шагом 10 и 100');
disp(arr(4));
disp(arr(5));

disp('Интеграл A, по формуле Симпсона с шагом 10 и 100');
disp(arr(6));
disp(arr(7));

disp('Абсолютная погрешность по формуле трапеции с шагом 10');
delta_abs1=abs(arr(1)-arr(2));
disp(delta_abs1);

disp('Относительная погрешность по формуле трапеции с шагом 10, %');
delta_rel1=(delta_abs1/arr(1)) * 100;
disp(delta_rel1);

disp('Абсолютная погрешность по формуле трапеции с шагом 100');
delta_abs2=abs(arr(1)-arr(3)); 
disp(delta_abs2);

disp('Относительная погрешность по формуле трапеции с шагом 100, %');
delta_rel2=(delta_abs2/arr(1)) * 100;
disp(delta_rel2);

disp('Абсолютная погрешность по формуле прямоугольников(средних) с шагом 10');
delta_abs3=abs(arr(1)-arr(4));
disp(delta_abs3);

disp('Относительная погрешность по формуле прямоугольников(средних) с шагом 10, %');
delta_rel3=(delta_abs3/arr(1)) * 100;
disp(delta_rel3);

disp('Абсолютная погрешность по формуле прямоугольников(средних) с шагом 100');
delta_abs4=abs(arr(1)-arr(5));
disp(delta_abs4);

disp('Относительная погрешность по формуле прямоугольников(средних) с шагом 100, %');
delta_rel4=(delta_abs4/arr(1)) * 100;
disp(delta_rel4);

disp('Абсолютная погрешность по формуле Симпсона с шагом 10');
delta_abs5=abs(arr(1)-arr(6));
disp(delta_abs5);

disp('Относительная погрешность по формуле Симпсона с шагом 10, %');
delta_rel5=(delta_abs5/arr(1)) * 100;
disp(delta_rel5);

disp('Абсолютная погрешность по формуле Симпсона с шагом 100');
delta_abs6=abs(arr(1)-arr(7));
disp(delta_abs6);

disp('Относительная погрешность по формуле Симпсона с шагом 100, %');
delta_rel6=(delta_abs6/arr(1)) * 100;
disp(delta_rel6);

disp('xxxxx');

disp('xxxxx');


%Создание массива с результатами g = exp(-x.^2 - x + 2);
arr_1(1)=integral(g,a,b); % Вычисление интеграла
arr_1(2)=trapezoid(a,b,g,n1); % Вычисление по формуле трапеций с шагом 10
arr_1(3)=trapezoid(a,b,g,n2); % Вычисление по формуле трапеций с шагом 100
arr_1(4)=rectangle(a,b,g,n1); % Вычисление по формуле прямоугольников(средних) с шагом 10
arr_1(5)=rectangle(a,b,g,n2); % Вычисление по формуле прямоугольников(средних) с шагом 100
arr_1(6)=simpson(a,b,g,n1); % Вычисление по формуле Симпсона с шагом 10
arr_1(7)=simpson(a,b,g,n2); % Вычисление по формуле Симпсона с шагом 100

disp('Интеграл В');
disp(arr_1(1));

disp('Интеграл В, по формуле трапеций с шагом 10 и 100');
disp(arr_1(2));
disp(arr_1(3));

disp('Интеграл В, по формуле прямоугольников(средних) с шагом 10 и 100');
disp(arr_1(4));
disp(arr_1(5));

disp('Интеграл В, вычисленные по формуле Симпсона с шагом 10 и 100');
disp(arr_1(6));
disp(arr_1(7));

disp('Абсолютная погрешность по формуле трапеции с шагом 10');
delta_abs1_1=abs(arr_1(1)-arr_1(2));
disp(delta_abs1_1);

disp('Относительная погрешность по формуле трапеции с шагом 10, %');
delta_rel1_1=(delta_abs1_1/abs(arr_1(1))) * 100;
disp(delta_rel1_1);

disp('Абсолютная погрешность по формуле трапеции с шагом 100');
delta_abs2_2=abs(arr_1(1)-arr_1(3)); 
disp(delta_abs2_2);

disp('Относительная погрешность по формуле трапеции с шагом 100, %');
delta_rel2_2=(delta_abs2_2/abs(arr_1(1))) * 100;
disp(delta_rel2_2);

disp('Абсолютная погрешность по формуле прямоугольников(средних) с шагом 10');
delta_abs3_3=abs(arr_1(1)-arr_1(4));
disp(delta_abs3_3);

disp('Относительная погрешность по формуле прямоугольников(средних) с шагом 10, %');
delta_rel3_3=(delta_abs3_3/abs(arr_1(1))) * 100;
disp(delta_rel3_3);


disp('Абсолютная погрешность по формуле прямоугольников(средних) с шагом 100');
delta_abs4_4=abs(arr_1(1)-arr_1(5));
disp(delta_abs4_4);

disp('Относительная погрешность по формуле прямоугольников(средних) с шагом 100, %');
delta_rel4_4=(delta_abs4_4/abs(arr_1(1))) * 100;
disp(delta_rel4_4);

disp('Абсолютная погрешность по формуле Симпсона с шагом 10');
delta_abs5_5=abs(arr_1(1)-arr_1(6));
disp(delta_abs5_5);

disp('Относительная погрешность по формуле Симпсона с шагом 10, %');
delta_rel5_5=(delta_abs5_5/abs(arr_1(1))) * 100;
disp(delta_rel5_5);

disp('Абсолютная погрешность по формуле Симпсона с шагом 100');
delta_abs6_6=abs(arr_1(1)-arr_1(7));
disp(delta_abs6_6);

disp('Относительная погрешность по формуле Симпсона с шагом 100, %');
delta_rel6_6=(delta_abs6_6/abs(arr_1(1))) * 100;
disp(delta_rel6_6);


% Блок функций
function sum = trapezoid(a,b,f,n) % Функция подсчёта по формуле трапеции
h=(b-a)/n; %Шаг
sum=0;
for i=a:h:b
    if i~=b
        sum = sum + (f(i)+f(i+h))/2*h;
    end
end
end

function sum = rectangle(a,b,f,n) % Функция подсчёта по формуле прямоугольников(средних)
h=(b-a)/n;
sum=0;
for i=(a + h/2):h:b
        sum = sum + f(i);
end
sum = sum .* h;
end

function sum = simpson(a,b,f,n) % Функция подсчёта по формуле Симпсона
h=(b-a)/n;
sum = 0;
k = 1;
x = a:h:b;
while k <= n+1
    if (k ~= 1) && (k ~= n+1) && (mod(k, 2) == 0)
        sum = 4 .* f(x(k)) + sum;
    elseif (k ~= 1) && (k ~= n+1) && (mod(k, 2) ~= 0)
        sum = 2 .* f(x(k)) + sum;
    else
        sum = f(x(k)) + sum;
    end
    k = k + 1;
end
sum = h ./ 3 .* sum;
end
