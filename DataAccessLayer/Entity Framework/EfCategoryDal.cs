using DataAccessLayer.Abstract;
using DataAccessLayer.Conrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity_Framework
{
    public class CategoryDal: Repository<Category>, ICategoryDal
    {
    }
}
