using System.ComponentModel.DataAnnotations.Schema;

namespace PrintersBackend.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role role { get; set; }
    }

    public class login_token
    {
        public string token { get; set; }
        public string name { get; set; }
    }
}
