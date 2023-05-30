using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_Office_Lib.Data_Access
{
    public class DataAccess<T> where T : new()
    {
        public event EventHandler<T> BadEntryFound;
        public void SaveToCSV(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();

            string row = "";

            //Headers
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            //foreach person or car
            foreach (var item in items)
            {
                row = "";
                bool badWordDetected = false;

                //values in each person or car
                foreach (var col in cols)
                {
                    try
                    {
                        string val = col.GetValue(item, null).ToString();

                        //if a bad word is detected, the loop will break and go to the next value
                        badWordDetected = BadWordDetector(val);
                        if (BadWordDetector(val) == true)
                        {
                            BadEntryFound?.Invoke(this, item);
                            break;
                        }

                        row += $",{ val }";
                    }//NullReferenceException can be thrown if one of the properties is Private (I think, like Registration Number)
                    catch (NullReferenceException e)
                    {
                        break;
                    }                                        
                }
                //if only good words, then add to the List
                if (badWordDetected == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
            }
            //Save to CSV
            File.WriteAllLines(filePath, rows);
        }

        private bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCase = stringToTest.ToLower();

            if (lowerCase.Contains("shit") || lowerCase.Contains("fuck"))
            {
                output = true;
            }

            return output;
        }
    }
}
