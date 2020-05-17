using basic_element_database.Elements;
using basic_element_database.Repository;
using basic_element_database.Repository.Interfaces;

namespace basic_element_database.Respository
{
    public class ElementRepository:RepositoryBase<Element>,IRepositoryBase<Element>
    {
        public ElementRepository(BasicElementDbContext context):base(context)
        {

        }
    }
}
