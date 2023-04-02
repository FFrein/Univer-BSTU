#include <iostream>

int main() {
	using namespace std;
	char stroke_one[] = "one";
	char stroke_two[] = "two";
	char stroke_three[] = "aboba three";
	char stroke_four[] = "biba four";
	char* massiv_ukazatelei[] = { stroke_one, stroke_two, stroke_three, stroke_four };
	char* massiv_ukazatelei_result = massiv_ukazatelei[3];
	cout << massiv_ukazatelei_result;
	return 0;
}