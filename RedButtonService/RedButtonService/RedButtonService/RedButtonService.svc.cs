using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RedButtonService
{
    public class RedButtonService : IRedButtonService
    {
        public string ExecuteRedButton() {
            try {



                return "SUCCESS";
            }
            catch(Exception ex ) {
                return ex.Message;
            }
        }
    }
}
