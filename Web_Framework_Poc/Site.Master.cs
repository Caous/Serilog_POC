using Microsoft.Extensions.Logging;
using SerilogBase.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Framework_Poc
{
    public partial class SiteMaster : MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e, ILogBase log)
        {
        }

        
    }
}