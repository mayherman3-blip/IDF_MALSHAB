using IDF_MALSHAB;
using VIEW_MODEL_IDFF;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            SubjectsTypeDB cdb = new();
            SubjectsTypeList cList = cdb.SelectAll();
            foreach (SubjectsType c in cList)
                Console.WriteLine(c.SubjectName);
            


        }
    }
}
