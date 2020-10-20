using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }
        [Required]
        public Guid OwnerID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Notes")]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
        public int MyID { get; set; }
        public int YourID { get; set; }
        public int MyProperty { get; set; }


    }
}
