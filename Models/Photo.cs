using System;
using System.Collections.Generic;
using System.Text;

namespace FlatmateFinders.Models
{
    //Model For Photos Page

    public class Photo
    {
        public string Name { get; set; }
        public int Rotate { get; set; }
        public bool Featured { get; set; }
        public string Source { get; set; }
    }
}
