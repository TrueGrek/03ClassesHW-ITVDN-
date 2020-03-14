using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ успешно отредактирован");
        }
    }
}
