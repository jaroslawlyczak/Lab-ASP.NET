using System.Xml.Linq;

namespace Lab3.Models
{
    public class MemoryContactService : IContactService
    {

        private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
                { 1, new Contact() { Id = 1, Name = "John Doe", Email = "JohnDoe@gmail.com", Phone = "123456789" } },
                { 2, new Contact() { Id = 2, Name = "Roman ree", Email = "romannn@gmail.com", Phone = "123456789" } }


        };
        
        private int _id = 3;


        public void Add(Contact contact)
        {
            contact.Id = _id++;
            _contacts[contact.Id] = contact;    
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            _contacts.Remove(id);
        }

        public List<Contact> FindAll()
        {
            return _contacts.Values.ToList();
        }

        public Contact? FindById(int id)
        {
            return _contacts[id];
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

