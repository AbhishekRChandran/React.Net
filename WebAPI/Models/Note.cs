using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    /// <summary>
    /// Note model.
    /// </summary>
    public class Note
    {
        public int Id { get; set; }
        public String Val { get; set; }

        public Note()
        {

        }

        public Note(int id, String value)
        {
            this.Id = id;
            this.Val = value;
        }

    }
}
