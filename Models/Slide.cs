﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlatmateFinders.Models
{
    //Slide Model for landing page slider
    public class Slide
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public bool IsImageInsideText { get; set; }
        public bool IsImageWithText { get; set; }
    }
}
