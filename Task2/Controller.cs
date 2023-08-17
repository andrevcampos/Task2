using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2
{
    class Controller
    {

        public List<Customer> customers = new List<Customer>();

        public void Adding(string firstname, string lastname, bool stallaccount)
        {
            using (StreamWriter writer = File.AppendText("../../../data.txt"))
            {
                if (writer.BaseStream.Length > 0) // Check if the file is not empty
                {
                    writer.WriteLine(); // Add a newline before the new entry
                }
                writer.Write($"{firstname},{lastname},{stallaccount}");
            }
        }
        public void Finding()
        {
            //add
        }
        public void Editing(int lineIndex, string firstname, string lastname, bool stallaccount)
        {
            string filePath = "../../../data.txt";
            string[] lines = File.ReadAllLines(filePath);

            if (lineIndex >= 0 && lineIndex < lines.Length)
            {
                lines[lineIndex] = $"{firstname},{lastname},{stallaccount}";
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Line edited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid line index.");
            }
        }
        public void Deleting()
        {
            //add
        }
        public void ReadTextFile()
        {
            string[] strArray;
            var myfile = new StreamReader("../../../data.txt");
            while (!myfile.EndOfStream)
            {
                strArray = myfile.ReadLine().Split(',');
                if (strArray[2] == "true")
                {
                    StaffAccount staffAccount = new StaffAccount(strArray[0], strArray[1]);
                    customers.Add(staffAccount);
                }
                else
                {
                    PublicAccount publicAccount = new PublicAccount(strArray[0], strArray[1]);
                    customers.Add(publicAccount);
                }
            }
            myfile.Close();
        }
    }
}
