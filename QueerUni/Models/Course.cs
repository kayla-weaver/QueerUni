using System.Collections.Generic;

namespace QueerUni.Models
{
public class Course
{
  public int CourseId { get; set; }
  public string CourseName { get; set; }
  public int CourseNumber { get; set; }
  public List<Student> Students { get; set; }
  public List<CurrentTerm> JoinEntities {get;}
}
}