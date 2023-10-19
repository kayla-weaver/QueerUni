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

  public bool Track1 { get; set; }
  public bool Track2 { get; set; }
  public bool Track3 { get; set; }

}
}