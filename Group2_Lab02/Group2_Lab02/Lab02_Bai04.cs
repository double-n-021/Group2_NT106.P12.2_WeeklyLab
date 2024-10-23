using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Lab02
{
    public partial class Bai04 : Form
    {
        private List<Student> students = new List<Student>();
        private int currentStudent = 1;
        private int hadRead = 0;
        private int hadWrite = 0;
        public Bai04()
        {
            InitializeComponent();
        }

        private void btAddFile_Click(object sender, EventArgs e)
        {
            hadRead = 0;
            if (!IsValidInput())
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            }
            var student = new Student
            {
                Name = tbWName.Text,
                ID = int.Parse(tbWID.Text),
                Phone = tbWPhone.Text,
                Course1 = float.Parse(tbWCourse1.Text),
                Course2 = float.Parse(tbWCourse2.Text),
                Course3 = float.Parse(tbWCourse3.Text),
            };
            student.CalculateAverage();
            students.Add(student);
            richTextBox1.AppendText($"{student.Name}\n{student.ID}\n{student.Phone}\n{student.Course1}\n{student.Course2}\n{student.Course3}\n{student.Average.ToString("F2")}\n\n");
        }

        private bool IsValidInput()
        {
            if (tbWPhone.Text.Length != 10 || !tbWPhone.Text.StartsWith("0"))
                return false;
            if (tbWID.Text.Length != 8)
                return false;
            if (!float.TryParse(tbWCourse1.Text, out float course1) || course1 < 0 || course1 > 10)
                return false;
            if (!float.TryParse(tbWCourse2.Text, out float course2) || course2 < 0 || course2 > 10)
                return false;
            if (!float.TryParse(tbWCourse3.Text, out float course3) || course3 < 0 || course3 > 10)
                return false;
            return true;
        }

        private void WriteFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, students);
                MessageBox.Show("Dữ liệu đã được ghi vào " + filename);
                hadWrite = 1;
            }
        }

        private void btWriteFile_Click(object sender, EventArgs e)
        {
            WriteFile("input4.txt");
        }
        private void DisplayStudentInTextBoxes(Student student)
        {
            tbRName.Text = student.Name;
            tbRName.Show();
            tbRID.Text = student.ID.ToString();
            tbRID.Show();
            tbRPhone.Text = student.Phone;
            tbRPhone.Show();
            tbRCourse1.Text = student.Course1.ToString();
            tbRCourse1.Show();
            tbRCourse2.Text = student.Course2.ToString();
            tbRCourse2.Show();
            tbRCourse3.Text = student.Course3.ToString();
            tbRCourse3.Show();
            tbRAverage.Text = student.Average.ToString("F2");
            tbRAverage.Show();
        }

        private void btReadFile_Click(object sender, EventArgs e)
        {
            if (hadWrite == 0)
            {
                MessageBox.Show("Bạn cần ghi dữ liệu trước khi đọc dữ liệu.");
                return;
            }

            if (File.Exists("input4.txt") && hadWrite == 1)
            {
                hadRead = 1;
                using (FileStream fs = new FileStream("input4.txt", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    students = (List<Student>)formatter.Deserialize(fs);
                    MessageBox.Show("Đã đọc dữ liệu từ input4.txt");
                    WriteFile("output4.txt");
                }
                DisplayStudentInTextBoxes(students[currentStudent - 1]);
                hadWrite = 0;
            }
        }

        private void SerializeData(string fileName, List<Student> students)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, students);
            }
        }

        private List<Student> DeserializeData(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Student>)formatter.Deserialize(fs);
                }
            }
            return null;
        }


        private void btBack_Click(object sender, EventArgs e)
        {
            if (currentStudent > 1 && hadRead == 1)
            {
                currentStudent--;
                lbCount.Text = currentStudent.ToString();
                lbCount.Show();
                DisplayStudentInTextBoxes(students[currentStudent - 1]);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (hadRead == 1 && currentStudent < students.Count)
            {
                currentStudent++;
                lbCount.Text = currentStudent.ToString();
                lbCount.Show();
                DisplayStudentInTextBoxes(students[currentStudent - 1]);
            }
        }
    }

    [Serializable]

    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public float Course1 { get; set; }
        public float Course2 { get; set; }
        public float Course3 { get; set; }
        public float Average { get; set; }

        public void CalculateAverage()
        {
            Average = (Course1 + Course2 + Course3) / 3;
        }
    }
}
