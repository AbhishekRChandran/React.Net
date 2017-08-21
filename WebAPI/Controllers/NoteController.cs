using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Service;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Notes API Controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/Note")]
    public class NoteController : Controller
    {

        private readonly INoteService _noteService;

        /// <summary>
        /// for injecting noteservice.
        /// </summary>
        /// <param name="noteService"></param>
        public NoteController(INoteService noteService)
        {
            this._noteService = noteService;
        }

        // GET: api/Note
        [HttpGet]
        public IEnumerable<Note> Get()
        {
            Note[] notes = _noteService.GetAllNotes().ToArray();
            return notes;
        }

        // GET: api/Note/5
        [HttpGet("{id}", Name = "Get")]
        public Note Get(int id)
        {
            return _noteService.GetNote(id);
        }
        
        // POST: api/Note
        [HttpPost]
        public Note Post([FromBody]Note value)
        {
            return _noteService.AddNote(value);
        }
        
        // PUT: api/Note/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Note value)
        {
            _noteService.UpdateNote(id, value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _noteService.DeleteNote(id);
        }
    }
}
