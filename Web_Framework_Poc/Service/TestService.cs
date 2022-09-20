using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Framework_Poc.Service
{
    public class TestService 
    {
        public TestService(string myProperty)
        {
            MyProperty = myProperty;
        }
        public string MyProperty { get; set; }
    }
}