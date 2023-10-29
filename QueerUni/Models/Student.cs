using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QueerUni.Models
{
public class Student
{
  public int StudentId { get; set; }
  [Required(ErrorMessage = "Your name space can't be empty!!")]
  public string Name { get; set; }
  [Required(ErrorMessage = "Your email can't be empty!!")]
  public string Email {get; set; }

  public List<StudentTrack> JoinEntities { get; set; }
  public ApplicationUser User { get; set; }
  public Track Track{ get; set; }
}


}