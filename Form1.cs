using StudentClassLibrary;
using System.Runtime.CompilerServices;

namespace MMG
{
    public partial class Form1 : Form
    {
        List<Student> listStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Aj_Click(object sender, EventArgs e)
        {
            this.tblist.Text = "";
            string input_name = this.tbname.Text;
            string input_Student_id = this.tbstudent.Text;
            Student newStudent = new Student(input_name, input_Student_id);
            this.listStudents.Add(newStudent);
            for (int i = 0; i < this.listStudents.Count; i++)
            {

                Student currentStudent = this.listStudents[i];
                string display = currentStudent.displayInfo();
                this.tblist.Text += display;
                this.tbname.Text = "";
                this.tbstudent.Text = "";

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string save_data = this.tblist.Text;
            File.WriteAllText("D:/ text.csv", save_data);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("D:/ text.csv");
            // to do
            // Add data to listStudents
            for (int i = 0; i < data.Length; i++)
            {

                string idata = data[i];

                //add idata to listStudent
                //using SubString

            }
            // Display data to tblistofStudent
            displayData();
        }

        private void displayData()
        {
            for (int i = 0; i < this.listStudents.Count(); i++)
            {

                Student currentStudent = this.listStudents[i];
                string display = currentStudent.displayInfo();
                this.tblist.Text += display;
                //to do
                // [] Fix display data from list

            }
        }
    }
}