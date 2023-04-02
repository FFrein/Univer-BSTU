#include <iostream>

using namespace std;
//����� ����������� ���� �� �������� �������
void Deykstra(int graph[9][9], int src);

void printResult(int dist[]);
//����� ������� � ����������� ��������� ����������
int minDistance(int dist[], bool Visited[]);

//ABCDEFGHI
//12345678

int main()
{
    setlocale(LC_ALL, "rus");
    // ������� ��������� �����
    int graph[9][9] =
    {
        //   A  B  C   D  E  F  G  H  I
            {0, 7, 10, 0, 0, 0, 0, 0, 0},//A
            {7, 0, 0, 0, 0, 9, 27, 0, 0},//B
            {10, 0, 0, 0, 31, 8, 0, 0, 0},//C
            {0, 0, 0, 0, 32, 0, 0, 17, 21},//D
            {0, 0, 31, 32, 0, 0, 0, 0, 0},//E
            {0, 9, 8, 0, 0, 0, 0, 11, 0},//F
            {0, 27, 0, 0, 0, 0, 0, 0, 15},//G
            {0, 0, 0, 17, 0, 11, 0, 0, 15},//H
            {0, 0, 0, 21, 0, 0, 15, 15, 0},//I
    };
    int number;
    bool checker = false;
    do {
        cout << "������� ��������� �������: ";
        cin >> number;
        cin.clear();
        cin.ignore();
    } while (number < 0 || number >= 8);
    cout << endl;
    Deykstra(graph, number);
}
int minDistance(int dist[], bool Visited[])
{
    int min = INT_MAX;
    int min_index;// ���������������� ����������� ��������
    for (int v = 0; v < 9; v++)
    {
        if (Visited[v] == false && dist[v] <= min)
            min = dist[v], min_index = v;
    }
    return min_index;
}
void printResult(int dist[])
{
    cout << "������� \t ����" << endl;
    char str[9] = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    for (int i = 0; i < 9; i++)
        cout << "1 - " << str[i] << " \t\t " << dist[i] << endl;
}
void Deykstra(int graph[9][9], int str)
{
    int dist[9]; //�������� ���������� ����������

    bool Visited[9]; //true, ���� ������� �������� � ����������

    for (int i = 0; i < 9; i++)
        dist[i] = INT_MAX, Visited[i] = false;

    dist[str] = 0;//���������� �� A �� A

    //����� ����� ����
    for (int count = 0; count < 9 - 1; count++) {
        //3
        int u = minDistance(dist, Visited);
        Visited[u] = true;// �������� ������� ��� ������������
        //4
        for (int point = 0; point < 9; point++)
            if (!Visited[point] && graph[u][point]
                && dist[u] != INT_MAX
                && dist[u] + graph[u][point] < dist[point])
                dist[point] = dist[u] + graph[u][point];
    }
    printResult(dist);
}

/*

  A   B   C   D    E    F    G    H    I
= 1   2   3   4    5    6    7    8    9
1 0   -   -   -    -    -    -    -    -
2 �   7   10  -    -    -    -    -    -
3 -   �   10  -    -    16   34   -    -
4 -   -   �   -    41   16   -    -    - �� b ���� ������ ��� �� �
5 -   -   -   -    -    �    -    27   -
6 -   -   -   44   -    -    -    �    42
7 -   -   -   44   -    -    34   -    � �� b ���� ������ ��� �� i; bp h ���� ������ ��� �� I
8 -   -   -   -    -    -    �    -    -
9 -   -   -   �    -    -    -    -    -
10-   -   -   -    41   -    -    -    -
  0   7   10  44   41   16   34   27   42
*/
//m-���� n-�����������
//O(n^2+m) m<=n(n-1)

//4
// �������� �������� dist �������� ������ ��������� �������.
//��������� dist[v] ������ � ��� ������, ���� ��� ��� � ����������,
//���� ����� �� u �� v
//���� ��� ���� �� src �� v ����� point �����
//������ �������� �������� dist[Point]
//3
// �������� ������� � ����������� ����������� �� ������
// ������, ������� ��� �� ����������. u ������ �����
// src �� ������ ��������.