using Ado.net.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ado.net.BLL.Models;
using Microsoft.Data.SqlClient;

namespace Ado.net.BLL
{
    public class AuthorManagercs
    {
        DBManager access = new DBManager();

        public List<Author> Getallauthors()
        {

            List<Author> authors = new List<Author>();
            DataTable dt = access.GetAllAuthors();

            foreach (DataRow dr in dt.Rows)
            {
                Author author = new Author();
                author.au_id = dr["au_id"].ToString();//965-73-8333
                author.au_fname = dr["au_fname"].ToString();
                author.au_lname = dr["au_lname"].ToString();
                author.Phone = dr["Phone"].ToString();
                author.Address = dr["Address"].ToString();
                author.City = dr["City"].ToString();

                authors.Add(author);
           


            }

            return authors;


        }

        public string InsertedAuthors(Author author)
        {

                // Values to insert 
                string auId = author.au_id;
                string lname = author.au_lname;
                string fname = author.au_fname;
                string phone = author.Phone;
                string address = author.Address;
                string city = author.City;
                string state = author.State;
                string zip = author.Zip;
                bool contract = author.Contract;
    
                int result = access.InsertAuthor(auId, lname, fname, phone, address, city, state, zip, contract);
                string ret = "";
                int num_of_authors = Getallauthors().Count();
            if (result == 1)
            {
                return $"1 row Affected , totalauthors = {num_of_authors}";
            }
            else
            {
                return "Failed to insert author.";
            }

        }

        public string DeletedAuthors(string auth_id)
        {
            int result = access.DeleteAuthor(auth_id);
            string ret = "";
            int num_of_authors = Getallauthors().Count();
            if (result == 1)
            {
                return $"1 row Affected , totalauthors = {num_of_authors}";
            }
            else
            {
                return "Failed to delete author.";
            }

        }
    }
}
