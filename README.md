using System; // ใช้งานคลาสและเมธอดพื้นฐานของ C#
using System.Collections.Generic; // ใช้งาน List<T>
using System.Linq; // ใช้สำหรับคำนวณค่าเฉลี่ย, ค่ามากสุด และค่าต่ำสุด
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // ใช้งานฟอร์มและคอนโทรลของ Windows Forms

namespace GPAX // กำหนด namespace ชื่อ GPAX
{
    public partial class Form1 : Form // คลาส Form1 สืบทอดมาจาก Form
    {
        private List<double> gpaxList = new List<double>(); // สร้าง List สำหรับเก็บค่าจำนวนเต็ม
        private GPACalculator calculator = new GPACalculator(); // สร้างอ็อบเจกต์ของ GPACalculator
        
        public Form1()
        {
            InitializeComponent(); // เรียกใช้งานเมธอด InitializeComponent เพื่อกำหนดค่าพื้นฐานของฟอร์ม
        }

        private void button1_Click(object sender, EventArgs e) // เมธอดที่ทำงานเมื่อคลิกปุ่ม
        {
            try
            {
                double gpax = double.Parse(tbGPAx.Text); // แปลงค่าจาก TextBox เป็นตัวเลขทศนิยม
                gpaxList.Add(gpax); // เพิ่มค่า GPAX ลงใน List
                calculator.AddGPAX(gpax); // เพิ่มค่า GPAX ลงใน GPACalculator
                
                UpdateDisplay(); // อัปเดตค่าต่าง ๆ บนหน้าจอ
                tbGPAx.Clear(); // ล้างค่าที่อยู่ใน TextBox
            }
            catch (FormatException) // กรณีที่ผู้ใช้กรอกค่าที่ไม่ใช่ตัวเลข
            {
                MessageBox.Show("please enter a valid GPAX ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException) // กรณีที่ค่าเกินขอบเขตที่สามารถเก็บได้
            {
                MessageBox.Show("GPAX must be between 0 and 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDisplay() // เมธอดที่ใช้สำหรับอัปเดตค่าบนฟอร์ม
        {
            tbGPAx.Text = calculator.CalculateAverageGPAX().ToString("0.00"); // แสดงค่าเฉลี่ย GPAX
            tbCount.Text = calculator.GetCount().ToString(); // แสดงจำนวนค่าที่ป้อน
            tbMax.Text = calculator.GetMaxGPAX().ToString("0.00"); // แสดงค่ามากสุด
            tbMin.Text = calculator.GetMinGPAX().ToString("0.00"); // แสดงค่าต่ำสุด
            tbinputGPA.Text = calculator.CalculateAverageGPAX().ToString(); // แสดงค่าเฉลี่ย GPAX ซ้ำอีกครั้ง
        }

        private void label1_Click(object sender, EventArgs e) // เมธอดที่ทำงานเมื่อคลิก Label1
        {
        }

        private void label3_Click(object sender, EventArgs e) // เมธอดที่ทำงานเมื่อคลิก Label3
        {
        }

        private void tbGPAx_TextChanged(object sender, EventArgs e) // เมธอดที่ทำงานเมื่อ TextBox เปลี่ยนค่า
        {
        }

        private void tbinputGPA_TextChanged(object sender, EventArgs e) // เมธอดที่ทำงานเมื่อ TextBox เปลี่ยนค่า
        {
        }
    }

    internal class GPACalculator // คลาสสำหรับคำนวณ GPAX
    {
        private List<double> gpaxList = new List<double>(); // สร้าง List สำหรับเก็บค่าทศนิยม

        public void AddGPAX(double gpax) // เมธอดสำหรับเพิ่มค่าลงใน List
        {
            gpaxList.Add(gpax);
        }

        public double CalculateAverageGPAX() // เมธอดสำหรับคำนวณค่าเฉลี่ยของ GPAX
        {
            if (gpaxList.Count == 0)
            {
                return 0; // คืนค่า 0 ถ้าไม่มีข้อมูล
            }
            return gpaxList.Average(); // คำนวณค่าเฉลี่ยและส่งค่ากลับ
        }

        public int GetCount() // เมธอดสำหรับคืนค่าจำนวนข้อมูลที่มีใน List
        {
            return gpaxList.Count;
        }

        public double GetMaxGPAX() // เมธอดสำหรับคืนค่ามากสุดของ GPAX
        {
            if (gpaxList.Count == 0)
            {
                return 0;
            }
            return gpaxList.Max(); // คืนค่ามากสุด
        }

        public double GetMinGPAX() // เมธอดสำหรับคืนค่าต่ำสุดของ GPAX
        {
            if (gpaxList.Count == 0)
            {
                return 0;
            }
            return gpaxList.Min(); // คืนค่าต่ำสุด
        }
    }
}
