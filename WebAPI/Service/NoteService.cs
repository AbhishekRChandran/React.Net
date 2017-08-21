using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Service
{
    /// <summary>
    /// Note service implementataion.
    /// </summary>
    public class NoteService : INoteService
    {

        /// <summary>
        /// static content for testing.
        /// </summary>
        private static Dictionary<int, Note> _db;
        private static int _id;

        static NoteService()
        {
            _db = new Dictionary<int, Note>
            {
                { 1, new Note(1, "hello1") },
                { 2, new Note(2, "hello2") },
                { 3, new Note(3, "hello3") },
                { 4, new Note(4, "hello4") }
            };
            _id = 4;
        }

        /// <summary>
        /// method to add a note.
        /// </summary>
        /// <param name="n">note object</param>
        public Note AddNote(Note n)
        {
            n.Id = this.GetNextId();
            _db.Add(n.Id, n);
            return n;
        }

        /// <summary>
        /// method to detele a note.
        /// </summary>
        /// <param name="id">note id</param>
        public void DeleteNote(int id)
        {
            if(_db.TryGetValue(id, out Note n))
                _db.Remove(id);
        }

        /// <summary>
        /// method to fetch all notes.
        /// </summary>
        /// <returns>List of all notes</returns>
        public List<Note> GetAllNotes()
        {
            return _db.Values.ToList<Note>();
        }

        /// <summary>
        /// method to getch note by id.
        /// </summary>
        /// <param name="id">note id</param>
        /// <returns>note object</returns>
        public Note GetNote(int id)
        {
            if (_db.TryGetValue(id, out Note n))
                return n;
            else
                return null;
        }

        /// <summary>
        /// method to update note.
        /// </summary>
        /// <param name="n">updated note object</param>
        public void UpdateNote(int id, Note n)
        {
            _db[id] =  n;
        }

        /// <summary>
        /// method for id generation.
        /// </summary>
        /// <returns></returns>
        private int GetNextId()
        {
            return ++_id;
        }
    }
}
