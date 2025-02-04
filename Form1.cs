namespace GPACalculator1
{
    public partial class Form1 : Form
    {
        private List<double> grades = new List<double>();
        private TextBox tbGpa;
        private TextBox tbGpax;
        private TextBox tbGpaMax;
        private TextBox tbGpaMin;
        private TextBox tbStudentCount;
        private GPACalculator gpaCalculator;

        public Form1()
        {
            InitializeComponent();
            tbGpa = new TextBox();
            tbGpax = new TextBox();
            tbGpaMax = new TextBox();
            tbGpaMin = new TextBox();
            tbStudentCount = new TextBox();
            gpaCalculator = new GPACalculator();
            tbStudentCount.Text = gpaCalculator.GetStudentCount().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbGpa.Text))
                {
                    MessageBox.Show("Please enter a GPA value.");
                    return;
                }

                if (!double.TryParse(tbGpa.Text, out double input))
                {
                    MessageBox.Show("Invalid GPA format. Please enter a numeric value.");
                    tbGpa.Clear();
                    return;
                }
                if (input < 0.00 || input > 4.00)
                {
                    MessageBox.Show("GPA must be between 0.00 and 4.00.");
                    tbGpa.Clear();
                    return;
                }

                gpaCalculator.SetGPA(input);
                UpdateUI();
                tbGpa.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                tbGpa.Clear();
            }
        }

        private void DisplayResults()
        {
            if (grades.Count == 0)
            {
                MessageBox.Show("ไม่มีข้อมูลเกรด");
                return;
            }

            double maxGrade = grades.Max();
            double minGrade = grades.Min();
            double gpaX = grades.Average();
            int numberOfStudents = grades.Count;


            label1.Text = $"GPAx: {gpaX:F2}";
            label2.Text = $"จำนวนคน: {numberOfStudents}";
            label3.Text = $"คะแนนสูงสุด: {maxGrade:F2}";
            label4.Text = $"คะแนนต่ำสุด: {minGrade:F2}";
            double gpa = grades.Average();
            MessageBox.Show($"Your GPA is {gpa:F2}");
        }

        private void UpdateUI()
        {
            tbGpax.Text = gpaCalculator.GetGPAx().ToString("F2");
            tbGpaMax.Text = gpaCalculator.GetMaxGPA().ToString("F2");
            tbGpaMin.Text = gpaCalculator.GetMinGPA().ToString("F2");
            tbStudentCount.Text = gpaCalculator.GetGPAListCount().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbGpa.Clear();
            tbGpax.Clear();
            tbGpaMax.Clear();
            tbGpaMin.Clear();
            tbStudentCount.Clear();
            gpaCalculator = new GPACalculator(); // Reset GPACalculator
            MessageBox.Show("All data has been cleared successfully!");
        }
    }
}
