using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class Dataset : IPrototype
    {
        private List<List<string>> data;

        public Dataset()
        {
            this.data = new List<List<string>>();
        }

        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');

                    foreach (string item in items)
                    {
                        row.Add(item);
                    }

                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }

        public void ClearData()
        {
            this.data.Clear();
        }


        public IPrototype Clone()
        {
            Dataset copy = (Dataset)this.MemberwiseClone();
            copy.data = new List<List<string>>();

            for (int i = 0; i < this.data.Count; i++)
            {
                copy.data.Add(new List<string>());
                for (int j = 0; j < this.data[i].Count; j++)
                {
                    copy.data[i].Add(this.data[i][j]);
                }
            }

            return copy;
        }
    }
}

//potrebno je duboko kopiranje