using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eftest1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new OnboardRetailContext())
            {
                var count = db.TbCcbsaleTypes.Count();
                System.Console.WriteLine(count);

                foreach (var item in db.TbCcbsaleTypes)
                {
                    System.Console.WriteLine(item.Eddreason);
                }

            }
        }
    }
}
