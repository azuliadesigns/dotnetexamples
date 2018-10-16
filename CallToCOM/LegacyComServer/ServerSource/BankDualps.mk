
BankDualps.dll: dlldata.obj BankDual_p.obj BankDual_i.obj
	link /dll /out:BankDualps.dll /def:BankDualps.def /entry:DllMain dlldata.obj BankDual_p.obj BankDual_i.obj \
		kernel32.lib rpcndr.lib rpcns4.lib rpcrt4.lib oleaut32.lib uuid.lib \

.c.obj:
	cl /c /Ox /DWIN32 /D_WIN32_WINNT=0x0400 /DREGISTER_PROXY_DLL \
		$<

clean:
	@del BankDualps.dll
	@del BankDualps.lib
	@del BankDualps.exp
	@del dlldata.obj
	@del BankDual_p.obj
	@del BankDual_i.obj
