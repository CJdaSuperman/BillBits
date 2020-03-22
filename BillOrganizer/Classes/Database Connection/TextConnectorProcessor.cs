using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOrganizer.Classes.TextHelpers
{
    //this class has extension methods that "help" TextConnector load and save files, as well as
    //converting the file to a Bill list
    public static class TextConnectorProcessor
    {
        //loads file using the file path
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"] } \\{fileName}";
            //AppConfig.cs -> C:\Users\Carol's laptop\Desktop\BillBits
        }

        //reads the file and converts it into a list of strings
        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        //converts the lines of the text file to instances of Bill
        public static List<Bill> ConvertToBill(this List<string> lines)
        {
            List<Bill> output = new List<Bill>();

            foreach(string line in lines)
            {
                //each line will have their values separated by a comma
                string[] cols = line.Split(',');

                Bill bill = new Bill();

                bill.Id = int.Parse(cols[0]);
                bill.Name = cols[1];
                bill.DueDate = cols[2];
                bill.Balance = decimal.Parse(cols[3]);
                bill.MinDue = decimal.Parse(cols[4]);
                bill.DatePaid = cols[5];
                bill.PaidAmount = decimal.Parse(cols[6]);
                bill.isPaid = bool.Parse(cols[7]);
                bill.previousPayments[0].Date = cols[8];
                bill.previousPayments[0].paidAmount = decimal.Parse(cols[9]);
                bill.previousPayments[1].Date = cols[10];                
                bill.previousPayments[1].paidAmount = decimal.Parse(cols[11]);
                bill.previousPayments[2].Date = cols[12];
                bill.previousPayments[2].paidAmount = decimal.Parse(cols[13]);
                bill.Note = cols[14];

                output.Add(bill);
            }

            return output;
        }

        public static void SaveToBillsFile(this List<Bill> bills, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(Bill b in bills)
            {
                lines.Add($"{ b.Id },{ b.Name },{ b.DueDate },{ b.Balance },{ b.MinDue },{ b.DatePaid }," +
                    $"{ b.PaidAmount },{ b.isPaid },{ b.previousPayments[0].Date },{ b.previousPayments[0].paidAmount }," +
                    $"{ b.previousPayments[1].Date },{ b.previousPayments[1].paidAmount }," +
                    $"{ b.previousPayments[2].Date },{ b.previousPayments[2].paidAmount }," +
                    $"{b.Note}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
