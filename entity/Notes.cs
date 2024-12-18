using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("notes")]
class Notes
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Users")]
    public int UserId { get; set; }
    [ForeignKey("Categories")]
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}