namespace QueerUni.Models
{

public class CurrentTerm
{
  public int CurrentTermId {get; set;}
  public Course Courses { get; set; }
  public int CourseId { get; set; }
  public Student Student { get; set; }
  public int StudentId { get; set; }
}
}