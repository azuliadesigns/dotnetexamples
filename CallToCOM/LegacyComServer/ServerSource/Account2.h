// Account2.h : Declaration of the CAccount2

#ifndef __ACCOUNT2_H_
#define __ACCOUNT2_H_

#include "resource.h"       // main symbols

/////////////////////////////////////////////////////////////////////////////
// CAccount2
class ATL_NO_VTABLE CAccount2 : 
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CAccount2, &CLSID_Account2>,
	public IDispatchImpl<IAccount2, &IID_IAccount2, &LIBID_BANKDUALLib>
{
public:
	CAccount2() : m_nBalance(150)
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_ACCOUNT2)

DECLARE_PROTECT_FINAL_CONSTRUCT()

BEGIN_COM_MAP(CAccount2)
	COM_INTERFACE_ENTRY(IAccount2)
	COM_INTERFACE_ENTRY(IDispatch)
END_COM_MAP()

// IAccount2
public:
	STDMETHOD(Withdraw)(/*[in]*/ long amount);
	STDMETHOD(Deposit)(/*[in]*/ long amount);
	STDMETHOD(get_Balance)(/*[out, retval]*/ long *pVal);
protected:
	long m_nBalance;
};



#endif //__ACCOUNT2_H_
