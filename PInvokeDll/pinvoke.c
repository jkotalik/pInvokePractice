#include "pinvoke.h"
#include <stdlib.h>
#include <string.h>
#include <stdio.h>

extern PINVOKE_EXPORTS int _stdcall callback_check(int a, callback_struct cs) {
	printf("hello");
	cs(a, 5);
	return 1;
}