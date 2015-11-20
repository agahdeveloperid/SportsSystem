﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAUNSportsSystem.DomainClasses
{
    public class SlideShowItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
    }
}
