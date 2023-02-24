using System.Collections.Generic;
using System.IO;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRESTService.svc or ProductRESTService.svc.cs at the Solution Explorer and start debugging.
    public class ProductRESTService : IProductRESTService
    {
        public List<Product> GetProductList()
        {
            return Products.Instance.ProductList;
        }

        public string UploadImage(Stream stream)
        {
            byte[] buffer = new byte[10000];
            stream.Read(buffer, 0, 10000);
            string path = @"C:\Users\raula\OneDrive - BW2 Technologies AG\Pictures\test\sample.jpg";
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            f.Write(buffer, 0, buffer.Length);
            f.Close();
            stream.Close();
            return "Recieved the image on server";
        }



    }
}
