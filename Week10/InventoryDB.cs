using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10
{
    public class InventoryDB
    {

        private static readonly string Path = @"D:\HARDIK SHAH ITs\SEM 2\grocery_inventory_items.txt";
        private const string Delimiter = "|";


        public static List<Inventory> GetItems()
        {
            List<Inventory> items = new List<Inventory>();


            using (StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split(Delimiter);


                    if (columns.Length == 3)
                    {
                        Inventory item = new Inventory
                        {
                            ItemNo = Convert.ToInt32(columns[0]),
                            Description = columns[1],
                            Price = Convert.ToDouble(columns[2])
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }


        public static void SaveItems(List<Inventory> items)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Inventory item in items)
                {
                    textOut.Write(item.ItemNo + Delimiter);
                    textOut.Write(item.Description + Delimiter);
                    textOut.WriteLine(item.Price);
                }
            }
        }
        public static void DeleteItem(int itemNo)
        {
            List<Inventory> items = GetItems();
            Inventory itemToRemove = items.FirstOrDefault(item => item.ItemNo == itemNo);

            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                SaveItems(items); // Save the updated list of items to the file
            }
        }
    }
    }
