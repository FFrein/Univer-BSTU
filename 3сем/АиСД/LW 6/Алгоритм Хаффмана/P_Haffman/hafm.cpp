#include <iostream>
#include <string>
#include <queue>
#include <unordered_map>
using namespace std;

struct Node
{
	char ch;
	int freq;
	Node* left, * right;
};

Node* getNode(char ch, int freq, Node* left, Node* right)
{
	Node* node = new Node();

	node->ch = ch;
	node->freq = freq;
	node->left = left;
	node->right = right;

	return node;
}

struct comp
{
	bool operator()(Node* l, Node* r)
	{
		return l->freq > r->freq;
	}
};

//проход по дереву  помощью рекурсии
void encode(Node* root, string str, unordered_map<char, string>& huffmanCode)
{
	if (root == nullptr)
		return;
	if (!root->left && !root->right) {
		huffmanCode[root->ch] = str;
	}

	encode(root->left, str + "0", huffmanCode);
	encode(root->right, str + "1", huffmanCode);
}

void buildHuffmanTree(string text)
{
	//ключ-значение (подсчитываем кол символов
	unordered_map<char, int> freq;
	for (char ch : text) {
		freq[ch]++;
	}
	cout << "Letters" << endl;
	unordered_map <char, int> ::iterator it = freq.begin();
	for (int i = 0; it != freq.end(); it++, i++) {  // выводим их
 		cout << it->first << " = " << it->second<< endl;
	}
	cout << endl;

	//начало создания дерева
	priority_queue<Node*, vector<Node*>, comp> pq;
	//создаём самые элементарные узлы
	for (auto pair : freq) {
		pq.push(getNode(pair.first, pair.second, nullptr, nullptr));
	}
	//объединяем узлы
	while (pq.size() != 1)
	{

		Node* left = pq.top(); pq.pop();
		Node* right = pq.top();	pq.pop();

		int sum = left->freq + right->freq;
		pq.push(getNode('\0', sum, left, right));
	}

	Node* root = pq.top();
	//создаём код хаффмана из дерева
	unordered_map<char, string> huffmanCode;
	encode(root, "", huffmanCode);

	cout << "Huffman Codes:\n" << '\n';
	for (auto pair : huffmanCode) {
		cout << pair.first << " " << pair.second << '\n';
	}

	cout << "\nOriginal:\n" << text << '\n';

	//кодируем строку
	string str = "";
	for (char ch : text) {
		str += huffmanCode[ch];
	}

	cout << "\nEncoded string:\n" << str << '\n';
}

int main()
{
	
	string text = "aabbbccdddd";
	buildHuffmanTree(text);

	string text3 = "avram";
	buildHuffmanTree(text3);

	string text2 = "Pesetsky Nikita ANdreevich";
	buildHuffmanTree(text2);

	return 0;
}
