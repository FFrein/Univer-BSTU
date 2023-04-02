#include <iostream>
#include <cstring>
#include <string>
#include <stack>

using namespace std;

int priority(char a) {
	if (a == '(' || a == ')')
		return 1;
	if (a == '+' || a == '-')
		return 2;
	if (a == '/' || a == '*')
		return 3;
	return 0;
}

string PolishNotation(char* str) {
	string result = "";
	stack <char> STCK;
	
	for (int i = 0; str[i]; i++) {
		if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '(' || str[i] == ')') {
			if (STCK.empty() || STCK.top() == '('){
				STCK.push(str[i]);
				continue;
			}
			else if (str[i] == '(') {
				STCK.push(str[i]);
				continue;
			}
			else {
				if (str[i] == ')') {
					while (STCK.top() != '(') {
						result += STCK.top();
						STCK.pop();
					}
					STCK.pop();
					continue;
				}
				if (priority(str[i]) <= priority(STCK.top())) {
					while (priority(str[i]) <= priority((char)STCK.top())) {
						result += STCK.top();
						STCK.pop();
						if (STCK.empty()) break;
					}
					STCK.push(str[i]);
					continue;
				}
				STCK.push(str[i]);
				continue;
			}
		}
		else {
			if (str[i] != ' ')
				result += str[i];
		}
	}
	while (!STCK.empty()){
		result += STCK.top();
		STCK.pop();
	}

	return result;
}

void main() {
	char exempl1[] = "(a+b)*(c+d)-e";
	char exempl2[] = "(a+(b-g))*(c+d)-e";
	char exempl3[] = "(a + c / (a + c / (a + c)))* (a + c)";
	char exempl4[] = "(a+c)*2+2";
	char exempl5[] = "2*(a+c)-2*(2+q)*p+2";
	char exempl6[] = "q+w+e+r+t*y/s+1/(p+g)";
	char exempl7[] = "(q-w+e*r+t*y-s*k/(p+g))/z";
	char exempl8[] = "(x + (y * z + x) * z)";
	char exempl9[] = "2+2*2";
	cout << "(a+b)*(c+d)-e -- > " << PolishNotation(exempl1) << endl;//ab+cd+*e-
	cout << "(a+(b-g))*(c+d)-e -- > " << PolishNotation(exempl2) << endl;//abg-+cd+*e-
	cout << "(a+c/(a+c/(a+c)))*(a+c) --> " << PolishNotation(exempl3) << endl; //a c a c a c + / + / + a c + *
	cout << "(a+c)*2+2 --> " << PolishNotation(exempl4) << endl; // a c + 2 * 2 +
	cout << "2*(a+c)-2*(2+q)*p+2 --> " << PolishNotation(exempl5) << endl; // 2 a c + * 2 2 q + * p * - 2 +
	cout << "q+w+e+r+t*y/s+1/(p+g) --> " << PolishNotation(exempl6) << endl; // q w + e + r + t y * s / + 1 p g + / +
	cout << "(q-w+e*r+t*y-s*k/(p+g))/z --> " << PolishNotation(exempl7) << endl; // q w - e r * + t y * + s k * p g + / - z /
	cout << "x + (y * z + x) * z --> " << PolishNotation(exempl8) << endl; //x y z * x + z * +
	cout << "2+2*2 -->" << PolishNotation(exempl9) << endl;
}