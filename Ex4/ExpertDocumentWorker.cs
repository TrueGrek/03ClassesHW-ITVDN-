using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Сохранение документа прошло успешно!");
        }
    }
}
