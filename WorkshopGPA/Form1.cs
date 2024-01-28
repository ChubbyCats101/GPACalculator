namespace WorkshopGPA
{
    public partial class Form1 : Form
    {
        private GPACalculator gPACalculator = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string studentName = name_textBox.Text;
            double score = double.Parse(score_textBox.Text);

         
            Student newStudent = new Student(studentName, score);
            gPACalculator.setStudent(newStudent);

            
            double AVGScore = gPACalculator.getAVGscore();
            double MaxScore = gPACalculator.getHighestScore();
            string MaxNM = gPACalculator.getHighestName();
            string MinNM = gPACalculator.getLowestName();
            double MinScore = gPACalculator.getLowestScore();
            double AVGGPA = gPACalculator.getGPA(score);


            AVG_Score.Text = AVGScore.ToString();
            MaxSC.Text = MaxScore.ToString();
            MaxName.Text = MaxNM.ToString();
            MinName.Text = MinNM.ToString();
            MinSC.Text = MinScore.ToString();
           GPA_textbox.Text = AVGGPA.ToString();
        }
    }
}
