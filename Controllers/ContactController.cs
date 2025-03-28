using AEB_demo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AEB_demo.Models.Helpers; // Import the Helpers namespace

namespace AEB_demo.Controllers
{
    public class ContactController : Controller
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=ContactForm;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        // GET: Contact
        public ActionResult Index()
        {
            return View(new ContactModel());
        }

        [HttpPost]
        public ActionResult Submit(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString)) // Using the global helper class
                    {
                        string query = "INSERT INTO Contacts (FullName, ContactNumber, EmailAddress, Address, Interest, Message, Country) " +
                                       "VALUES (@FullName, @ContactNumber, @EmailAddress, @Address, @Interest, @Message, @Country)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@FullName", model.FullName);
                            cmd.Parameters.AddWithValue("@ContactNumber", model.ContactNumber);
                            cmd.Parameters.AddWithValue("@EmailAddress", model.EmailAddress);
                            cmd.Parameters.AddWithValue("@Address", model.Address);
                            cmd.Parameters.AddWithValue("@Interest", model.Interest);
                            cmd.Parameters.AddWithValue("@Message", (object)model.Message ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Country", model.Country);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    ViewBag.Message = "Your contact information has been submitted successfully!";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error: " + ex.Message;
                }
            }

            return View("Contact");
        }
    }
}