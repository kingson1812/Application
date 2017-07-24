#include "Algorithm.h"
#include <sstream>

Algorithm* Algorithm::m_instance = NULL;

bool Algorithm::ASC(const int & a, const int & b) const
{
	return a > b;
}

bool Algorithm::DESC(const int & a, const int & b) const
{
	return a < b;
}

const char * Algorithm::GetProcessData()
{
	return m_process.c_str();
}

Algorithm::Algorithm() :m_data(new vector<int>)
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
	if (!m_data->empty())
		m_data->clear();
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

void Algorithm::Sort(const int &option, const bool& asc)
{
	bool (Algorithm::*ptr)(const int&, const int&) const = asc ? &Algorithm::ASC : &Algorithm::DESC;
	m_process.clear();
	switch (option)
	{
	case 0:
		InsertionSort(ptr);
		break;
	case 1:
		SelectionSort(ptr);
		break;
	case 2:
		BubbleSort(ptr);
		break;
	case 3:
		QuickSort(ptr);
		break;
	default:
		break;
	}
}

void Algorithm::InsertionSort(bool (Algorithm::*ptr)(const int&, const int&) const)
{
	for (int i = 1; i < m_data->size(); i++)
	{
		//Hold current index and value to compare
		int index = i;
		int value = (*m_data)[i];

		//Append all step to string process and then send to C#
		m_process.append("{").append(to_string(i)).append("}");
		
		//Compare value with previous values
		while (index > 0 && (Algorithm::GetInstance()->*ptr)((*m_data)[index-1], value))
		{
			m_process.append("[").append(to_string(index)).append("]").append("<swap>");
			(*m_data)[index] = (*m_data)[index - 1];
			index--;
		}
		//If value change, that means index change, allocate new index for value
		if ((*m_data)[index] != value)
		{
			(*m_data)[index] = value;
			m_process.append("[").append(to_string(index)).append("]").append("<place>");
		}
		else
		{
			m_process.append("<noswap>");
		}
		m_process.append(";");
	}
}

void Algorithm::SelectionSort(bool(Algorithm::*ptr)(const int&, const int&) const)
{
}

void Algorithm::BubbleSort(bool(Algorithm::*ptr)(const int&, const int&) const)
{
}

void Algorithm::QuickSort(bool(Algorithm::*ptr)(const int&, const int&) const)
{
}
