using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class ProduktJuzIstniejeException : Exception
    {
        public ProduktJuzIstniejeException()
        {

        }

        public ProduktJuzIstniejeException(string message): base(message)
        {

        }
    }
}
