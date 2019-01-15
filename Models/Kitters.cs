using System.ComponentModel.DataAnnotations;

namespace kitters.Models
{
  public class Kitter
  {
    [Required]
    public string Name { get; set; }

    [Required]
    public bool IsFemale { get; set; }

    public float Age { get; set; }

    public Kitter(string name, bool isFemale, float age)
    {
      Name = name;
      IsFemale = isFemale;
      Age = age;
    }
  }
}