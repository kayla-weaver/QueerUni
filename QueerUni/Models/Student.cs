using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QueerUni.Models
{
public class Student
{
  public int StudentId { get; set; }
  public string Name { get; set; }
  [Required(ErrorMessage = "The name space can't be empty!!")]
  public string Email {get; set; }

  public Track Tracks { get; }
}
}

public enum Track
{Track1 = 1, 
Track2= 2,
Track3 = 3
}