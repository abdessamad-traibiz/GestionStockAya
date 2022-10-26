using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionStock.Pages.Clients
{
    public class ClientsModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();
        public void OnGet()
        {
            // connection vers la base de données
            try
            {
                string connectionString = "Data Source=DELL\\Abdes; Initial Catalog=GestionStockDB; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string sql = "select * from Table";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ClientInfo clientinf = new ClientInfo();
                    clientinf.id = rd.GetInt32(0);
                    clientinf.name = rd.GetString(1);
                    clientinf.email = rd.GetString(2);
                    clientinf.telephone = rd.GetString(3);
                    clientinf.adresse = rd.GetString(4);
                    listClients.Add(clientinf);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.ToString());
            }
        }
    }
    public class ClientInfo
    {
        public int id;
        public string name;
        public string email;
        public string telephone;
        public string adresse;
    }
}