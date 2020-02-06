using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BackendCode
{
    public class BackEnd
    {
        int[] groupArr = new int[3];
        Dictionary<int, int[]> dictionaryList = new Dictionary<int, int[]>(); //kan endast tillägga saker i metoder
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
            TxtToDictionary();
        }

        public void TxtToDictionary()
        {
            StreamReader sr = new StreamReader(path); //läser genom en txt
            string text; //text som attachas till array:n för varje rad
            while ((text = sr.ReadLine()) != null) //
            {
                string[] parts = text.Split('$');
                int id = int.Parse(parts[0]);
                int valueChild = int.Parse(parts[3]);
                int valueAdult = int.Parse(parts[4]);
                int valueSenior = int.Parse(parts[5]);
                groupArr[0] = valueChild;
                groupArr[1] = valueAdult;
                groupArr[2] = valueSenior;
                dictionaryList.Add(id, groupArr);
                break;
            }
            sr.Close();
        }

        public void Refund(int id)
        {
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
            id = 0;
            StreamReader sr = new StreamReader(path);
            string lines;
            while ((lines =sr.ReadLine()) != null)
            {
                string[] parts = lines.Split('$');
                int idCheck = int.Parse(parts[0]);
                if (dictionaryList.ContainsKey(idCheck))
                {
                    idCheck++;
                }
                else
                {
                    break;
                }
            }
            sr.Close();
            Output = Math(groupArr[0], groupArr[1], groupArr[2]);
            dictionaryList.Add(id, groupArr);
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(id + Output);
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


    class ReceiptInfo
    {

    }

    /*
    class Ticket
    {
        private int price;
        private string group;

        public int GetPrice()
        {
            return price;
        }

        public string GetGroup()
        {
            return group;
        }
    }
    */

    //class Ticket
    //{
    //    private int price;
    //    private string type;


    //}

    //public abstract class AdultTicket
    //{
    //    public abstract void Ticket();
    //} //abstract söger bara att den ärver vad som står, inte att blir använt som en isntans
    // Kolla upp
    //abstract
    //override
    //float
    //dictionary 
    //listor typ
    //

    //string path = @"..\..\..\ExText.txt";
    //streamwrite/streamread

    /*
    public int Adult()
    {
    int adult = 0;
    int idInteger = 0;
    for (int i = 0; i < dictionaryList.Count; i++)
    {
        if (dictionaryList.ContainsKey(adult))
        {
            adult++;
        }
        break;
    }
    dictionaryList.Add(adult, 100);
    adult++;
    StreamWriter sw = new StreamWriter(path);
    sw.WriteLine(adult + " " + "adult" + " " + 100);
    sw.Close();
    return adult;
    }
    */

}
