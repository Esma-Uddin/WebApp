using System;
using WebApp.Models;

namespace WebApp.Repository
{
	public class ContactRepository
	{
		private List<Contact> contacts =
						new List<Contact>()
						{
							new Contact() { ID = 1, Name = "Esma", Surname = "Uddin",img="~\\NewFolder2\\Screenshot 2024-07-17 020954.png" },
							new Contact() { ID = 2, Name = "Mirvari", Surname = "Muradova",img="C:\\Users\\esma\\Desktop\\WebApp\\WebApp\\wwwroot\\NewFolder2\\Screenshot 2024-07-17 020954.png"},
                            new Contact() { ID = 3, Name = "Zehra", Surname = "Malikzada", img = "C:\\Users\\esma\\Desktop\\WebApp\\WebApp\\wwwroot\\NewFolder2\\Screenshot 2024-07-17 020954.png"},
                            new Contact() { ID = 4, Name = "Roya", Surname = "Abbasova", img = "NewFolder2\\Screenshot 2024-07-17 020954.png"},
                        };


		public List<Contact> GetContacts()
		{
			return this.contacts;
		}

		public Contact? GetByID(int ID)
		{
			return this.contacts.FirstOrDefault(c => c.ID == ID);
		}
	}
}

