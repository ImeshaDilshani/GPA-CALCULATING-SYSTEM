using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_CALCULATOR
{
    public partial class Form1 : Form
    {
        private string grade1;
        private string grade2;
        private string grade3;
        private string grade4;
        private string grade5;
        private string grade6;
        private string grade7;
        private string grade8;
        private int credit1;
        private int credit2;
        private int credit3;
        private int credit4;
        private int credit5;
        private int credit6;
        private int credit7;
        private int credit8;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            double totalGradePoints = 0;

            // Get the input grade values from the form
            grade1 = txtGrade1.Text;
            grade2 = txtGrade2.Text;
            grade3 = txtGrade3.Text;
            grade4 = txtGrade4.Text;
            grade5 = txtGrade5.Text;
            grade6 = txtGrade6.Text;
            grade7 = txtGrade7.Text;
            grade8 = txtGrade8.Text;

            // Get the input credit values from the form
            credit1 = (int)numericUpDownCredit1.Value;
            credit2 = (int)numericUpDownCredit2.Value;
            credit3 = (int)numericUpDownCredit3.Value;
            credit4 = (int)numericUpDownCredit4.Value;
            credit5 = (int)numericUpDownCredit5.Value;
            credit6 = (int)numericUpDownCredit6.Value;
            credit7 = (int)numericUpDownCredit7.Value;  
            credit8 = (int)numericUpDownCredit8.Value;

            double GetGradePoints(string grade)
            {
                switch (grade.ToUpper()) // Assuming the grades are entered in uppercase
                {
                    case "A+": 
                        return 4.2;
                    case "A":
                        return 4.0;
                    case "A-":
                        return 3.7;
                    case "B+":
                        return 3.3;
                    case "B": 
                        return 3.0;
                    case "B-":
                        return 2.7;
                    case "C":
                        return 2.3;
                    case "I":
                        return 0.0;
                    case "F":
                        return 0.0;
                    default: 
                        return 0.0; // Default to 0.0 for invalid grades
                }
            }

            // Calculate the grade points and accumulate total grade points and credits
            totalGradePoints += GetGradePoints(grade1) * credit1;
            totalGradePoints += GetGradePoints(grade2) * credit2;
            totalGradePoints += GetGradePoints(grade3) * credit3;
            totalGradePoints += GetGradePoints(grade4) * credit4;
            totalGradePoints += GetGradePoints(grade5) * credit5;
            totalGradePoints += GetGradePoints(grade6) * credit6;
            totalGradePoints += GetGradePoints(grade7) * credit7;
            totalGradePoints += GetGradePoints(grade8) * credit8;

            int totalCredits = credit1 + credit2 + credit3 + credit4 + credit5 + credit6 + credit7 + credit8;

            double gpa = totalGradePoints / totalCredits;

            MessageBox.Show("your GPA is" +" "+ gpa);



        }
    }
}
