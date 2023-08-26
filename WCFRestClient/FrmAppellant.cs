using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using wcfrestservice.erpmak.entity;

namespace WCFRestClient
{
    public partial class FrmAppellant : Form
    {
        public FrmAppellant()
        {
            InitializeComponent();
        }

        /*
          Here if the class Appellant has another namespace it will not work...
          that's why I reuse the wcfrestservice.erpmak.entity.
          Another idea would be just to add the assembly as a reference ( only the dll file)   
          HttpWebRequest is obsolete.Use WebRequest for Net Framework better
         */


        private void button4_Click(object sender, EventArgs e)
        {
            this.dgvAppellants.DataSource = null;
        }

    
 
        private void btnJSON_Click(object sender, EventArgs e)
        {
            this.dgvAppellants.DataSource = null;
            try
            {
                string serviceUrl = "http://localhost:17476/ProductRESTService.svc/Appellants";
                HttpWebRequest request = WebRequest.Create(serviceUrl) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        var jsonData = reader.ReadToEnd().ToString();
                        List<Appellant> listCandidates = new
                        JavaScriptSerializer().Deserialize<List<Appellant>>(jsonData);
                        dgvAppellants.DataSource = listCandidates;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnPOX_Click(object sender, EventArgs e)
        {
            this.dgvAppellants.DataSource = null;
            try
            {
                string serviceUrl = "http://localhost:17476/ProductRESTService.svc/AppellantsXML";
                WebRequest request = WebRequest.Create(serviceUrl);
                WebResponse response = request.GetResponse();
                DataContractSerializer collectionData = new DataContractSerializer(typeof(Appellant[]));
                var arrayAppeal = collectionData.ReadObject(response.GetResponseStream());
                dgvAppellants.DataSource = arrayAppeal as Appellant[];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
