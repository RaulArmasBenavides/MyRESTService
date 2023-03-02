using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using wcfrestservice.erpmak.entity;

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
           UriTemplate = "UploadImage",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        string UploadImage(Stream stream);

        [OperationContract]
        [WebGet(UriTemplate = "/Appellants", ResponseFormat = WebMessageFormat.Json)]
        Appellant[] GetAppellant();
        [OperationContract]
        [WebGet(UriTemplate = "/AppellantsXML", ResponseFormat = WebMessageFormat.Xml)]
        Appellant[] GetAppellantXML();
        [OperationContract]
        [WebGet(UriTemplate = "/Appellant?id={id}", ResponseFormat = WebMessageFormat.Json)]
        Appellant[] GetAppellantStatus(string id);
        [OperationContract]
        [WebGet(UriTemplate = "/AppellantXML?id={id}", ResponseFormat = WebMessageFormat.Xml)]
        Appellant[] GetAppellantStatusXML(string id);

    }
}

