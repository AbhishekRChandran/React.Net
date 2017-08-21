using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAPI.Models;
using WebAPI.Service;


namespace WebAPI.Test.Service
{
    [TestFixture]
    public class NoteServiceTest
    {
        [Test]
        public void GetNotes()
        {
            INoteService noteService = new NoteService();
            List<Note> notes = noteService.GetAllNotes();
            Assert.That(notes.Count > 0);
        }
    }
}
