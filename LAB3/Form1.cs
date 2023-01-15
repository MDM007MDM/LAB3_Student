using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;

            //create Student object
            //Student student0 = new Student("James" , 2000 , "J007" , 187 , 2 , "CIS");
            //Student student1 = new Student("Joy" , 2001 , "J008" , 159 , 3 , "EBM");

            //add value to object attribute
            //student0._name = "James";
            //student0._BirthYear = 2000;
            //student1._name = "Joy";
            //student1._BirthYear = 2001;

            //get value from object attribute
            //textboxname.Text = student0._name;
            //textboxbirthyear.Text = student0._BirthYear.ToString();
            //textboxid.Text = student0._id;
            //textboxhight.Text = student0._Hight.ToString();
            //textboxgrade.Text = student0._Grade.ToString();
            //textboxbranch.Text = student0._Branch.ToString();

            //calculate obj age
            //textboxage.Text = student0.myAge().ToString();
        }
        List<Student> students = new List<Student>();
        List<double> allgrade = new List<double>();
        private void butsubmit_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = textboxname.Text;
            String id = textboxid.Text;
            String birthyear = textboxbirthyear.Text;
            String age = textboxage.Text;
            String hight = textboxhight.Text;
            String grade = textboxgrade.Text;
            String Branch = textboxbranch.Text;

            //create obj from Student
            Student std = new Student(name, id, int.Parse(birthyear), int.Parse(age), int.Parse(hight), int.Parse(grade), Branch);
            dataGridView1.Rows.Add(std._name,
                std._id,
                std._BirthYear.ToString(),
                std._age.ToString(),
                std._Hight.ToString(),
                std._Grade.ToString(),
                std._Branch
            );
            students.Add(std);
            allgrade.Add(std._Grade);
            allgrade.Sort();

            MaxG.Text = "คะแนนสูงสุดคือ " + allgrade.Last().ToString();
            MinG.Text = "คะแนนต่ำสุดคือ " + allgrade.First().ToString();

            allstd.Text = "จำนวนนักเรียนทั้งหมด " + students.Count.ToString() + " คน";

            //clear textbox
            this.textboxname.Text = "";
            this.textboxid.Text = "";
            this.textboxbirthyear.Text = "";
            this.textboxage.Text = "";
            this.textboxhight.Text = "";
            this.textboxgrade.Text = "";
            this.textboxbranch.Text = "";
        }
    }
}