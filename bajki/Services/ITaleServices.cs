using bajki.Models;

namespace bajki.Services
{
    public interface ITaleServices
    {
        public List<Tale> getTales(MyDbContext db);


    }
}
