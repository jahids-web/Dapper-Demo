using System.ComponentModel.DataAnnotations;

namespace Dapper_Demo.Entities
{
    public class Users
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
