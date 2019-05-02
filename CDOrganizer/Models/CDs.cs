using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class CD
  {
    private string _title;
    private int _id;
    private static List<CD> _instances = new List<CD> {};

    public CD (string title)
    {
      _title = title;
      _instances.Add(this);
      _id = Instances.Count;
    }

    public string title { get => _title; set => _title = value; }
    private int ID { get => _id; set => _id = value; }
    public static List<CD> Instances { get => _instances; set => _instances = value; }

    public static List<CD> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static CD Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<CD> GetCDs()
    {
      return _instances;
    }

  }
}
