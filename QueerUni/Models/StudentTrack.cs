using System.Collections.Generic;

namespace QueerUni.Models;

public class StudentTrack
{
  public int StudentTrackId { get; set; }

  public Student Student{ get; set; }

  public int StudentId{ get; set; }

  public Track Track { get; set; }

  public int TrackId{ get; set; }
}