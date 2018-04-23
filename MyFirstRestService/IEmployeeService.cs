﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyFirstRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/EmployeeDetail/{EmpId}",
        RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.Bare)]
        string GetEmployeeSalary(string EmpId);
    }
}
