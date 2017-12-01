﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElevenNoteMobileApp.Models
{
    public class NoteListItemViewModel
    {
        /// <summary>
        /// The notes id on the server.
        /// </summary>
        public int NoteId { get; set; }
        /// <summary>
        /// The notes title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The icon to use when displaying the note.
        /// </summary>
        public string  StarImage { get; set; }
    }

}
