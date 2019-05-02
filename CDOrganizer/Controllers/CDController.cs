using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;

namespace CDOrganizer.Controllers
{
  public class CDController : Controller
  {
    // 
    // [HttpGet("/artists")]
    // public ActionResult Index()
    // {
    //   List<Artist> allCDs = Artist.Instances;
    //   return View(allCDs);
    // }
    //
    // [HttpGet("/artists/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }
    //
    // [HttpPost("/artists")]
    // public ActionResult Create(string artistName)
    // {
    //   Artist newArtist = new Artist(artistName);
    //   List<Artist> allArtists = Artist.GetAll();
    //   return View("Index", allArtists);
    // }
    //
    // [HttpGet("/artists/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Artist selectedArtist = Artist.Find(id);
    //   List<CD> ArtistCDs = selectedArtist.GetCDs();
    //   model.Add("artist", selectedArtist);
    //   model.Add("CDs", ArtistCDs);
    //   return View(model);
    // }
    //
    // // This one creates new CDs within a given Artist, not new Artists:
    // [HttpPost("/artists/{artistId}/CDs")]
    // public ActionResult Create(int artistId, string cdDescription)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Artist foundArtist = Artist.Find(artistId);
    //   CD newCD = new CD(cdDescription);
    //   foundArtist.AddCD(newCD);
    //   List<CD> artistCDs = foundArtist.GetCDs();
    //   model.Add("CDs", artistCDs);
    //   model.Add("artist", foundArtist);
    //   return View("Show", model);
    // }

  }
}
