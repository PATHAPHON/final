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

        ///try: เป็นบล็อกโค้ดที่ใช้สำหรับ การลองทำ สิ่งใดสิ่งหนึ่ง
         /// ในกรณีนี้ โค้ดจะพยายาม เขียนข้อความ ไปยังไฟล์
        /// <summary>
        /// try: เป็นบล็อกโค้ดที่ใช้สำหรับ การลองทำ สิ่งใดสิ่งหนึ่ง
        /// </summary>ณีนี้ โค้ดจะ จับข้อผิดพลาด ที่อาจเกิดขึ้นจากการเขียนไฟล์
        ///โค้ดจะ ส่งคืนค่า false

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
