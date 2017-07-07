#include "AlgorithmCaller.h"
#include <string>

void CreateAlgorithm()
{
	if(Algorithm::GetInstance()==NULL)
		Algorithm::CreateInstance();
}

E_EXPORT Algorithm * GetAlgorithm()
{
	return Algorithm::GetInstance();
}

E_EXPORT void SetData(char *s)
{
	const string tmp(s);
	Algorithm::GetInstance()->SetData(tmp);
}

E_EXPORT char* GetData()
{
	string *output=new string("");
	vector<int>* v= Algorithm::GetInstance()->GetData();
	if (!v->empty())
	{
		for (int i = 0; i < v->size(); i++)
		{
			output->append(to_string((*v)[i]));
			if (i < v->size() - 1)
			{
				output->append(";");
			}
		}
	}
	return (char*)output->c_str();
}
