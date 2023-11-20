using bajki.Models;

namespace bajki.Services
{
    public class TaleServices : ITaleServices
    {
        protected readonly MyDbContext _db;

        public List<Tale> getTales(MyDbContext db)
        {
            return db.Tales.ToList();
        }
    }
}
