#include <iostream>
#include <queue>
#include <stack>
#include <vector>
#include <array>

using namespace std;
int i, j;
bool visited[10]; // массив посещенных вершинvребраe
//Также O|V|+|E| если мы используем список соединений
//O V^2 МС
// Для конткретного графа, размерность 10
//матрица смежности графа
const int graph[10][10] =
{
	{0, 1, 0, 0, 1, 0, 0, 0, 0, 0},
	{1, 0, 0, 0, 0, 0, 1, 1, 0, 0},
	{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
	{0, 0, 0, 0, 0, 1, 0, 0, 1, 0},
	{1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
	{0, 0, 0, 1, 1, 0, 0, 0, 1, 0},
	{0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
	{0, 1, 1, 0, 0, 0, 1, 0, 0, 0},
	{0, 0, 0, 1, 0, 1, 0, 0, 0, 1},
	{0, 0, 0, 0, 0, 0, 0, 0, 1, 0}
};

void DFS(int start)
{
	stack <int> q;
	bool visited[10]; //false - вершина не рассмотрена, true - рассмотрена
	bool inqueue[10]; //false - вершина не в очереди, true - в очереди
	int view_cell; 
	for (int i = 0; i < 10; i++)
	{
		visited[i] = inqueue[i] = false;
	}
	q.push(start);
	visited[start] = inqueue[start] = true; //рассмотрели первую вершину
	while (!q.empty())
	{
		view_cell = q.top(); //обращение к первому элементу очереди
		cout << view_cell + 1 << " ";

		visited[view_cell] = true;
		q.pop();
		for (int i = 0; i < 10; i++)
		{
			if (!inqueue[i] && graph[view_cell][i])
			{
				q.push(i);
				inqueue[i] = true;
			}
		}
	}
}

void BFS(int start)
{
	queue <int> q;
	bool visited[10]; //false - вершина не рассмотрена, true - рассмотрена
	bool inqueue[10]; //false - вершина не в очереди, true - в очереди
	int view_cell;
	for (int i = 0; i < 10; i++)	
	{
		visited[i] = inqueue[i] = false;
	}
	q.push(start); 
	visited[start] = inqueue[start] = true; //рассмотрели первую вершину
	while (!q.empty())
	{
		view_cell = q.front(); //обращение к первому элементу очереди
		cout << view_cell + 1 << " ";

		visited[view_cell] = true;
		q.pop();
		for (int i = 0; i < 10; i++)
		{
			if (!inqueue[i] && graph[view_cell][i])
			{
				q.push(i);
				inqueue[i] = true;
			}
		}
	}
}

struct Edge
{
	int src;
	int dest;
};

void main() {
	setlocale(LC_ALL, "rus");
	int n = 11;
	int start= 1;

	vector<Edge> edges =
	{
		{1, 2}, {2, 1}, {1, 5}, {5, 1},
		{2, 7}, {7, 2}, {2, 8}, {8, 2},
		{7, 8}, {8, 7}, {8, 3}, {3, 8},
		{5, 6}, {6, 5}, {4, 6}, {6, 4},
		{4, 9}, {9, 4}, {6, 9}, {9, 6}, 
		{9, 10}, {10, 9}
	};
	vector<vector<int>> adjList;
	adjList.resize(n);

	cout << "Стартовая вершина: " << start;
	cout << endl;
	cout << "\nПорядок обхода в глубину: ";
	DFS(start - 1);
	cout << "\n\nПорядок обхода в ширину: ";
	BFS(start - 1);
	cout << "\n\n";

	cout << "Список смежности: " << endl;
	for (auto& edge : edges)
	{
		adjList[edge.src].push_back(edge.dest);
	}
	for (int i = 1; i < n; i++)
	{
		cout << i << ":";
		for (int v : adjList[i]) {
			cout << v << ", ";
		}
		cout << endl;
	}
	cout << endl;
	cout << "Список ребер" << endl;
	   for (int i = 1; i < n; i++)
	   {
		   for (int v : adjList[i]) {
			   cout << "{" << i<<","<<v<<"}";
		   }
		   cout << endl;
	   }
	cout << endl;
	
	cout << "Матрица смежности графа: " << endl;
	for (i = 0; i < 10; i++)
	{
		visited[i] = false;
		for (j = 0; j < 10; j++)
			cout << " " << graph[i][j];
		cout << endl;
	}
	cout << endl;
}


