#include <iostream>
#include<vector>
#include<algorithm>
#include <limits.h>
#include <Windows.h>
using namespace std;

#define V 8
#define START 0


int child = 0;
int populationSize = 0;
int evoCount = 0;

//A	  B   C   D   E   F   G   H
int map[V][V] = {
				{INT_MAX, 12, 15, 9, 17, 1, 8, 12},			 //A
				{12, INT_MAX, 17, 30, 25, 4, 14, 1},		 //B
				{15, 17, INT_MAX, 6, 1, 6, 8, 2},			 //C
				{9,  30, 6, INT_MAX, 16, 11, 12, 32},	     //D
				{17, 25, 1, 16, INT_MAX, 12, 2, 8},			 //E
				{1,   4, 6, 11, 12, INT_MAX, 12, 10},		 //F
				{8,  14, 8, 12, 2, 12,INT_MAX, 10 },		 //G
				{12,  1, 2, 32, 8, 10, 10, INT_MAX },		 //H
};

struct individual {
	string gena;
	int fitness;
};

int rand_num(int start, int end)
{
	int r = end - start;
	int rnum = start + rand() % r;
	return rnum;
}

bool repeat(string s, char ch)
{
	for (int i = 0; i < s.size(); i++) {
		if (s[i] == ch)
			return true;
	}
	return false;
}

int ves(string gena)
{
	int f = 0;
	for (int i = 0; i < gena.size() - 1; i++) {
		if (map[gena[i] - 48][gena[i + 1] - 48] == INT_MAX)
			return INT_MAX;
		f += map[gena[i] - 48][gena[i + 1] - 48];
	}
	return f;
}

int cooldown(int temp) //temper
{
	return (90 * temp) / 100;
}

bool lessthan(struct individual t1,
	struct individual t2)
{
	return t1.fitness < t2.fitness;
}

string Mutate(string gena)
{
	while (true) {
		int r = rand_num(1, V);
		int r1 = rand_num(1, V);
		if (r1 != r) {
			char temp = gena[r];
			gena[r] = gena[r1];
			gena[r1] = temp;
			break;
		}
	}
	return gena;
}

string create_gena()
{
	string gena = "0";
	while (true) {
		if (gena.size() == V) {
			gena += gena[0];
			break;
		}
		int temp = rand_num(1, V);
		if (!repeat(gena, (char)(temp + 48)))
			gena += (char)(temp + 48);
	}
	return gena;
}
								 

void Algoritm(int map[V][V])
{
	int gen = 1;
	int gen_thres = evoCount;

	vector<struct individual> population;
	struct individual temp;

	for (int i = 0; i < populationSize; i++) {
		temp.gena = create_gena();
		temp.fitness = ves(temp.gena);
		population.push_back(temp);
	}

	cout << "\nИзначальная популяция: " << endl << "Геном \tвес \n";

	for (int i = 0; i < populationSize; i++)
		cout << population[i].gena << "\t\t"
		<< population[i].fitness << endl;
	cout << "\n";

	int temperature = 10000;//начальное значнеие

	sort(population.begin(), population.end(), lessthan);

	while (temperature > 100 && gen <= gen_thres) {
		cout << endl << "Лучший геном: " << population[0].gena;
		cout << " его вес: " << population[0].fitness << "\n\n";

		vector<struct individual> new_population;

		for (int i = 0; i < child; i++) {

			struct individual p1 = population[i];

			while (true)
			{
				string new_g = Mutate(p1.gena);
				struct individual new_gena;
				new_gena.gena = new_g;
				new_gena.fitness = ves(new_gena.gena);

				if (new_gena.fitness <= population[i].fitness) {
					new_population.push_back(new_gena);
					break;
				}
				else {
					new_gena.fitness = INT_MAX;
					new_population.push_back(new_gena);
					break;
				}
			}
		}

		temperature = cooldown(temperature);
		for (int i = 0; i < child; i++)
		{
			population.push_back(new_population[i]);
		}
		sort(population.begin(), population.end(), lessthan);

		for (int i = 0; i < child; i++)
		{
			population.pop_back();
		}

		cout << "Поколение " << gen << " \n";
		cout << "Геном \tвес \n";

		for (int i = 0; i < populationSize; i++)
			cout << population[i].gena << "\t\t"
			<< population[i].fitness << endl;
		gen++;
	}

}

int main()
{
	setlocale(LC_ALL, "ru");
	cout << "Циклы эволюции: "; cin >> evoCount;
	cout << "Популяция: "; cin >> populationSize;
	cout << "Потомки: "; cin >> child;
	if (child > populationSize)
		child = populationSize;
	Algoritm(map);
}