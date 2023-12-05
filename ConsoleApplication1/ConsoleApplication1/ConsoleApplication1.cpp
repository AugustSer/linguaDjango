
#include <windows.h>

int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
    return MessageBox(NULL, LPCWSTR("Hello, Windows!"), LPCWSTR("First Windows Program"), MB_OK | MB_ICONEXCLAMATION);
}