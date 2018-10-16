// COMInteropUnmanagedClient.cpp
#include "stdafx.h"
#import "C:\Documents and Settings\Administrator.SOFTECH125\Desktop\share\CallFromCOM\DotNetComponent\DotNetComponent\bin\Debug\DotNetComponent.tlb" raw_interfaces_only
using namespace DotNetComponent;
int main(int argc, char* argv[])
{
    HRESULT hr = CoInitialize(NULL);
    IFooPtr pIFoo(__uuidof(Foo));
	long result;
    hr = pIFoo->AddEmUp(3, 4, &result);
    printf("result: %d\n", result);
    CoUninitialize();
    return 0;
}