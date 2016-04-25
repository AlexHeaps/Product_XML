using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML_Generator_GUI
{
    //This class is used as the primarily XML generator. 
    class XML_Gen
    {

        public List<Items> items = new List<Items>();
        public XDocument xmlDoc = new XDocument(@"C:\Users\Caroline\Desktop");

        //Method to connect to the Database & Pull information out via SQL query
        public void DBConnect()
        {
            //Database Establishment & Connection
            SqlConnection conn = new SqlConnection("server=localhost" +
                                                   "Trusted_Connection=yes" +
                                                   "database=TestDatabase" +
                                                   "connection timeout=30" +
                                                   "User ID=username" +
                                                   "Password=password");

            SqlCommand sqlQuery = new SqlCommand();
            SqlDataReader reader;

            //SQL Query. Can be modified quite easily. 
            //TODO: Since adding SQL Server Compact/SQLite Toolbox, there's been a new syntax on querying;
            //      Here's an example:
            /*
                try
                {
                    using (SqlCeConnection cn = new SqlCeConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString()))
                    {
                        SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Customers", cn);
                        cn.Open();
                        SqlCeDataReader reader1 = cmd.ExecuteReader();
                        while (reader1.Read())
                        {
                            Console.WriteLine(reader1[0] + " | " + reader1[1] + " | " + reader1[2] + " | " + reader1[3] + " | " + reader1[4]);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Reading from myDB: " + ex.Message);
                    return;
                }
            */
            
            sqlQuery.CommandText = "SELECT * FROM Person WHERE ROWNUM = 1";
            sqlQuery.CommandType = CommandType.Text;
            sqlQuery.Connection = conn;

            //Attempts to connect to DB & Pull data. 
            try
            {
                conn.Open();
                Console.WriteLine("Successful connection");
                reader = sqlQuery.ExecuteReader();

                //Loop to pull data from single line of text and create String objects of each cell
                while (reader.Read())
                {

                    Items item = new Items();
                    item.name = (reader["Name"].ToString());
                    item.phone = (reader["Phone"].ToString());

                    Name.Text = (reader["Name"].ToString());
                    Phone.Text = (reader["Phone"].ToString());
                    Address.Text = (reader["Address"].ToString());
                    Street1.Text = (reader["Street1"].ToString());
                    City.Text = (reader["City"].ToString());
                    State.Text = (reader["State"].ToString());
                    PostCode.Text = (reader["PostCode"].ToString());


                    items.Add(item);
                }
            }

            //Error handling for bad connection
            //TODO: Error handling for all possible cases
            catch(SqlException)
            {
                Console.WriteLine("Unsuccessful connection");
            }
            finally
            {
                conn.Close();
            }
            
        }

        //Method to generate XML body. Uses XElement, which is a XML-Linq method.
        //TODO: Get this working with XML DocGen (uses XmlDocument API)
        public void XMLBodyGen()
        {


        
            foreach (Items item in items) {
                XElement name = new XElement("Name");
                name.Add(new XAttribute("name", item.name));
                xmlDoc.Element("Name").Add(name);


                xmlDoc.Root.Add(
                new XElement("Phone",
                    new XAttribute("name", "name goes here"),
                    new XElement("phone", item.name))
                );


                xmlDoc.Save(@"C:\TEMP\FOO.XML");

            }


            XElement contacts =
                new XElement("Contacts",
                    new XElement("Contact",
                        new XElement("Name", ""),
                        new XElement("Phone", ""),
                        new XElement("Address",
                            new XElement("Street1", ""),
                            new XElement("City", ""),
                            new XElement("State", ""),
                            new XElement("PostCode", "")
                        )
                    )
                ); 
        }

        //Method to take XMLBodyGen and create an XML document from this
        //TODO: Get this working with XMLBodyGen
        public void XMLDocGen()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(XMLBodyGen);
            xdoc.Save("test.xml");
        }
    }

    class Items
    {
        public string name;
        public string phone;

    }

}
