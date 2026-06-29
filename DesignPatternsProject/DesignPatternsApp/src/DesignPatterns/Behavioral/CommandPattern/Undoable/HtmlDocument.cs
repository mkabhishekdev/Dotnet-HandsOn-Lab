using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern.Undoable
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeItalic()
        {
            Content = "<i>" + Content + "</i>"; 
        }
    }
}

