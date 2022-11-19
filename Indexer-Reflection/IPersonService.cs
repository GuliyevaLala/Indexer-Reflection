using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_Reflection
{
    public interface IPersonService
    {
        public List<string> GetFullData(Predicate<Person> predicate);
    }
}
