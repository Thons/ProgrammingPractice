using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public class Document : IDocument
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Document() { }

        public Document(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }
}
