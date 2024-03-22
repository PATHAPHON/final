using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Motorbike_rental
{
    public partial class ef : Form
    {
        public ef()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //เป็นการประกาศตัวแปรชื่อ Fazzio ของ class Fazzio โดยใช้ constructor เริ่มต้นของ class Fazzio
        Fazzio Fazzio = new Fazzio();
        PCX150 PCX150 = new PCX150();
        YZFR3 YZFR3 = new YZFR3();
        XMAX XMAX = new XMAX();
        Vehicle vehicle = new Vehicle();
        string Data = "";
        private void button3_Click(object sender, EventArgs e)
        {
            //เรียกใช้ ข้อมล ใน class Mototcyle.cs
            CylindervolumeTextbox.Text = Fazzio.CylinderVolume();
            FueltypeTextbox.Text = Fazzio.FuelType();
            RentalpriceDayTextbox.Text = Convert.ToString(Fazzio.Rental_price_DAY());
            RentalpriceMonthTextbox.Text = Convert.ToString(Fazzio.Rental_price_MONTH());
            ColorTextbox.Text = Fazzio.colormotorcycle.ToString();
            CategoryTextbox.Text = Fazzio.categorytype.ToString();
            NumberProductsTextbox.Text = Fazzio.numberproducts().ToString();
            pictureMotocycle.Image = Motorbike_rental.Properties.Resources.Fazzio;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PCX150 PCX150 = new PCX150();
            CylindervolumeTextbox.Text = PCX150.CylinderVolume();
            FueltypeTextbox.Text = PCX150.FuelType();
            RentalpriceDayTextbox.Text = Convert.ToString(PCX150.Rental_price_DAY());
            RentalpriceMonthTextbox.Text = Convert.ToString(PCX150.Rental_price_MONTH());
            ColorTextbox.Text = PCX150.colormotorcycle.ToString();
            CategoryTextbox.Text = PCX150.categorytype.ToString();
            NumberProductsTextbox.Text = PCX150.numberproducts().ToString();
            pictureMotocycle.Image = Motorbike_rental.Properties.Resources.PCX150;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CylindervolumeTextbox.Text = YZFR3.CylinderVolume();
            FueltypeTextbox.Text = YZFR3.FuelType();
            RentalpriceDayTextbox.Text = Convert.ToString(YZFR3.Rental_price_DAY());
            RentalpriceMonthTextbox.Text = Convert.ToString(YZFR3.Rental_price_MONTH());
            ColorTextbox.Text = YZFR3.colormotorcycle.ToString();
            CategoryTextbox.Text = YZFR3.categorytype.ToString();
            NumberProductsTextbox.Text = YZFR3.numberproducts().ToString();
            pictureMotocycle.Image = Motorbike_rental.Properties.Resources.YZFR3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CylindervolumeTextbox.Text = XMAX.CylinderVolume();
            FueltypeTextbox.Text = XMAX.FuelType();
            RentalpriceDayTextbox.Text = Convert.ToString(XMAX.Rental_price_DAY());
            RentalpriceMonthTextbox.Text = Convert.ToString(XMAX.Rental_price_MONTH());
            ColorTextbox.Text = XMAX.colormotorcycle.ToString();
            CategoryTextbox.Text = XMAX.categorytype.ToString();
            NumberProductsTextbox.Text = XMAX.numberproducts().ToString();
            pictureMotocycle.Image = Motorbike_rental.Properties.Resources.XMAX;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int unit = Convert.ToInt32(inputunit.Text);
            ///Regular Expression, Regex หรือ Regexp คือ ลำดับอักษร Pattern 
            ///ที่ใช้ในการค้นหาข้อความใน String โดยสามารถใช้ค้นหาอย่างเดียว, ค้นหาแล้วแทนที่ด้วยข้อความที่กำหนดก็ได้ 
            ///หรือใช้ตรวจสอบ String Input ว่าเป็นไปตาม Format ที่กำหนดหรือไม่

            //โค้ดนี้ใช้ Regular Expression (Regex) ตรวจสอบว่า nametextbox.Text ประกอบไปด้วยตัวอักษรภาษาอังกฤษ (a-z, A-Z) ทั้งหมดหรือไม่
            bool isAlphabetic = Regex.IsMatch(nametextbox.Text, @"^[a-zA-Z]+$");
            //โค้ดนี้ใช้ Regular Expression (Regex) ตรวจสอบว่า emailtextbox.Text เป็นรูปแบบอีเมลที่ถูกต้องหรือไม่
            bool isEmail = Regex.IsMatch(emailtextbox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (comboBox.Text == "Fazzio")
            {

                string name = Fazzio.name();
                string Rental_price_DAY = Fazzio.Rental_price_DAY().ToString();
                string Rental_price_MONTH = Fazzio.Rental_price_MONTH().ToString();
                int numberproducts = Fazzio.numberproducts();
                if (numberproducts >= 1)
                {
                    if (isAlphabetic && isEmail)
                    {
                        if (pricetextbox.Text == Rental_price_DAY)
                        {
                            //แอดข้อมูล เข้า dataGridview1
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_DAY, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            Fazzio.decrease(unit);
                            //อัปเดตข้อมูล ใน numberproducts
                            numberproducts = Fazzio.numberproducts();
                            //แสดงค่า NumberProductsTextbox.Text
                            NumberProductsTextbox.Text = numberproducts.ToString();
                        }
                        else if (pricetextbox.Text == Rental_price_MONTH)
                        {
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_MONTH, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            Fazzio.decrease(unit);
                            numberproducts = Fazzio.numberproducts();
                            NumberProductsTextbox.Text = numberproducts.ToString();

                        }
                        else
                        {
                            //โชว์ของมูลเด้งขึี้นมา
                            MessageBox.Show("กรุณาใส่ราคาเช่าให้ถูกต้อง");
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณาตรวจสอบชื่อหรืออัเมลว่าถูกต้องหรือไม่");
                    }

                }
                else
                {
                    MessageBox.Show("สินค้าหมดแล้ว");
                }


            }
            else if (comboBox.Text == "PCX150")
            {
                string name = PCX150.name();
                string Rental_price_DAY = PCX150.Rental_price_DAY().ToString();
                string Rental_price_MONTH = PCX150.Rental_price_MONTH().ToString();
                int numberproducts = PCX150.numberproducts();
                if (numberproducts >= 1)
                {
                    if (isAlphabetic && isEmail)
                    {
                        if (pricetextbox.Text == Rental_price_DAY)
                        {
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_DAY, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            PCX150.decrease(unit);
                            numberproducts = PCX150.numberproducts();
                            NumberProductsTextbox.Text = numberproducts.ToString();
                        }
                        else if (pricetextbox.Text == Rental_price_MONTH)
                        {
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_MONTH, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            Fazzio.decrease(unit);
                            numberproducts = PCX150.numberproducts();
                            NumberProductsTextbox.Text = numberproducts.ToString();

                        }
                        else
                        {
                            MessageBox.Show("กรุณาใส่ราคาเช่าให้ถูกต้อง");
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณาตรวจสอบชื่อหรืออัเมลว่าถูกต้องหรือไม่");
                    }

                }
                else
                {
                    MessageBox.Show("สินค้าหมดแล้ว");
                }

            }
            else if (comboBox.Text == "YZF-R3")
            {
                string name = YZFR3.name();
                string Rental_price_DAY = YZFR3.Rental_price_DAY().ToString();
                string Rental_price_MONTH = YZFR3.Rental_price_MONTH().ToString();
                int numberproducts = YZFR3.numberproducts();
                if (numberproducts >= 1)
                {
                    if (isAlphabetic && isEmail)
                    {
                        if (pricetextbox.Text == Rental_price_DAY)
                        {
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_DAY, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            YZFR3.decrease(unit);
                            numberproducts = YZFR3.numberproducts();
                            NumberProductsTextbox.Text = numberproducts.ToString();
                        }
                        else if (pricetextbox.Text == Rental_price_MONTH)
                        {
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_MONTH, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            Fazzio.decrease(unit);
                            numberproducts = YZFR3.numberproducts();
                            NumberProductsTextbox.Text = numberproducts.ToString();

                        }
                        else
                        {
                            MessageBox.Show("กรุณาใส่ราคาเช่าให้ถูกต้อง");
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณาตรวจสอบชื่อหรืออัเมลว่าถูกต้องหรือไม่");
                    }

                }
                else
                {
                    MessageBox.Show("สินค้าหมดแล้ว");
                }

            }
            else if (comboBox.Text == "XMAX")
            {
                string name = XMAX.name();
                string Rental_price_DAY = XMAX.Rental_price_DAY().ToString();
                string Rental_price_MONTH = XMAX.Rental_price_MONTH().ToString();
                int numberproducts = XMAX.numberproducts();
                if (numberproducts >= 1)
                {
                    if (isAlphabetic && isEmail)
                    {
                        if (pricetextbox.Text == Rental_price_DAY)
                        {
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_DAY, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            XMAX.decrease(unit);
                            numberproducts = XMAX.numberproducts();
                            NumberProductsTextbox.Text = numberproducts.ToString();
                        }
                        else if (pricetextbox.Text == Rental_price_MONTH)
                        {
                            dataGridView1.Rows.Add(nametextbox.Text, emailtextbox.Text, name, Rental_price_MONTH, inputunit.Text);
                            Data = $"{nametextbox.Text} , {emailtextbox.Text} , {name} , {Rental_price_DAY} , {inputunit.Text}\n";
                            Fazzio.decrease(unit);
                            numberproducts = XMAX.numberproducts();
                            NumberProductsTextbox.Text = numberproducts.ToString();

                        }
                        else
                        {
                            MessageBox.Show("กรุณาใส่ราคาเช่าให้ถูกต้อง");
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณาตรวจสอบชื่อหรืออัเมลว่าถูกต้องหรือไม่");
                    }

                }
                else
                {
                    MessageBox.Show("สินค้าหมดแล้ว");
                }



            }
            CSV csv = new CSV();
            bool canWrite = csv.SavetoFile(Data);
            if (canWrite)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }



           

       private void groupBox1_Enter(object sender, EventArgs e)
       {

       }

       private void groupBox5_Enter(object sender, EventArgs e)
       {

       }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
                
       }
            

       private void groupBox3_Enter(object sender, EventArgs e)
       {

       }

       private void button4_Click(object sender, EventArgs e)
       {            

            if (combofillmotorcyle.Text == "Fazzio")
            {
                int numberproducts = Fazzio.numberproducts();
                Fazzio.AddProducts(Convert.ToInt32(Numberofproducts.Text));
                numberproducts = Fazzio.numberproducts();
                NumberProductsTextbox.Text = numberproducts.ToString();
            }
            else if (combofillmotorcyle.Text == "PCX150")
            {
                int numberproducts = PCX150.numberproducts();
                PCX150.AddProducts(Convert.ToInt32(Numberofproducts.Text));
                numberproducts = PCX150.numberproducts();
                NumberProductsTextbox.Text = numberproducts.ToString();

            }
            else if (combofillmotorcyle.Text == "YZFR3")
            {
                int numberproducts = YZFR3.numberproducts();
                YZFR3.AddProducts(Convert.ToInt32(Numberofproducts.Text));
                numberproducts = YZFR3.numberproducts();
                NumberProductsTextbox.Text = numberproducts.ToString();

            }
            else if (combofillmotorcyle.Text == "XMAX")
            {
                int numberproducts = XMAX.numberproducts();
                XMAX.AddProducts(Convert.ToInt32(Numberofproducts.Text));
                numberproducts = XMAX.numberproducts();
                NumberProductsTextbox.Text = numberproducts.ToString();
            }
        }

       private void button2_Click(object sender, EventArgs e)
       {



       }
    }
}

