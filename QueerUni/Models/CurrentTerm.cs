namespace QueerUni.Models
{

public class CurrentTerm
{
  public Course Courses { get; set; }
  public int CourseId { get; set; }
  public Student Student { get; set; }
  public int StudentId { get; set; }
}
}