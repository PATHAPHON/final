using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorbike_rental
{
    internal class CSV
    {
        private string path = @"C:\Users\patap\Documents\final_project-main\final_project-main\Motorbike rental\Data.csv";

        public bool SavetoFile(string data)
        {
            try
            {
                File.AppendAllText(path, data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
