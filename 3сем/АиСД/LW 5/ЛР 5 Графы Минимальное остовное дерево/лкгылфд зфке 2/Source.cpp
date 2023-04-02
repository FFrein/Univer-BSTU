#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

#define edge pair<int,int>

class Graph {
private:
    vector<pair<int, edge>> G;
    vector<pair<int, edge>> T;
    int* parent;
    int V; 
public:
    Graph(int V);
    void AddWeightedEdge(int u, int v, int w);
    int find_set(int i);
    void union_set(int u, int v);
    void kruskal();
    void print();
};
Graph::Graph(int V) {
    parent = new int[V];
    for (int i = 0; i < V; i++)
        parent[i] = i;

    G.clear();
    T.clear();
}
void Graph::AddWeightedEdge(int u, int v, int w) {
    G.push_back(make_pair(w, edge(u, v)));
}
int Graph::find_set(int i) {
    if (i == parent[i])
        return i;
    else
        return find_set(parent[i]);
}

void Graph::union_set(int u, int v) {
    parent[u] = parent[v];
}
void Graph::kruskal() {
    int i, uRep, vRep;
    sort(G.begin(), G.end()); 
    for (i = 0; i < G.size(); i++) {
        uRep = find_set(G[i].second.first);
        vRep = find_set(G[i].second.second);
        if (uRep != vRep) {
            T.push_back(G[i]); 
            union_set(uRep, vRep);
        }
    }
}
void Graph::print() {
    int sum = 0;
    for (int i = 0; i < T.size(); i++) {
        cout << T[i].second.first << " -> " << T[i].second.second << " : "
            << T[i].first;
        cout << endl;
        sum += T[i].first;
    }
    cout << "sum: " << sum;
}
int main() {
    Graph g(16);// кол рёбер
    g.AddWeightedEdge(1, 2, 2);
    g.AddWeightedEdge(1, 5, 2);
    g.AddWeightedEdge(1, 4, 8);
    g.AddWeightedEdge(2, 3, 3);
    g.AddWeightedEdge(2, 5, 5);
    g.AddWeightedEdge(2, 4, 10);
    g.AddWeightedEdge(3, 5, 12);
    g.AddWeightedEdge(3, 8, 7);
    g.AddWeightedEdge(4, 5, 14);
    g.AddWeightedEdge(4, 6, 3);
    g.AddWeightedEdge(5, 7, 4);
    g.AddWeightedEdge(5, 8, 8);
    g.AddWeightedEdge(5, 6, 11);
    g.AddWeightedEdge(6, 7, 6);
    g.AddWeightedEdge(7, 8, 9);
    g.AddWeightedEdge(5, 6, 1);
    g.kruskal();
    g.print();
    return 0;
}