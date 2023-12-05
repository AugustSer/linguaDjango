# include <windows.h>    // Подключаем описания функций API, стандартных типов

int WINAPI WinMain (HINSTANCE, HINSTANCE, LPSTR, int)
{
    return MessageBox(NULL, LPCWSTR("Hello, Windows!"), LPCWSTR("First Windows Program"), MB_OK | MB_ICONEXCLAMATION);
}