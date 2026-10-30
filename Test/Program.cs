using IDF_MALSHAB;
using VIEW_MODEL_IDFF;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SubjectsTypeDB cdb = new();
            //SubjectsTypeList cList = cdb.SelectAll();
            //foreach (SubjectsType c in cList)
            //    Console.WriteLine(c.SubjectName);

            //PersonDB pdb = new();
            //PersonList pList = pdb.SelectAll();
            //foreach (Person p in pList)
            //    Console.WriteLine(p.PrivateName);

            //PersonDB pdb = new PersonDB();
            //PersonList pList = pdb.SelectAll();
            //foreach (Person person in pList)
            //{
            //    Console.WriteLine(person.Email);
            //}

            //Console.WriteLine(PersonDB.SelectById(1).FamilyName);



            //ParentDB padb = new ParentDB();
            //ParentList paList = padb.SelectAll();
            //foreach (Parent parent in paList)
            //{
            //    Console.WriteLine(parent.Email);
            //}

            //Console.WriteLine(ParentDB.SelectById(1));



            //MalshabDB mdb = new MalshabDB();
            //MalshabList mList = mdb.SelectAll();
            //foreach (Malshab m in mList)
            //{
            //    Console.WriteLine(m.Id);
            //}

            //Console.WriteLine(MalshabDB.SelectById(1));



            //ArmyPersonDB adb = new ArmyPersonDB();
            //ArmyPersonList aList = adb.SelectAll();
            //foreach (ArmyPerson a in aList)
            //{
            //    Console.WriteLine(a.Email);
            //}

            //Console.WriteLine(ArmyPersonDB.SelectById(1));



            //GradesForArmyTasksDB gdb = new GradesForArmyTasksDB();
            //GradesForArmyTasksList gList = gdb.SelectAll();
            //foreach (GradesForArmyTasks g in gList)
            //{
            //    // Console.WriteLine(g.ArmyTasksType); לא נותן להדפיס כי צריך טו סטרינג
            //    Console.WriteLine(g.Grade);
            //}

            //Console.WriteLine(GradesForArmyTasksDB.SelectById(1));



            //ParentForMalshabDB pdb = new ParentForMalshabDB();
            //ParentForMalshabList pList = pdb.SelectAll();
            //foreach (ParentForMalshab p in pList)
            //{
            //    Console.WriteLine(p.Id);
            //}

            //Console.WriteLine(ParentForMalshabDB.SelectById(1));



            //RecordsForMalshabDB rdb = new RecordsForMalshabDB();
            //RecordsForMalshabList rList = rdb.SelectAll();
            //foreach (RecordsForMalshab r in rList)
            //{
            //    Console.WriteLine(r.Id);
            //}

            //Console.WriteLine(RecordsForMalshabDB.SelectById(1));




            SubjectsForMalshabDB sdb = new SubjectsForMalshabDB();
            SubjectsForMalshabList sList = sdb.SelectAll();
            foreach (SubjectsForMalshab s in sList)
            {
                Console.WriteLine(s.FinalGrade);
            }

            Console.WriteLine(SubjectsForMalshabDB.SelectById(1));
        }
    }
}
