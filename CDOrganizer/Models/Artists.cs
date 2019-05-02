using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _artists = new List<Artist>{};
    private string _name;
    private int _id;
    private List<CD> _instances;

    public Artist (string Name)
    {
      _name = Name;
      _artists.Add(this);
      _id = Instances.Count;
      _instances = new List<Artist>{};
    }

    public int ID { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public List<CD> Instances { get => _instances; set => _instances = value; }

    public static void ClearAll()
    {
      _artists.Clear();
    }

    public static List<Artist> GetAll()
    {
      return _artists;
    }

    public static Artist Find(int searchId)
    {
      return _artists[searchId-1];
    }

    public void AddCD(CD cd)
    {
      _artists.Add(cd);
    }

    public List<CD> GetCDs()
    {
      return _instances;
    }

  }
}
