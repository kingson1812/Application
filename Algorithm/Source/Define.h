#pragma once
#define DEL(a)		if(a!=NULL){delete a;a=NULL;}
#define DEL_ALL(a)	if(a!=NULL){delete[] a;a=NULL;}