using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace BackendCode
{
    public class BackEnd
    {
        int[] groupArr = new int[3];
        Dictionary<int, int[]> dictionaryList = new Dictionary<int, int[]>();
        int id;


        string path = @"..\..\..\SalesList.txt";

        string Output;
        public void MainCode()
        {
            BackEnd p = new BackEnd();
            p.Run();
        }

        void Run()
        {
            TextToDictionary();
        }

        public void TextToDictionary()
        {
            StreamReader sr = new StreamReader(path);
            string text;
            while ((text = sr.ReadLine()) != null) //
            {
                string[] parts = text.Split('$');
                id = int.Parse(parts[0]);
                int valueChild = int.Parse(parts[3]);
                int valueAdult = int.Parse(parts[4]);
                int valueSenior = int.Parse(parts[5]);
                groupArr[0] = valueChild;
                groupArr[1] = valueAdult;
                groupArr[2] = valueSenior;
                dictionaryList.Add(id, groupArr);
            }
            sr.Close();
        }

        public void Refund(int id)
        {
            dictionaryList.Clear();
            Run();
            if (dictionaryList.ContainsKey(id))
            {
                dictionaryList.Remove(id);
            }
            StreamWriter sw = new StreamWriter(path);
            foreach (KeyValuePair<int, int[]> pair in dictionaryList)
            {
                sw.WriteLine(pair.Key + Math(pair.Value[0], pair.Value[1], pair.Value[2]));
            }
            sw.Close();
        }
        public void Checkout()
        {
            dictionaryList.Clear();
            Run();
            id = 0;
            bool condition = true;
            while(condition)
            {
                if (dictionaryList.ContainsKey(id))
                {
                    id++;
                }
                else
                {
                    condition = false;
                }
            }
            StreamWriter sw = new StreamWriter(path, true);
            Output = Math(groupArr[0], groupArr[1], groupArr[2]);
            dictionaryList.Add(id, groupArr);
            sw.WriteLine(id + Output);
            MessageBox.Show("Your ticket ID is: " + id);
            sw.Close();
        }

        public string Math(int child, int adult, int senior)
        {
            int totalpeople = child + adult + senior;
            int totalCost = (child * 25) + (adult * 100) + (senior * 65);

            string FullLine = "$" + totalpeople + "$" + totalCost + "$";

            string textchild = child + "$";
            FullLine = FullLine + textchild;

            string textadults = adult + "$";
            FullLine = FullLine + textadults;

            string textseniors = senior.ToString();
            FullLine = FullLine + textseniors;

            return FullLine;

        }

        public void GetInts(int childP, int adultP, int seniorP)
        {
            groupArr[0] = childP; //child price
            groupArr[1] = adultP; //adult price
            groupArr[2] = seniorP; //senior price
        }
    }
}
