#pragma once
#include "Algorithm.h"
#define E_EXPORT extern __declspec(dllexport)

#ifdef __cplusplus
extern "C" {
#endif
	E_EXPORT void CreateAlgorithm();
	E_EXPORT Algorithm* GetAlgorithm();
	E_EXPORT void SetData(char *s);
	E_EXPORT char* GetData();
	E_EXPORT void Sort(int, bool asc = true);

#ifdef __cplusplus
}
#endif
