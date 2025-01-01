using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
class User
{
    [Key]
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public ICollection<Category> Category { get; set; }
    public ICollection<Notes> Notes { get; set; }
}