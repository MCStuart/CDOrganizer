using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class CD
  {
    private static List<CD> _instances = new List<CD> {};
    private string _title;
    private int _id;
    private List<Artist> _artist;

    public CD (string CDTitle)
    {
      _title = title;
      _instances.Add(this);
      _id = instances.Count;
      _artists = new List<Artist>{};
    }

  public string Title { get => _title; set => _title = value; }
  public static List<CD> Instance { get => _instance; set => _instance = value; }
  public int Id { get => _id; set => _id = value; }
  public static List<Artist> Artist { get => _artist; set => _artist; }

  public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<CD> GetAll()
    {
      return _instances;
    }

    public static CD Find(int searchId)
    {
      return _instances[searchId-1];
    }



  }
}
