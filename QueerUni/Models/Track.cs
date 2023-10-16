using System.Collections.Generic;

namespace QueerUni.Models
{
public class Track
{
  public int TrackId { get; set; }
  public int TrackNumber { get; set; }
  public List<Student> Students { get; set; }

  public TrackName TrackName {get; }
}
}
public enum TrackName
{Education = 1, 
Creativity = 2,
Support = 3
}