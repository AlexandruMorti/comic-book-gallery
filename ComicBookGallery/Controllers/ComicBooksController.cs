using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var ComicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Roll = "Script"},
                    new Artist() {Name = "Humberto Ramos", Roll = "Pencils"},
                    new Artist() {Name = "Victor Olazaba", Roll = "Inks"},
                    new Artist() {Name = "Edgar Delgado", Roll = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Roll = "Letters"}
                }
            };

            return View(ComicBook);
        }
    }
}