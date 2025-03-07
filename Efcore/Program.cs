using EfCore.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Security.Cryptography;

namespace EfCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIContext db = new ITIContext();
            #region add
            //Patient p1 = new Patient();
            //Console.WriteLine("enter PatientID");
            //p1.patient_id = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the firstName");
            //p1.f_name = Console.ReadLine();
            //Console.WriteLine("enter the lastName");
            //p1.l_name = Console.ReadLine();
            //Console.WriteLine("enter your address");
            //p1.patient_address = Console.ReadLine();
            //Console.WriteLine("Enter your PhoneNumber");
            //p1.phone_num = Console.ReadLine();
            //Console.WriteLine("enter your DoctorID");
            //p1.doc_id = int.Parse(Console.ReadLine());
            //db.Patients.Add(p1);
            //db.SaveChanges();
            //var q1 = db.Patients.Select(p => p);
            //foreach (var q in q1)
            //{
            //    Console.WriteLine($"{q.patient_id}-{q.f_name}-{q.l_name}-{q.patient_address}");
            //}
            #endregion
            #region edit
            //Console.WriteLine("enter Patients id to edit");
            //int id =int.Parse(Console.ReadLine());
            //Patient p1 =db.Patients.Where(n=>n.patient_id == id).SingleOrDefault();
            //Console.WriteLine("enter PatientID");
            //p1.patient_id = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the firstName");
            //p1.f_name = Console.ReadLine();
            //Console.WriteLine("enter the lastName");
            //p1.l_name = Console.ReadLine();
            //Console.WriteLine("enter your address");
            //p1.patient_address = Console.ReadLine();
            //Console.WriteLine("Enter your PhoneNumber");
            //p1.phone_num = Console.ReadLine();
            //Console.WriteLine("enter your DoctorID");
            //p1.doc_id = int.Parse(Console.ReadLine());
            //db.Patients.Add(p1);
            //db.SaveChanges();
            //var q3 = db.Patients.Select(p1 => p1);
            //foreach (var q in q3)
            //{
            //    Console.WriteLine($"{q.patient_id}-{q.f_name}-{q.l_name}-{q.patient_address}");
            //}
            #endregion

            #region delete
            //Console.WriteLine("enter Patients id to delete");
            //int id = int.Parse(Console.ReadLine());
            //Patient p1 = db.Patients.Where(n => n.patient_id == id).SingleOrDefault();
            //db.Patients.Remove(p1);
            //db.SaveChanges();
            //var q4 = db.Patients.Select(p=>p);
            //foreach (var q in q4)
            //{
            //   Console.WriteLine($"{q.patient_id}-{q.f_name}-{q.l_name}-{q.patient_address}");
            //}
            #endregion 

        }
    }
}
