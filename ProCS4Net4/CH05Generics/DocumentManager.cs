using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public class DocumentManager<TDocument>
        where TDocument : IDocument
    {
        private readonly Queue<TDocument> documentQuene = new Queue<TDocument>();

        public void AddDocument(TDocument doc)
        {
            lock (this)
            {
                documentQuene.Enqueue(doc);
            }
        }

        public bool IsDocumentAvailable
        {
            get { return documentQuene.Count > 0; }
        }

        public TDocument GetDocument()
        {
            TDocument doc = default(TDocument);
            lock (this)
            {
                doc = documentQuene.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach (TDocument doc in documentQuene)
            {
                Console.WriteLine(doc.Title);
            }
        }
    }
}
