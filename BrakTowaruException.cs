using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class BrakTowaruException : Exception
    {
        public BrakTowaruException()
        {

        }

        public BrakTowaruException(string message): base(message)
        {

        }
    }
}
