using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("categories")]
class Categories
{
    [Key]
    public int CategoryId { get; set; }
    [ForeignKey("Users")]
    public int UserId { get; set; }
    public string Name { get; set; }
}