using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Motorbike_rental.Vehicle;

namespace Motorbike_rental
{
    public class Person
    {
        //หลักการสำคัญของ Encapsulation:
        //การซ่อนข้อมูล: ข้อมูลภายใน object จะถูกซ่อนจากผู้ใช้ภายนอก ผู้ใช้สามารถเข้าถึงข้อมูลได้ผ่าน interface ที่กำหนดไว้เท่านั้น
        //การรวมกลุ่มข้อมูล: ข้อมูลที่เกี่ยวข้องกันจะถูกจัดกลุ่มเข้าด้วยกันใน object เดียว
        //การจำกัดการเข้าถึง: กำหนดสิทธิ์การเข้าถึงข้อมูลและวิธีการภายใน object ว่าใครสามารถเข้าถึงได้บ้าง

        private string Firstname;
        private string Email;

        //interface
        public string Firstnamed
        {
            get { return Firstname;  }

            set { Firstname = value; }
        }

       public string Emaile
       {
            get { return Email; }

            set { Email = value; }
       }


    }

}
