using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Quiz1_irakliChkhitunidze
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> A = new List<Student>();
            List<Student> B = new List<Student>();

            /// სტუდენტი 1
            Student p1 = new Student();
            p1.firsName = "irakli";
            p1.lastName = "chkhitunidze";
            p1.PN = "0123456789";
            p1.address = "tbilisi";
            p1.groupID = "31231UID";
            p1.mob = "+995898606060";

            /// სტუდენტი 2
            Student p2 = new Student();
            p2.firsName = "იკაკო";
            p2.lastName = "achkhitunidze";
            p2.PN = "0123456789";
            p2.address = "tbilisi";
            p2.groupID = "31231UID";
            p2.mob = "+995898606060";
            p2.registerDate = "20-15-03";

            /// სტუდენტი 3
            Student p3 = new Student();
            p3.firsName = "უსახელო";


            A.Add(p1);
            A.Add(p2);
            B.Add(p3);


            // B ლისტში სტუდენტების დამატება A ლისტიდან
            foreach (Student stu in A)
            {
                B.Add(stu);
            }

            // B ლისტის დასორტირება firstName-ის მიხედვით
            B.Sort((x, y) => string.Compare(x.lastName, y.lastName));


            // B ლისტიდან რიგით მეორე ინდექზე მყოფი ელემენტის წაშლა
            B.RemoveAt(1);

            Console.WriteLine(B);
            Console.WriteLine(A);
            // Console.ReadKey();



          Boolean a =  OrderInformation("A9");
            Console.WriteLine(a);
            Console.ReadKey();
        }
        // Task 2
        static Boolean OrderInformation(String text)
        {
            string filteredText = text.Replace(" ", "");
            for (int i = 0; i < filteredText.Length; i+=2)
            {
                string s = ""+filteredText[i] + filteredText[i+1];
                if (!Regex.Match(s, "([A-E]+[1-9])").Success)
                {
                    return false;
                }

            }
                

            return true;
        }
    }
}
