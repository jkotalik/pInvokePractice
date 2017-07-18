#ifdef PINVOKE_EXPORTS
#define PINVOKE_EXPORTS __declspec(dllexport)
#else
#define PINVOKE_EXPORTS __declspec(dllimport)
#endif

typedef void(_stdcall *callback_struct)(int a, int b);

extern PINVOKE_EXPORTS int callback_check(int a, callback_struct callback);