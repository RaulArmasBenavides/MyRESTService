using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections;
using System.Text;
using System.IO;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductRESTService" in both code and config file together.
    [ServiceContract]
    public interface IProductRESTService
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET",
            UriTemplate = "GetProductList/",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
       )]
        List<Product> GetProductList();

        [OperationContract]
        [WebInvoke(
           Method = "POST",
           UriTemplate = "UploadImage/",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        string UploadImage(Stream stream);


    }
}

