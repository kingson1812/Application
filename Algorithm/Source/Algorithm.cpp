#include "Algorithm.h"
#include <sstream>

Algorithm* Algorithm::m_instance = NULL;

Algorithm::Algorithm():m_data(new vector<int>)
{}

Algorithm::~Algorithm()
{}

void Algorithm::CreateInstance()
{
	m_instance = new Algorithm();
}

void Algorithm::DestroyInstance()
{
	DEL_ALL(m_instance);
}

Algorithm * Algorithm::GetInstance()
{
	if (m_instance != NULL)
	{
		return m_instance;
	}
	return NULL;
}

void Algorithm::SetData(const string& data)
{
	stringstream sstream(data);
	string splitValue;
	while (getline(sstream, splitValue, ';'))
	{
		m_data->push_back(stoi(splitValue));
	}
}

vector<int>* Algorithm::GetData()
{
	return m_data;
}
