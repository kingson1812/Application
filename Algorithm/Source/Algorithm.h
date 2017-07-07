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
	private:
		Algorithm();
		virtual ~Algorithm();
		static Algorithm * m_instance;
		vector<int> *m_data;
	};
#ifdef  __cplusplus
}
#endif //  __cplusplus