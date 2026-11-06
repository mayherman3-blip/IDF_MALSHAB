using IDF_MALSHAB;
using VIEW_MODEL_IDFF;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {


            SubjectsTypeDB stdb = new();
            SubjectsTypeList stList = stdb.SelectAll();

            SubjectsType st = stList[0];
            st.SubjectName += "אאא";

            stdb.Update(st);
            int x1 = stdb.SaveChanges();
            Console.WriteLine($"{x1} rows were updated");

            foreach (SubjectsType s in stList)
                Console.WriteLine(s.SubjectName);


            // Person
            PersonDB pdb = new();
            PersonList pList = pdb.SelectAll();

            Person person = pList[0];
            person.PrivateName += "אאא";

            pdb.Update(person);
            int x2 = pdb.SaveChanges();
            Console.WriteLine($"{x2} rows were updated");

            foreach (Person p in pList)
                Console.WriteLine(p.PrivateName);


            // Malshab
            MalshabDB mdb = new();
            MalshabList mList = mdb.SelectAll();

            Malshab m = mList[0];
            m.Status.Status += "אאא";

            mdb.Update(m);
            int x3 = mdb.SaveChanges();
            Console.WriteLine($"{x3} rows were updated");

            foreach (Malshab mal in mList)
                Console.WriteLine(mal.Status);


            // GradesForArmyTasks
            GradesForArmyTasksDB gdb = new();
            GradesForArmyTasksList gList = gdb.SelectAll();

            GradesForArmyTasks g = gList[0];
            g.Grade += 1;

            gdb.Update(g);
            int x4 = gdb.SaveChanges();
            Console.WriteLine($"{x4} rows were updated");

            foreach (GradesForArmyTasks grade in gList)
                Console.WriteLine(grade.Grade);


            // ParentForMalshab
            ParentForMalshabDB pfmdb = new();
            ParentForMalshabList pfmList = pfmdb.SelectAll();

            foreach (ParentForMalshab p in pfmList)
                Console.WriteLine(p.Parent);


            // RecordsForMalshab
            RecordsForMalshabDB rdb = new();
            RecordsForMalshabList rList = rdb.SelectAll();

            RecordsForMalshab r = rList[0];
            r.RecordType.Description += "1";

            rdb.Update(r);
            int x6 = rdb.SaveChanges();
            Console.WriteLine($"{x6} rows were updated");

            foreach (RecordsForMalshab record in rList)
                Console.WriteLine(record.RecordType);


            // RecordsType
            RecordsTypeDB rtdb = new();
            RecordsTypeList rtList = rtdb.SelectAll();

            RecordsType rt = rtList[0];
            rt.Description += "אאא";

            rtdb.Update(rt);
            int x7 = rtdb.SaveChanges();
            Console.WriteLine($"{x7} rows were updated");

            foreach (RecordsType record in rtList)
                Console.WriteLine(record.Description);


            // StatusType
            StatusTypeDB sdb = new();
            StatusTypeList sList = sdb.SelectAll();

            StatusType status = sList[0];
            status.Status += "אאא";

            sdb.Update(status);
            int x8 = sdb.SaveChanges();
            Console.WriteLine($"{x8} rows were updated");

            foreach (StatusType s in sList)
                Console.WriteLine(s.Status);


            // SubjectsForMalshab
            SubjectsForMalshabDB sfmdb = new();
            SubjectsForMalshabList sfmList = sfmdb.SelectAll();

            SubjectsForMalshab sfm = sfmList[0];
            sfm.FinalGrade += 1;

            sfmdb.Update(sfm);
            int x9 = sfmdb.SaveChanges();
            Console.WriteLine($"{x9} rows were updated");

            foreach (SubjectsForMalshab s in sfmList)
                Console.WriteLine(s.FinalGrade);


            // ArmyTasksType
            ArmyTasksTypeDB atdb = new();
            ArmyTasksTypeList atList = atdb.SelectAll();

            ArmyTasksType at = atList[0];
            at.TaskType += "אאא";

            atdb.Update(at);
            int x10 = atdb.SaveChanges();
            Console.WriteLine($"{x10} rows were updated");

            foreach (ArmyTasksType a in atList)
                Console.WriteLine(a.TaskType);


            // Cities
            CitiesDB cdb = new();
            CitiesList cList = cdb.SelectAll();

            Cities cityToUpdate = cList[0];
            cityToUpdate.CityName += "אאא";

            cdb.Update(cityToUpdate);
            int x11 = cdb.SaveChanges();
            Console.WriteLine($"{x11} rows were updated");

            foreach (Cities c in cList)
                Console.WriteLine(c.CityName);







            //SubjectsTypeDB cdb = new();
            //SubjectsTypeList cList = cdb.SelectAll();
            //foreach (SubjectsType c in cList)
            //    Console.WriteLine(c.SubjectName);

            //PersonDB pdb = new();
            //PersonList pList = pdb.SelectAll();
            //foreach (Person p in pList)
            //    Console.WriteLine(p.PrivateName);


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




            //SubjectsForMalshabDB sdb = new SubjectsForMalshabDB();
            //SubjectsForMalshabList sList = sdb.SelectAll();
            //foreach (SubjectsForMalshab s in sList)
            //{
            //    Console.WriteLine(s.FinalGrade);
            //}

            //Console.WriteLine(SubjectsForMalshabDB.SelectById(1));




            //CitiesDB cdb = new();
            //CitiesList cList = cdb.SelectAll();
            //foreach (Cities c in cList)
            //    Console.WriteLine(c.CityName);
            //Cities cityToUpdate = cList[0];
            //cityToUpdate.CityName += "אאא";
            //cdb.Update(cityToUpdate);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x}rows were updated");
            //foreach (Cities c in cList)
            //    Console.WriteLine(c.CityName);




        }
    }
}
