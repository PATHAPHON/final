1.ความเป็นมาของโปรแกม
โปรแกรมเช่ารถมอเตอร์ไซค์สำหรับคนต่างชาติ เกิดขึ้นเพื่อตอบสนองความต้องการของนักท่องเที่ยวและผู้พำนักระยะสั้น ที่ต้องการความสะดวกในการเดินทาง

2.วัตถุประสงค์ของโปรแกรมเช่ารถมอเตอร์ไซค์

1. เพิ่มความสะดวกในการเดินทาง
ตอบโจทย์ความต้องการของนักท่องเที่ยวและผู้พำนักระยะสั้น ที่ต้องการความสะดวกในการเดินทาง
ขจัดอุปสรรคด้านภาษา เอกสาร และความปลอดภัย

2. ส่งเสริมการท่องเที่ยว
ดึงดูดนักท่องเที่ยวให้มาเที่ยวประเทศไทยมากขึ้น
กระตุ้นเศรษฐกิจท้องถิ่น

3. เพิ่มตัวเลือกในการเดินทาง
เป็นทางเลือกใหม่สำหรับผู้ใช้รถมอเตอร์ไซค์
ตอบสนองความต้องการที่หลากหลาย

class diagram

```mermaid
classDiagram
   Vehicle -- ef
   CSV -- Person
   CSV -- Vehicle
   CSV -- ef
    Vehicle  --|>  Fazzio 
    Vehicle --|>  PCX150
    Vehicle  --|>  YZFR3
    Vehicle  --|>  XMAX

class Person {
        -Firstname: string
        -Email: string
        +Firstnamed: string
        +Emaile: string
    }

class Vehicle {
        -Name: string
        -Brand: string
        -Pic: Image
        -Cylindervolume: string
        -Fueltype: string
        -Rental_price_Day: int
        -Rental_price_Month: int
        -NumberProducts: int
        -CategoryType: Category
        -ColorMotorcycle: Color
        +name(): string
        +brand(): string
        +Rental_price_DAY(): int
        +Rental_price_MONTH(): int
        +CylinderVolume(): string
        +FuelType(): string
        +numberproducts(): int
        +decrease(amount: int): void
        +AddProducts(amount1: int): void
        +categorytype: Category
        +colormotorcycle: Color
    }


  class ef {
        -Fazzio: Fazzio
        -PCX150: PCX150
        -YZFR3: YZFR3
        -XMAX: XMAX
        -Vehicle: Vehicle
        -Data: string
        +ef()
        +void button3_Click(object sender, EventArgs e)
        +void button5_Click(object sender, EventArgs e)
        +void button7_Click(object sender, EventArgs e)
        +void button9_Click(object sender, EventArgs e)
        +void button1_Click(object sender, EventArgs e)
        +void button4_Click(object sender, EventArgs e)
        +void button2_Click(object sender, EventArgs e)
        +void textBox2_TextChanged(object sender, EventArgs e)
        +void Form1_Load(object sender, EventArgs e)
        +void textBox7_TextChanged(object sender, EventArgs e)
        +void groupBox1_Enter(object sender, EventArgs e)
        +void groupBox5_Enter(object sender, EventArgs e)
        +void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        +void groupBox3_Enter(object sender, EventArgs e)
    }
    class Fazzio {
        +CylinderVolume(): string
        +FuelType(): string
        +Rental_price_DAY(): int
        +Rental_price_MONTH(): int
        +name(): string
        +numberproducts(): int
        +decrease(int unit): void
        +AddProducts(int number): void
    }
    class PCX150 {
        +CylinderVolume(): string
        +FuelType(): string
        +Rental_price_DAY(): int
        +Rental_price_MONTH(): int
        +name(): string
        +numberproducts(): int
        +decrease(int unit): void
        +AddProducts(int number): void
    }
    class YZFR3 {
        +CylinderVolume(): string
        +FuelType(): string
        +Rental_price_DAY(): int
        +Rental_price_MONTH(): int
        +name(): string
        +numberproducts(): int
        +decrease(int unit): void
        +AddProducts(int number): void
    }
    class XMAX {
        +CylinderVolume(): string
        +FuelType(): string
        +Rental_price_DAY(): int
        +Rental_price_MONTH(): int
        +name(): string
        +numberproducts(): int
        +decrease(int unit): void
        +AddProducts(int number): void
    }
    class CSV {
        +SavetoFile(string data): bool
    }
```