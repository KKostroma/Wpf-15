using System;
using System.IO;
using System.Windows.Documents;

namespace WpfЗадание15
{
    internal class XpsDocument
    {
        public XpsDocument(string v, FileAccess write)
        {
        }

        public IDocumentPaginatorSource GetFixed { get; internal set; }

        internal static XpsDocument CreateXpsDocumentWriter(XpsDocument doc)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Write(FixedDocument fixedDocument)
        {
            throw new NotImplementedException();
        }
    }
}