// BankConsole.cpp 

#include <stdio.h>
#include <stdlib.h>
#include <objbase.h>
#include "bankdual.h"
#include "bankdual_i.c"

IAccount2* g_pAccount;

inline void ShowMessage(char* msg, char* title = "main")
{
	// MessageBox(NULL, msg, title, MB_OK);
	printf("%s\n", msg);
	printf("Enter 'q' to quit: ");
	char buf[10];
	gets(buf);
}

void ShowBalance()
{
	long balance;
	HRESULT hr = g_pAccount->get_Balance(&balance);
	if (FAILED(hr))
	{
		ShowMessage("GetBalance failed"); 
		g_pAccount->Release();
		exit(0);
	}
	printf("balance = %d\n", balance);
}

int main(int argc, char* argv[])
{
	// Initialize COM
	HRESULT hr = CoInitializeEx(NULL, COINIT_APARTMENTTHREADED);
	if (FAILED(hr))
	{
		ShowMessage("CoInitializeEx failed");
		exit(0);
	}

	// Instantiate Account object, obtaining interface pointer
	hr = CoCreateInstance(CLSID_Account2, NULL, CLSCTX_SERVER,
				IID_IAccount2, (void **) &g_pAccount);		
	if (FAILED(hr))
	{
		ShowMessage("CoCreateInstance failed");
		exit(0);
	}

	// First obtain and display initial balance
	ShowBalance();

	// Deposit 25
	hr = g_pAccount->Deposit(25);
	if (FAILED(hr))
	{
		ShowMessage("Deposit failed"); 
		g_pAccount->Release();
		exit(0);
	}

	// Obtain and show balance after deposit
	ShowBalance();


	// Clean up
	g_pAccount->Release();
	CoUninitialize();
	ShowMessage("Done!\n");
	return 0;
}

