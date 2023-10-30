using System.Xml.Linq;

namespace Lab3.Models
{
    public class MemoryContactService : IContactService
    {

        private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
                { 1, new Contact() { ID = 1, Name = "John Doe", Email = "" } } };
        

        

        public void Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> FindAll()
        {
            throw new NotImplementedException();
        }

        public Contact Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
   
}

