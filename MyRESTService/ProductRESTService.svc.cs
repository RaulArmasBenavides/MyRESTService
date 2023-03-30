using MyRESTService.BusinessLogic.AbstractFactory;
using MyRESTService.BusinessLogic.Concretions;
using MyRESTService.BusinessLogic.Factory_Method;
using System.Collections.Generic;
using System.IO;
using wcfrestservice.erpmak.entity;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRESTService.svc or ProductRESTService.svc.cs at the Solution Explorer and start debugging.
    public class ProductRESTService : IProductRESTService
    {
        IAbstractFactory _absfactory;
        Creator _absCreator;
        ProductRESTService()
        {
            _absCreator = new ConcreteCreator1();
            _absfactory = new ConcreteFactory1();
        }

        public List<Product> GetProductList()
        {
            return Products.Instance.ProductList;
        }

        public Appellant[] GetAppellant()
        {
            return new Appellant[]
            {
                 new Appellant() {ID = 1, Name = "Bob Jones", AppealStatus = "Approved", StatusDate =
                "1/21/2012" },
                 new Appellant() {ID = 2, Name = "Bonnie Smith", AppealStatus = "Disapproved",
                StatusDate = "2/23/2012"},
                 new Appellant() {ID = 3, Name = "Dolly Smith", AppealStatus = "Processing", StatusDate
                = "N/A"}
            };
        }
        public Appellant[] GetAppellantXML()
        {
            return new Appellant[]
            {
                 new Appellant() {ID = 1, Name = "Bob Jones", AppealStatus = "Approved", StatusDate =
                "1/21/2012" },
                 new Appellant() {ID = 2, Name = "Bonnie Smith", AppealStatus = "Disapproved",
                StatusDate = "2/23/2012"},
                 new Appellant() {ID = 3, Name = "Dolly Smith", AppealStatus = "Processing", StatusDate
                = "N/A"}
            };
        }
        public Appellant[] GetAppellantStatus(string id)
        {
            Appellant appellant = new Appellant();
            if (id == "1")
            {
                appellant.ID = 1;
                appellant.Name = "Bob Jones";
                appellant.AppealStatus = "Approved";
                appellant.StatusDate = "1/21/2012";
            }
            else if (id == "2")
            {
                appellant.ID = 2;
                appellant.Name = "Bonnie Smith";
                appellant.AppealStatus = "Disapproved";
                appellant.StatusDate = "2/23/2012";
            }
            else if (id == "3")
            {
                appellant.ID = 3;
                appellant.Name = "Dolly Smith";
                appellant.AppealStatus = "Processing";
                appellant.StatusDate = "N/A";
            }
            else
            {
                appellant.ID = 0;
                appellant.Name = string.Empty;
                appellant.AppealStatus = string.Empty;
                appellant.StatusDate = string.Empty;
            }
            return new Appellant[]
            {
                 new Appellant() {ID = appellant.ID,
                 Name = appellant.Name,
                 AppealStatus = appellant.AppealStatus,
                 StatusDate = appellant.StatusDate }
            };
        }
        public Appellant[] GetAppellantStatusXML(string id)
        {
            Appellant appellant = new Appellant();
            if (id == "1")
            {
                appellant.ID = 1;
                appellant.Name = "Bob Jones";
                appellant.AppealStatus = "Approved";
                appellant.StatusDate = "1/21/2012";
            }
            else if (id == "2")
            {
                appellant.ID = 2;
                appellant.Name = "Bonnie Smith";
                appellant.AppealStatus = "Disapproved";
                appellant.StatusDate = "2/23/2012";
            }
            else if (id == "3")
            {
                appellant.ID = 3;
                appellant.Name = "Dolly Smith";
                appellant.AppealStatus = "Processing";
                appellant.StatusDate = "N/A";
            }
            else
            {
                appellant.ID = 0;
                appellant.Name = string.Empty;
                appellant.AppealStatus = string.Empty;
                appellant.StatusDate = string.Empty;
            }
            return new Appellant[]
            {
                 new Appellant() {ID = appellant.ID,
                 Name = appellant.Name,
                 AppealStatus = appellant.AppealStatus,
                 StatusDate = appellant.StatusDate }
            };
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
