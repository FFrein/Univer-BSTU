#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

bool checker(std::vector<int> vstd, int check)
{
	for (int g = 0; g < vstd.size(); g++)
		if (check == vstd[g])
			return true;
	return false;
}

void main() {
	int inf = 2147483647;
	int mass[8][8] = {
	//   v0    v1   v2   v3   v4   v5   v6  v7 
		 {inf , 2  ,inf ,8   ,2   ,inf ,inf ,inf}, //v0
		 {2   ,inf ,3   ,10  ,5   ,inf ,inf ,inf}, //v1
		 {inf ,3   ,inf ,inf ,12  ,inf ,inf ,7},   //v2
		 {8   ,10  ,inf ,inf ,14  ,3   ,1   ,inf}, //v3
		 {2   ,5   ,12  ,14  ,inf ,11  ,4   ,8},   //v4
		 {inf ,inf ,inf ,3   ,11  ,inf ,6   ,inf}, //v5
		 {inf ,inf ,inf ,1   ,4   ,6   ,inf ,9},   //v6
		 {inf ,inf ,7   ,inf ,8   ,inf ,9   ,inf}, //v7
	};
	int result[8][8] = {};
	
	std::vector<int> visited;

	visited.push_back(0); // добавляем начальную точку

	int weight = inf; //вес
	int VisitNow; // номер посещяемого в масииве посещённых
	int FromPoint; // из какой точки соединяем

	while (visited.size() != 8)
	{
		VisitNow = inf;
		FromPoint = inf;
		weight = inf;
		for (int a = 0; a < visited.size(); a++) {
			for (int i = 0; i < 8; i++) {
				if (mass[visited[a]][i] < weight && checker(visited, i) == false) {
					weight = mass[visited[a]][i];
					VisitNow = i;
					FromPoint = visited[a];
				}
			};
		};
		if (VisitNow != inf && FromPoint != inf) {
			result[FromPoint][VisitNow] = weight;
			visited.push_back(VisitNow);
		}
	}

	int sum = 0;
	for (int i = 0; i < 8; i++) {
		for (int j = 0; j < 8; j++)
			if (result[i][j] != NULL) {
				cout << "[" << i + 1 << "][" << j + 1 << "]:" << result[i][j] << "\n";
				sum += result[i][j];
			}
	}
	cout << sum;
}
