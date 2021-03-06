#include "pch.h"
#include <iostream>
#include <vector> 
#include <string> 
#include <conio.h>
#include <stdlib.h>
#include <cctype>
#include <sstream>
#include <cmath>
using namespace std;

void PodzialDzialaniaNaElementy(string WyrazenieMatematyczne, int Dlugosc, vector <double> &TablicaLiczb, vector <char> &TablicaZnakow)
{
	int i = 0;
	string liczby; 
	for (i = 0; i < Dlugosc; i++)
	{
		if (isdigit(WyrazenieMatematyczne[i]) || WyrazenieMatematyczne[i] == '.' || WyrazenieMatematyczne[i] == ',')
		{
			liczby = liczby + WyrazenieMatematyczne[i];
		}
		else if (WyrazenieMatematyczne[i] == '(' || WyrazenieMatematyczne[i] == ')')
		{
			TablicaZnakow.push_back(WyrazenieMatematyczne[i]);
		}
		else
		{
			TablicaLiczb.push_back(atof(liczby.c_str()));
			liczby = "";
			TablicaZnakow.push_back(WyrazenieMatematyczne[i]);
		}
		if (i == (Dlugosc - 1))
		{
			TablicaLiczb.push_back(atof(liczby.c_str()));
		}
	}
}

void Dodawanie(vector <double> &TablicaLiczb, vector <char> &TablicaZnakow, int &a)
{
	TablicaLiczb[a] = TablicaLiczb[a] + TablicaLiczb[a + 1];
	TablicaLiczb.erase(TablicaLiczb.begin() + a + 1);
	TablicaZnakow.erase(TablicaZnakow.begin() + a);
	a--;
}

void Odejmowanie(vector <double> &TablicaLiczb, vector <char> &TablicaZnakow, int &a)
{
	TablicaLiczb[a] = TablicaLiczb[a] - TablicaLiczb[a + 1];
	TablicaLiczb.erase(TablicaLiczb.begin() + a + 1);
	TablicaZnakow.erase(TablicaZnakow.begin() + a);
	a--;
}

void Mnozenie(vector <double> &TablicaLiczb, vector <char> &TablicaZnakow, int &a)
{
	TablicaLiczb[a] = TablicaLiczb[a] * TablicaLiczb[a + 1];
	TablicaLiczb.erase(TablicaLiczb.begin() + a + 1);
	TablicaZnakow.erase(TablicaZnakow.begin() + a);
	a--;
}

void Dzielenie(vector <double> &TablicaLiczb, vector <char> &TablicaZnakow, int &a)
{
	TablicaLiczb[a] = TablicaLiczb[a] / TablicaLiczb[a + 1];
	TablicaLiczb.erase(TablicaLiczb.begin() + a + 1);
	TablicaZnakow.erase(TablicaZnakow.begin() + a);
	a--;
}

void Potegowanie(vector <double> &TablicaLiczb, vector <char> &TablicaZnakow, int &a)
{
	TablicaLiczb[a] = pow(TablicaLiczb[a], TablicaLiczb[a + 1]);
	TablicaLiczb.erase(TablicaLiczb.begin() + a + 1);
	TablicaZnakow.erase(TablicaZnakow.begin() + a);
	a--;
}

void Nawias(vector <double> &TablicaLiczb, vector <char> &TablicaZnakow, int &a, int &znak)
{
	int l = a;
	int znaki = a;
	TablicaZnakow.erase(TablicaZnakow.begin() + a);
	znak--;

	for (int i = a; TablicaZnakow[i] != ')'; i++)
	{
		znaki++;
	}

	while (l < znaki)
	{
		if (TablicaZnakow[l] == '^')
		{
			Potegowanie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
			znak--;
		}
		l++;
	}

	l = a;
	while (l < znaki)
	{
		if (TablicaZnakow[l] == '*')
		{
			Mnozenie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
			znak--;
		}
		else if (TablicaZnakow[l] == '/')
		{
			Dzielenie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
			znak--;
		}
		l++;
	}
	l = a;
	while (l < znaki)
	{
		if (TablicaZnakow[l] == '+')
		{
			Dodawanie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
			znak--;
		}
		else if (TablicaZnakow[l] == '-')
		{
			Odejmowanie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
			znak--;
		}
		l++;
	}
	TablicaZnakow.erase(TablicaZnakow.begin() + l);
}

int main()
{
	string WyrazenieMatematyczne;
	vector < double > TablicaLiczb;
	vector < char > TablicaZnakow;
	int Dlugosc;

	cin >> WyrazenieMatematyczne;
	Dlugosc = WyrazenieMatematyczne.size();

	PodzialDzialaniaNaElementy(WyrazenieMatematyczne, Dlugosc, TablicaLiczb, TablicaZnakow);

	int znaki = TablicaZnakow.size();
	int l = 0;

	while (l < znaki)
	{
		if (TablicaZnakow[l] == '(')
		{
			Nawias(TablicaLiczb, TablicaZnakow, l, znaki);
			znaki--;
		}
		l++;
	}
	l = 0;

	while (l < znaki)
	{
		if (TablicaZnakow[l] == '^')
		{
			Potegowanie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
		}
		l++;
	}

	l = 0;
	while (l < znaki)
	{
		if (TablicaZnakow[l] == '*')
		{
			Mnozenie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
		}
		else if (TablicaZnakow[l] == '/')
		{
			Dzielenie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
		}
		l++;
	}
	l = 0;
	while (l < znaki)
	{
		if (TablicaZnakow[l] == '+')
		{
			Dodawanie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
		}
		else if (TablicaZnakow[l] == '-')
		{
			Odejmowanie(TablicaLiczb, TablicaZnakow, l);
			znaki--;
		}
		l++;
	}

	cout << "Wynik podanego dzialania to: " << TablicaLiczb[0];
}