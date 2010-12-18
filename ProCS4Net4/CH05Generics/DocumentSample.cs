using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    class DocumentSample
    {
        static void Main(string[ ] args)
        {
            var dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("Title A", "Content A"));
            dm.AddDocument(new Document("Title B", "Content B"));

            dm.DisplayAllDocuments();

            if (dm.IsDocumentAvailable)
            {
                Document d = dm.GetDocument();
                Console.WriteLine(d.Content);
            }
        }
    }
}
