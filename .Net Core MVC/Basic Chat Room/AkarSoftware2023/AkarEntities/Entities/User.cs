using AkarEntities.Abstract;

namespace AkarEntities.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public  string UserPhoto { get; set; }
    }
}
