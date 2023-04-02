#include <iostream>
#include <stack>


#define circle firts_stk.push(')'); break;
#define square firts_stk.push(']'); break;
#define curly firts_stk.push('}'); break;
#define less_than firts_stk.push('>'); break;



using namespace std;

bool check_correct(string s)
{
    stack <char> firts_stk; // �������� �����
    for (char symbol : s) {
        switch (symbol) {
            //���������� ���� ����� �������� � ����
        case '(': circle;
        case '[': square;
        case '{': curly;
        case '<': less_than;

        case ')':
        case ']':
        case '}':
        case '>':

            if (firts_stk.empty() || firts_stk.top() != symbol) //�������� �� ����������
                return false;
            firts_stk.pop(); //������� ������� �������
            break;

        default:
            break;
        }
    }
    return firts_stk.empty();
}

int main()
{
    setlocale(LC_ALL, "RUS");
    string s;
    cout << "������� ������ ��� ��������: "; cin >> s;
        if (check_correct(s) == true)
        {
            cout << "\nC����� ����������� �����";
        }
        else
        {
            cout << "\nC����� ����������� �� �����";
        }
}