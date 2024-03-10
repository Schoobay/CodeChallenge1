namespace CodeChallenge1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            cmbPosition.SelectedIndex = 0;

        }

        public enum Position
        {
            Regular,
            Manager,
            Nightshift
        }

        public class Employee
        {
            public string Name { get; }
            public Position Position { get; }
            public int TotalHoursWorked { get; set; }
            public int TotalBreakTime { get; private set; }

            public Employee(string name, Position position, int totalHoursWorked)
            {
                Name = name;
                Position = position;
                TotalHoursWorked = totalHoursWorked;

            }

            public int GetHourlyBreak()
            {
                switch (Position)
                {
                    case Position.Regular:
                        return 10;
                    case Position.Manager:
                        return 15;
                    case Position.Nightshift:
                        return 10;
                    default:
                        return 0;
                }
            }

            public int GetAdditionalBreak()
            {
                switch (Position)
                {
                    case Position.Regular:
                        return TotalHoursWorked / 4 * 10;
                    case Position.Manager:
                        return TotalHoursWorked / 4 * 10;
                    case Position.Nightshift:
                        return TotalHoursWorked / 2 * 10;
                    default:
                        return 0;
                }
            }

            public int GetTotalBreak()
            {
                var hourlyBreak = GetHourlyBreak() * TotalHoursWorked;
                TotalBreakTime = hourlyBreak + GetAdditionalBreak();
                return TotalBreakTime;
            }

        }

        private List<Employee> employees;

        public void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;


            if (cmbPosition.SelectedItem == null)
            {
                MessageBox.Show("Please select a position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            
            if (txtName.Text == "" )
            {
                MessageBox.Show("Please enter a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Position position;
            if (Enum.TryParse(cmbPosition.SelectedItem.ToString(), out position))
            {

                int totalHoursWorked = 0;

                totalHoursWorked += Convert.ToInt32(txtMonday.Text);
                totalHoursWorked += Convert.ToInt32(txtTuesday.Text);
                totalHoursWorked += Convert.ToInt32(txtWednesday.Text);
                totalHoursWorked += Convert.ToInt32(txtThursday.Text);
                totalHoursWorked += Convert.ToInt32(txtFriday.Text);
                totalHoursWorked += Convert.ToInt32(txtSaturday.Text);
                totalHoursWorked += Convert.ToInt32(txtSunday.Text);
              


                Employee newEmployee = new Employee(name, position, totalHoursWorked);
                employees.Add(newEmployee);

                lstEmployees.Items.Add($"{newEmployee.Name} - {newEmployee.Position}");


                ClearForm();
            }
            else
            {
                MessageBox.Show("Choose a valid Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {

           

            lstReports.Items.Clear();
            foreach (var employee in employees)

            {

                lstReports.Items.Add($"{employee.Name}'s Work Hours and Breaks:");
                lstReports.Items.Add($"Total Hours Worked: {employee.TotalHoursWorked} hours");

                lstReports.Items.Add($"Breaks:");
                lstReports.Items.Add($"- {employee.GetHourlyBreak()} minutes break per hour");
                lstReports.Items.Add($"- {employee.GetAdditionalBreak()} minutes additional");

                lstReports.Items.Add($"Total Break Time: {employee.GetTotalBreak()} minutes");
                lstReports.Items.Add($"------------------------");
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            cmbPosition.SelectedIndex = 0;
            
            txtMonday.Text = "0";
            txtTuesday.Text = "0";
            txtWednesday.Text = "0";
            txtThursday.Text = "0";
            txtFriday.Text = "0";
            txtSaturday.Text = "0";
            txtSunday.Text = "0";
        }


    }
}
