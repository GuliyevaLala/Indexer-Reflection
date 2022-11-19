using System;


namespace Indexer_Reflection {
    public class PersonController
    {
        public static void GetPersonDatas()
        {

            IPersonService personservice = new PersonService();
            var result = personservice.GetFullData(m => m.Salary > 1000);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
