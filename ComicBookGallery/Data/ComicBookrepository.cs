using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookrepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
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
                },
                Favourite = false
            },
            new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Roll = "Script" },
                    new Artist() { Name = "Marcos Martin", Roll = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Roll = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Roll = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Roll = "Letters" }
                },
                Favourite = false
             },
            new ComicBook()
            {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Roll = "Script" },
                    new Artist() { Name = "Jeff Smith", Roll = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Roll = "Inks" },
                    new Artist() { Name = "Jeff Smith", Roll = "Letters" }
                },
                Favourite = false
                }
            };
        public ComicBook GetComicBook(int id)
        {
            ComicBook ComicBookToReturn = null;

            foreach (var ComicBook in _comicBooks)
            {
                if (ComicBook.id == id)
                {
                    ComicBookToReturn = ComicBook;

                    break;
                }
            }
            return ComicBookToReturn;
        }
    }
}