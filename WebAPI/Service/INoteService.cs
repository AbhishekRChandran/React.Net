using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Service
{
    /// <summary>
    /// NoteService interface
    /// </summary>
    public interface INoteService
    {
        /// <summary>
        /// method to add a note.
        /// </summary>
        /// <param name="n">note object</param>
        Note AddNote(Note n);

        /// <summary>
        /// method to getch note by id.
        /// </summary>
        /// <param name="id">note id</param>
        /// <returns>note object</returns>
        Note GetNote(int id);

        /// <summary>
        /// method to fetch all notes.
        /// </summary>
        /// <returns>List of all notes</returns>
        List<Note> GetAllNotes();

        /// <summary>
        /// method to update note.
        /// </summary>
        /// <param name="n">updated note object</param>
        void UpdateNote(int id, Note n);

        /// <summary>
        /// method to detele a note.
        /// </summary>
        /// <param name="id">note id</param>
        void DeleteNote(int id);
    }
}
