using System.Collections.Generic;


namespace QueerUni.Models
{
public class Track
{
  public int TrackId { get; set; }
  public int StudentId { get; set; }
  public List<StudentTrack> StudentTracks
  { get; set; }
  public int TrackNumber { get; set; }
  public TrackName TrackName {get; set; }
}

  public enum TrackName
{
  Education = 1,
  Workshop = 2,
  Enrichment = 3
}

}

