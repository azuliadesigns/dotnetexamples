/* this ALWAYS GENERATED file contains the definitions for the interfaces */


/* File created by MIDL compiler version 5.01.0164 */
/* at Tue Jul 31 14:51:20 2001
 */
/* Compiler settings for C:\OI\NetCs\Chap14\BankDual\Source\BankDual.idl:
    Oicf (OptLev=i2), W1, Zp8, env=Win32, ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
*/
//@@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 440
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __BankDual_h__
#define __BankDual_h__

#ifdef __cplusplus
extern "C"{
#endif 

/* Forward Declarations */ 

#ifndef __IAccount2_FWD_DEFINED__
#define __IAccount2_FWD_DEFINED__
typedef interface IAccount2 IAccount2;
#endif 	/* __IAccount2_FWD_DEFINED__ */


#ifndef __Account2_FWD_DEFINED__
#define __Account2_FWD_DEFINED__

#ifdef __cplusplus
typedef class Account2 Account2;
#else
typedef struct Account2 Account2;
#endif /* __cplusplus */

#endif 	/* __Account2_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

void __RPC_FAR * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void __RPC_FAR * ); 

#ifndef __IAccount2_INTERFACE_DEFINED__
#define __IAccount2_INTERFACE_DEFINED__

/* interface IAccount2 */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_IAccount2;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("AAA19CDE-C091-47BF-8C96-C80A00989796")
    IAccount2 : public IDispatch
    {
    public:
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Balance( 
            /* [retval][out] */ long __RPC_FAR *pVal) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE Deposit( 
            /* [in] */ long amount) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE Withdraw( 
            /* [in] */ long amount) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IAccount2Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            IAccount2 __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            IAccount2 __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            IAccount2 __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            IAccount2 __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            IAccount2 __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            IAccount2 __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            IAccount2 __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *get_Balance )( 
            IAccount2 __RPC_FAR * This,
            /* [retval][out] */ long __RPC_FAR *pVal);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Deposit )( 
            IAccount2 __RPC_FAR * This,
            /* [in] */ long amount);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Withdraw )( 
            IAccount2 __RPC_FAR * This,
            /* [in] */ long amount);
        
        END_INTERFACE
    } IAccount2Vtbl;

    interface IAccount2
    {
        CONST_VTBL struct IAccount2Vtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IAccount2_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IAccount2_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IAccount2_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IAccount2_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define IAccount2_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define IAccount2_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define IAccount2_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define IAccount2_get_Balance(This,pVal)	\
    (This)->lpVtbl -> get_Balance(This,pVal)

#define IAccount2_Deposit(This,amount)	\
    (This)->lpVtbl -> Deposit(This,amount)

#define IAccount2_Withdraw(This,amount)	\
    (This)->lpVtbl -> Withdraw(This,amount)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IAccount2_get_Balance_Proxy( 
    IAccount2 __RPC_FAR * This,
    /* [retval][out] */ long __RPC_FAR *pVal);


void __RPC_STUB IAccount2_get_Balance_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IAccount2_Deposit_Proxy( 
    IAccount2 __RPC_FAR * This,
    /* [in] */ long amount);


void __RPC_STUB IAccount2_Deposit_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IAccount2_Withdraw_Proxy( 
    IAccount2 __RPC_FAR * This,
    /* [in] */ long amount);


void __RPC_STUB IAccount2_Withdraw_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IAccount2_INTERFACE_DEFINED__ */



#ifndef __BANKDUALLib_LIBRARY_DEFINED__
#define __BANKDUALLib_LIBRARY_DEFINED__

/* library BANKDUALLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_BANKDUALLib;

EXTERN_C const CLSID CLSID_Account2;

#ifdef __cplusplus

class DECLSPEC_UUID("04519632-39C5-4A7E-AA3C-3A7D814AC91C")
Account2;
#endif
#endif /* __BANKDUALLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif
