using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
class Categories
{
    [Key]
    public int CategoryId { get; set; }
    [ForeignKey("Users")]
    public int UserId { get; set; }
    public string Name { get; set; }
}