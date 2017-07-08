#pragma once
#include <vector>
#include "Define.h"
using namespace std;

#ifdef  __cplusplus
extern "C" {
#endif //  __cplusplus
	__declspec(dllexport) class Algorithm
	{
	public:
		static void CreateInstance();
		void DestroyInstance();
		static Algorithm * GetInstance();
		void SetData(const string&);
		vector<int>* GetData();

		//****
		/*
		0 - Insertion sort
		1 - Selection sort
		2 - Bubble sort
		3 - Quick sort
		*/
		//****
		void Sort(const int &, const bool&);

		void InsertionSort(bool (Algorithm::*ptr)(const int&,const int&) const);
		void SelectionSort(bool (Algorithm::*ptr)(const int&, const int&) const);
		void BubbleSort(bool (Algorithm::*ptr)(const int&, const int&) const);
		void QuickSort(bool (Algorithm::*ptr)(const int&, const int&) const);

		bool ASC(const int& a,const int& b) const;
		bool DESC(const int& a, const int& b) const;
	private:
		Algorithm();
		virtual ~Algorithm();
		static Algorithm * m_instance;
		vector<int> *m_data;
	};
#ifdef  __cplusplus
}
#endif //  __cplusplus
