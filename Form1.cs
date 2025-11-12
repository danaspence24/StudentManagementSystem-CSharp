using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanaSpence_LINQ
{

    public partial class Form1 : Form
    {
        public class Student                                                     // Student class definition
        {
            public int ID { get; set; }
            public string Name { get; set; } = "";
            public string Department { get; set; } = "";
            public double Score { get; set; }

            public Student() { }                                               // Default constructor
            public Student(int id, string name, string department, double score)     // Parameterized constructor
            {
                ID = id;
                Name = name;
                Department = department;
                Score = score;
            }
            public override string ToString() => $"{ID}\t{Name}\t{Department}\t{Score:F1}";       // Override ToString for easy display

        }
        private List<Student> students = new List<Student>                                        
        {
            new Student(101, "Alice", "Computer Science", 85.5),
            new Student(102, "Bob", "Mathematics", 90.0),
            new Student(103, "Charlie", "Physics", 78.0),
            new Student(104, "Diana", "Chemistry", 92.5),
            new Student(105, "Ethan", "Biology", 88.0)
        };                                                                  // List to hold Student objects
        private List<Student> otherStudents = new List<Student>
        {
            new Student(201, "Fiona", "Computer Science", 81.0),
            new Student(202, "George", "Mathematics", 89.5),
            new Student(203, "Hannah", "Physics", 84.0),
        };                                                              // Another list of Student objects

        public Form1()
        {
            InitializeComponent();

            if (comboBoxDepartment.Items.Count == 0)
            {
                comboBoxDepartment.Items.AddRange(new object[]
                {
                    "CS", "Computer Science",
                    "Math", "Mathematics",
                    "Biology", "Chemistry", "Physics", "History"
                });
                comboBoxDepartment.SelectedIndex = 0;
            }
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;        // NEW

            // Show initial data in both grids                                     // NEW
            dataGridViewStudents1.AutoGenerateColumns = true;
            dataGridViewStudents2.AutoGenerateColumns = true;
            dataGridViewStudents1.DataSource = students.ToList();
            dataGridViewStudents2.DataSource = otherStudents.ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var csStudents = students
               .Where(s => string.Equals(s.Department, "Computer Science", StringComparison.OrdinalIgnoreCase)
                        || string.Equals(s.Department, "CS", StringComparison.OrdinalIgnoreCase))
               .ToList();

            dataGridViewStudents1.DataSource = csStudents;
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            var sorted = students.OrderBy(s => s.Score).ToList();
            dataGridViewStudents1.DataSource = sorted;
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            var sorted = students.OrderByDescending(s => s.Score).ToList();
            dataGridViewStudents1.DataSource = sorted;
        }

        private void btnElementMethods_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            listBoxResults.Items.Add($"Element Methods");

            if (students.Count == 0)
            {
                listBoxResults.Items.Add("No students available.");
                return;
            }

            var firstStudent = students.First();
            listBoxResults.Items.Add($"First Student: {firstStudent}");            // First student

            var lastStudent = students.Last();
            listBoxResults.Items.Add($"Last Student: {lastStudent}");              // Last student

            if (students.Count >= 3)
            {
                var thirdStudent = students.ElementAt(2);
                listBoxResults.Items.Add($"Third Student: {thirdStudent}");        // Third student
            }
            else
            {
                listBoxResults.Items.Add("Less than 3 students available.");
            }
        }

        private void btnAggregate_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            listBoxResults.Items.Add($"Aggregation Results");

            if (students.Count == 0)
            {
                listBoxResults.Items.Add("No students available for aggregation.");
                return;
            }
            // Aggregate functions
            int count = students.Count();
            double sum = students.Sum(s => s.Score);
            double average = students.Average(s => s.Score);
            double max = students.Max(s => s.Score);
            double min = students.Min(s => s.Score);

            listBoxResults.Items.Add($"Count: {count}");
            listBoxResults.Items.Add($"Sum of Scores: {sum:F2}");
            listBoxResults.Items.Add($"Average Score: {average:F2}");
            listBoxResults.Items.Add($"Max Score: {max:F2}");
            listBoxResults.Items.Add($"Min Score: {min:F2}");
        }

        private void btnPartition_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            listBoxResults.Items.Add("Partitioning Results:");

            var ordered = students.OrderByDescending(s => s.Score);           // Order students by score descending

            listBoxResults.Items.Add("Top 3 Students:");

            foreach (var student in ordered.Take(3))                          // Take top 3 students
            {
                listBoxResults.Items.Add(student.ToString());
            }

            listBoxResults.Items.Add("Students after skipping top 2:");
            foreach (var student in ordered.Skip(2))                         // Skip top 2 students
            {
                listBoxResults.Items.Add(student.ToString());
            }

            listBoxResults.Items.Add("TakeWhile");
            foreach (var student in ordered.TakeWhile(s => s.Score >= 85))    // TakeWhile example
            {
                listBoxResults.Items.Add(student.ToString());

            }

            listBoxResults.Items.Add("SkipWhile");
            foreach (var student in ordered.SkipWhile(s => s.Score >= 85))    // SkipWhile example
            {
                listBoxResults.Items.Add(student.ToString());
            }
        }

        private void btnSetOps_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            listBoxResults.Items.Add("Set Operations Results:");

            var mergedList = students
                .Concat(otherStudents)                                       // Concatenate two lists
                .GroupBy(s => s.ID)                                          // Group by ID to remove duplicates
                .Select(g => g.First())                                     // Select the first student from each group
                .OrderBy(s => s.ID)                                         // Order by ID
                .ToList();                                                  // Convert to list

            foreach (var student in mergedList)
            {
                listBoxResults.Items.Add(student.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            {
                string idText = txtID.Text.Trim();
                string name = txtName.Text.Trim();
                string department = comboBoxDepartment.Text.Trim();
                string scoreText = txtScore.Text.Trim();

                if (!int.TryParse(idText, out int id))                          // Validate ID input
                {
                    MessageBox.Show("Invalid ID. Please enter a valid integer.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))                           // Validate Name input
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(department))                     // Validate Department input
                {
                    MessageBox.Show("Please select a department.");
                    return;
                }
                if (!double.TryParse(scoreText, out double score))                   // Validate Score input
                {
                    MessageBox.Show("Invalid Score. Please enter a valid number.");
                    return;
                }
                if (score < 0 || score > 100)                                        // Validate Score range
                {
                    MessageBox.Show("Score must be between 0 and 100.");
                    return;
                }
                if (students.Any(s => s.ID == id))                                   // Check for duplicate ID
                {
                    MessageBox.Show("A student with this ID already exists.");
                    return;
                }
                students.Add(new Student(id, name, department, score));             // Add new student to the list

                dataGridViewStudents1.DataSource = null;                           // Refresh DataGridView
                dataGridViewStudents1.DataSource = students;                   // Refresh DataGridView

                txtID.Clear();
                txtName.Clear();
                comboBoxDepartment.SelectedIndex = -1;
                txtScore.Clear();
                txtScore.Text = scoreText;

                txtID.Focus();

            }
        }
    }
}
