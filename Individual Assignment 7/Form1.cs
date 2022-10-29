using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_7
{
    public partial class Form1 : Form
    {
        string[] student_answers;
        string[] right_answers_array = new string[] {"b","d","a","a","c","a","b","a","c","d","b","c","d","a","d","c","c","b","d","a"};
        int right_answers_number;
        int wrong_answers_number;
        List<string> wrong_student_answers_list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] file_array = read_file();
            student_answers = file_array;
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            for (int index = 0; index < right_answers_array.Length;index++)
            {
                if (student_answers[index] == right_answers_array[index])
                {
                    right_answers_number++;
                }
                else
                {
                    wrong_answers_number++;
                    wrong_student_answers_list.Add((index+1).ToString());

                    if (!wrong_student_answers_list.Any())
                    {
                        incorrect_list_label.Text = "No wrong answers";
                    }
                    else
                    {
                        incorrect_list_label.Text ="Wrong answers are: "+ String.Join(", ", wrong_student_answers_list.ToArray()); ;
                    }
                }
                
            }
        correct_label.Text = "Answered correctly: " + right_answers_number.ToString(); 
        incorrect_label.Text = "Answered incorrectly: " + wrong_answers_number.ToString();

            if (right_answers_number >= 15)
            {
                passed_label.Text = "You passed the exam";
            }
            else
            {
                passed_label.Text = "You failed the exam";
            }
            
        }
        private void reset()
        {
            String[] file_array = read_file();
            student_answers = file_array;
            right_answers_number = 0;
            wrong_answers_number = 0;
            wrong_student_answers_list = new List<string>();
        }
        private String[] read_file()
        {
            String[] numbers = new String[20];
            int index = 0;
            StreamReader inputFile;
            inputFile = File.OpenText("assignment_7_student_answers.txt");

            while (index<numbers.Length && !inputFile.EndOfStream)
            {
                numbers[index] =inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
            return numbers;
        }
    }
}
