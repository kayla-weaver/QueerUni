using System.Collections.Generic;


namespace QueerUni.Models
{
public class Track
{
  public int TrackId { get; set; }
  public int TrackNumber { get; set; }
  public string TrackName {get; set; }
  public int StudentId { get; set; }
  public List<StudentTrack> JoinEntities { get; set; }
}
}