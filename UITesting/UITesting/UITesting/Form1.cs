using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UITesting
{
    public partial class Form1 : Form
    {
        //Setting for SQL
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTF2171;User ID=PROJECTF2171;Password=SO36vou$";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        bool loggedin = false;
        string keepUserID;
        bool technician = false;


        public Form1()
        {
            InitializeComponent();
        }

        void SwitchPanel(Panel panelName) {
            pnlLogin.Visible = false;
            pnlCreateTicket.Visible = false;
            pnlProfile.Visible = false;
            pnlViewTicket.Visible = false;
            pnlViewTicketU.Visible = false;
            panelName.Visible = true;
            panelName.Dock = DockStyle.Fill;
        }


        private DataTable readDataAdapter(string sql)
        {
            ConnectSQLServer();
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        private void ConnectSQLServer()
        {
            connection = new SqlConnection(connectionstring);
            connection.Open();
        }

        private bool isIT(string userid)
        {
            string sql = "SELECT DepartmentID FROM Employee WHERE EmployeeID = '" + userid + "'";

            DataTable dt = readDataAdapter(sql);
            if ("3" == dt.Rows[0][0].ToString())
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        private void getUserInfo() {
            ConnectSQLServer();
            string sql = "SELECT Employee.Name, Email, PhoneNumber, Employee.DepartmentID , Employee.Role FROM Employee inner join Department on Employee.DepartmentID = Department.DepartmentID WHERE Employee.EmployeeID ='" + keepUserID + "'";
            DataTable dt = readDataAdapter(sql);
            lblProfileUserID.Text = keepUserID;
            lblProfileName.Text = dt.Rows[0][0].ToString();
            txtProfileEmail.Text = dt.Rows[0][1].ToString();
            txtProfilePhone.Text = dt.Rows[0][2].ToString();
            cmbProfileDept.SelectedIndex = Convert.ToInt32(dt.Rows[0][3]) - 1;
            txtProfileRole.Text = dt.Rows[0][4].ToString();
            connection.Close();

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {

            string sql = "";
            if (txtLoginUserID.Text != "" && txtLoginPassword.Text != "")
            {
                sql = "SELECT * FROM [User] WHERE UserID ='" + txtLoginUserID.Text + "' and Password='" + txtLoginPassword.Text + "';";
                //233 //170591 //988 //642116
            }
            else
            {
                MessageBox.Show("Make sure you type your ID and password.");
                return;
            }
            ConnectSQLServer();
            DataTable dt = readDataAdapter(sql);
            if (dt.Rows.Count > 0)
            {
                connection.Close();
                MainMenuStrip.Visible = true;
                if (isIT(txtLoginUserID.Text))
                {
                    MessageBox.Show("Login success! as IT ");
                    loggedin = true;
                    keepUserID = txtLoginUserID.Text;
                    technician = true;
                    getUserInfo();
                    SwitchPanel(pnlViewTicket);

                }
                else
                {
                    MessageBox.Show("Login success! as normal user");
                    loggedin = true;
                    technician = false;
                    keepUserID = txtLoginUserID.Text;
                    getUserInfo();
                    showTicketsInGridWithEmploID(dgvViewTicketU, 0);
                    showTicketsInGridWithEmploID(dgvClosedTickets, 1);
                    SwitchPanel(pnlCreateTicket);
                }
            }
            else
            {
                connection.Close();
                MessageBox.Show("Invalid Login please try it again.");
            }


        }
        
        private void showTicketsInGrid(DataGridView gridName, int openclose) {
            ConnectSQLServer();
            string sql = "SELECT * FROM Ticket WHERE OpenClose =" + openclose + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            da.Fill(ds);
            gridName.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void showTicketsInGridWithEmploID(DataGridView gridName, int status ) {
            ConnectSQLServer();
            string sql = "SELECT * FROM Ticket WHERE EmployeeID= '" + keepUserID + "' and OpenClose = '" + status + "'" ;
            SqlDataAdapter daa = new SqlDataAdapter(sql, connection);
            var dss = new DataSet();
            daa.Fill(dss);
            gridName.DataSource = dss.Tables[0];
            connection.Close();
        }

        private void showTicketIDInCmbList() {
            ConnectSQLServer();
            string sql = "SELECT TicketID FROM Ticket WHERE OpenClose = 0";
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                cmbViewTicket.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
        }

        private void cancelTicket() {
            cmbTicketDept.SelectedIndex = -1;
            txtTicketIssue.Text = "";
            txtTicketTitle.Text = "";
        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchPanel(pnlLogin);

            MainMenuStrip.Visible = false;
            ConnectSQLServer();
            string sql = "SELECT Name FROM Department";
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                cmbTicketDept.Items.Add(datareader[0].ToString());
                cmbProfileDept.Items.Add(datareader[0].ToString());
            }

            datareader.Close();
            connection.Close();


            showTicketsInGrid(dgvViewTicket, 0);

            showTicketIDInCmbList();
            connection.Close();

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
                SwitchPanel(pnlProfile);
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            ConnectSQLServer();
            string sql = "UPDATE Employee SET Email=@email,PhoneNumber=@phone, Role=@role, DepartmentID=@deptindex WHERE EmployeeID='" + keepUserID + "'";

            if (txtProfilePhone.Text != "" && cmbProfileDept.SelectedIndex > -1 && txtProfileEmail.Text != "" && txtProfileRole.Text != "")
            {


                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@email", txtProfileEmail.Text);
                command.Parameters.AddWithValue("@phone", txtProfilePhone.Text);
                command.Parameters.AddWithValue("@role", txtProfileRole.Text);
                command.Parameters.AddWithValue("@deptindex", cmbProfileDept.SelectedIndex + 1);

                int answer = command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Successfully updated your info");

            }
            connection.Close();
            getUserInfo();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchPanel(pnlCreateTicket);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchPanel(pnlLogin);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            ConnectSQLServer();
            string keepTicketID = dgvViewTicket.CurrentRow.Cells[0].Value.ToString();
            string sql = "UPDATE Ticket SET OpenClose=1, Comments=@comment WHERE TicketID='" + keepTicketID + "'";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@comment", txtComments.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Successfully closed the ticket");
            showTicketsInGridWithEmploID(dgvViewTicketU, 0);
            showTicketsInGridWithEmploID(dgvClosedTickets, 1);
        }

        private void dgvViewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtViewIssue.Text =  dgvViewTicket.CurrentRow.Cells[4].Value.ToString();
        }

        private void exiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbViewTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Ticket WHERE TicketID='" + cmbViewTicket.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            da.Fill(ds);
            dgvViewTicket.DataSource = ds.Tables[0];
            connection.Close();
            dgvViewTicket.SelectAll();
            txtViewIssue.Text = dgvViewTicket.CurrentRow.Cells[4].Value.ToString();

        }

        private void viewTicketITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (technician)
                SwitchPanel(pnlViewTicket);
            else
                SwitchPanel(pnlViewTicketU);
        }

        private void tbnShowAllTicket_Click(object sender, EventArgs e)
        {
            ConnectSQLServer();
            string sql = "SELECT * FROM Ticket WHERE OpenClose = 0";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            da.Fill(ds);
            dgvViewTicket.DataSource = ds.Tables[0];
            connection.Close();
            txtViewIssue.Text = "";
            cmbViewTicket.SelectedIndex = -1;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenuStrip.Visible = false;
            SwitchPanel(pnlLogin);
            keepUserID = "";
        }

        

        

        private void btnTicketSubmit_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Ticket ( EmployeeID, DepartmentID, Title, Issue, OpenClose) VALUES (@userid, @departmentid,@title, @issue, @openclose)";


            if (txtTicketTitle.Text != "" && cmbTicketDept.SelectedIndex != -1 && txtTicketIssue.Text != "")
            {
                string deptID = (cmbTicketDept.SelectedIndex + 1).ToString();
                ConnectSQLServer();
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userid", keepUserID);
                command.Parameters.AddWithValue("@departmentid", deptID);
                command.Parameters.AddWithValue("@title", txtTicketTitle.Text);
                command.Parameters.AddWithValue("@issue", txtTicketIssue.Text);
                command.Parameters.AddWithValue("@openclose", 0);

                int answer = command.ExecuteNonQuery();
                if (answer > 0)
                {
                    MessageBox.Show("Successfully submitted your ticket");
                    showTicketsInGrid(dgvViewTicket, 0);
                    showTicketsInGridWithEmploID(dgvViewTicketU, 0);
                    showTicketsInGrid(dgvViewTicket, 0);
                    showTicketIDInCmbList();
                    cancelTicket();
                }
                else
                {
                    MessageBox.Show("Failed to submit your ticket");
                }

            }
            else
            {
                MessageBox.Show("Make sure you type the title and issue and choose the department that you want to send to.");
            }
        }

        private void dgvClosedTickets_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtViewIssueU.Text = "Comments: " + dgvClosedTickets.CurrentRow.Cells[7].Value.ToString() + "";
        }

        private void dgvViewTicketU_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtViewIssueU.Text = dgvViewTicketU.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnTicketCancel_Click_1(object sender, EventArgs e)
        {
            cancelTicket();
        }
    }
}
