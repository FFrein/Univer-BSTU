%лаба 3 вариант 18
format long
n = 0.01;

F1 = @(x)x.^3 + 9.*x-3;
F1_for_simple = @(x) x - (1/(3*x.^2+2)).*(x.^3 + 2.*x + 2); 
F1_ = @(x)3*x.^2 + 9;
F1__ = @(x) 6*x;

%Ось оx
F2 = @(x) 0;

x01 = fzero(F1, 0);
y01 = 0;

figure Name 1
    ezplot(F1),hold on;
    ezplot(F2);

plot(x01, y01, 'or');


start_answer = Find_start(F1, F1);

disp_start_answer = ['Начальное приближение: ', 'x0 = ', num2str(start_answer)];
disp(disp_start_answer)

disp(Niuton(F1, F1_, start_answer, n))

disp(Half_division(F1, -2, 2, n))

disp(Simple_iteration(F1_for_simple, n))


% Дихатомия
%half division answer
function HDA = Half_division(F, a, b , n)
    while b-a > n
        c = (a + b) / 2;
        if F(b)*F(c) < 0
            a = c;
        else 
            b = c;
        end
    end
    HDA = c;
end 
% Начальное приближение
function find_start_answer = Find_start(F, F__)
    n = 0;
    while F(n)*F__(n) < 0
        n = n +1;
    end
    find_start_answer = n;
end
% Ньютона
function Newton_answer = Niuton(F, F_, start_answer, n)
    %n - точность вычислени
    NA_last = start_answer;
    NA_last = NA_last -F(NA_last)/F_(NA_last);
    Newton_answer = 1;
    counter = 0;
    
    while(abs(Newton_answer-NA_last) > n)
        NA_last = Newton_answer;
        Newton_answer = NA_last -F(NA_last)/F_(NA_last);
        counter = counter + 1;
        Calc_err = abs(Newton_answer-NA_last);
        
        disp('-------------------------------------------')
        %About iteration
        Info_AI = ['Итерация номер - ' num2str(counter), ':'];
        %About iteration method
        Info_AIM = ['приближенный ответ - '  num2str(Newton_answer)];
        %About iteration calc
        Info_AIC = ['погрешность - '  num2str(Calc_err)];
        
        disp(Info_AI);
        disp(Info_AIM);
        disp(Info_AIC);
    end
end

%метод простых итераций
function SIM = Simple_iteration(F, n)
    x_ = 0;% начальное приближение 
    x0 = 0;% начальное приближение 
    x1 = F(x0);% первое значение 
    N = 100;% количество итераций, чтобы не было зацикливаний 
    for counter = 1 : N %делаем максимум 100 итераций
        if (x1 - x0).^2/abs(2*x0-x1-x_) < n
            break
        end
        x_ = x0;
        x0 = x1;
        x1 = F(x0);
    end
    disp(counter);
    SIM = x1;
end