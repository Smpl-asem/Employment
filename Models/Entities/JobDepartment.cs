using System.ComponentModel.DataAnnotations;

public class JobDepartment
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Users> Subs { get; set; }
}