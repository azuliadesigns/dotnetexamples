using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DotNetComponent
{
    //[Guid("D6F88E95-8A27-4ae6-B6DE-0542A0FC7039")]
	//[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IFoo
    {
        //[DispId(1)]
        int AddEmUp(int x, int y);
    }
    //[Guid("13FE32AD-4BF8-495f-AB4D-6C61BD463EA4")]
    //[ClassInterface(ClassInterfaceType.None)]
    //[ProgId("DotNetComponent.Foo")]
    public class Foo : IFoo
    {
        public Foo(){}
        public int AddEmUp(int x, int y)
        {
            return x + y;
        }
    }
}
