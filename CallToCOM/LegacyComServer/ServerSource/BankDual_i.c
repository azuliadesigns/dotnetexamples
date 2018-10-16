/* this file contains the actual definitions of */
/* the IIDs and CLSIDs */

/* link this file in with the server and any clients */


/* File created by MIDL compiler version 5.01.0164 */
/* at Tue Jul 31 14:51:20 2001
 */
/* Compiler settings for C:\OI\NetCs\Chap14\BankDual\Source\BankDual.idl:
    Oicf (OptLev=i2), W1, Zp8, env=Win32, ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
*/
//@@MIDL_FILE_HEADING(  )
#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

const IID IID_IAccount2 = {0xAAA19CDE,0xC091,0x47BF,{0x8C,0x96,0xC8,0x0A,0x00,0x98,0x97,0x96}};


const IID LIBID_BANKDUALLib = {0x8B8AC8EE,0x8E4B,0x4CFA,{0xB6,0x45,0x80,0x6E,0x7D,0xBD,0x0C,0xF5}};


const CLSID CLSID_Account2 = {0x04519632,0x39C5,0x4A7E,{0xAA,0x3C,0x3A,0x7D,0x81,0x4A,0xC9,0x1C}};


#ifdef __cplusplus
}
#endif

