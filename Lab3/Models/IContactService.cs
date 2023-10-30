namespace Lab3.Models
{
    public interface IContactService
    {

        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(int id);
        Contact Get(int id);
        List<Contact> FindAll();
    }
}
