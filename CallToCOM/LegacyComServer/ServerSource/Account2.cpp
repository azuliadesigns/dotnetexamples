// Account2.cpp : Implementation of CAccount2
#include "stdafx.h"
#include "BankDual.h"
#include "Account2.h"

/////////////////////////////////////////////////////////////////////////////
// CAccount2


STDMETHODIMP CAccount2::get_Balance(long *pVal)
{
	*pVal = m_nBalance;
	return S_OK;
}

STDMETHODIMP CAccount2::Deposit(long amount)
{
	m_nBalance += amount;
	return S_OK;
}

STDMETHODIMP CAccount2::Withdraw(long amount)
{
	m_nBalance -= amount;
	return S_OK;
}
