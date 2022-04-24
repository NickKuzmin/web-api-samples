using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities
{
    [Table("person", Schema = "dbo")]
    public class Person
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("fullname")]
        public string FullName { get; set; }
    }
}
