using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QueerUni.Models
{
public class Student
{
  public int StudentId { get; set; }
  public string Name { get; set; }
  [Required(ErrorMessage = "The name space can't be empty!!")]
  public int PhoneNumber {get; set; }
  public Course Course  { get; set; }

  public Major Major { get; set; }
  public List<CurrentTerm> JoinEntities { get; }
}
}

public enum Major
{ArtHistory = 1, 
Engineering = 2,
ComputerScience = 3,
CyberSecurity = 4,
EnvironmentalScience = 5,
Law = 6,
Medical = 7
}