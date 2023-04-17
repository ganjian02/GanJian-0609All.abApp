using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss3
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        public MDIParent MDIParent { get; internal set; }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Famale";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "Married";
            else Status = "Unmarried";
            try//lblCountry
            {
                CustomerValidation objVal = new CustomerValidation();
                objVal.CheckCustomerName(txtName.Text);

                frmCustomerPreview objPreview = new frmCustomerPreview();
                objPreview.SetValues(txtName.Text, cmbCountry.Text, Gender, Hobby, Status);

                objPreview.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“customerDBDataSet.Customer”中。您可以根据需要移动或移除它。
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            LoadCustomer(dtgCustomer);
        }

        private void LoadCustomer(DataGridView dtgCustomer)
        {
            string strConnection = "Data Source=.;Initial Catalog=CustomerDB1;Persist Security Info=True;User ID=sa;Password=20020321;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strCommand = "Select * From Customer";
            SqlCommand objCommad = new SqlCommand(strCommand, objConnection);

            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommad);
            objAdapter.Fill(objDataSet);
            dtgCustomer.DataSource = objDataSet.Tables[0];
            objConnection.Close();
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Famale";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "1";
            else Status = "0";

            string strConnection = "Data Source=.;Initial Catalog=CustomerDB1;Persist Security Info=True;User ID=sa;Password=20020321;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strCommand="insert into Customer(CustomerName,Country,Gender,Hobby,Married) Values(' " + txtName.Text + " ',' "  
                + cmbCountry.Text  +" ',' "+ Gender + " ',' " + Hobby + " ',"+ Status + " )";
            SqlCommand  objCommand= new SqlCommand(strCommand, objConnection);
            objCommand.ExecuteNonQuery();

            objConnection.Close();
            LoadCustomer();
                
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearForm();
            string id = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            displayCustomer(id);
        }
        private void clearForm()
        {
            txtName.Text = "";
            cmbCountry.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            chkPainting.Checked = false;
            chkReading.Checked = false;
            radioMarried.Checked = false;
            radioUnrried.Checked = false;
        }
        
        private void displayCustomer(string id)
        {
            string strConnection = "Data Source=.;Initial Catalog=CustomerDB1;Persist Security Info=True;User ID=sa;Password=20020321;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string StrCommand = "Select * From Customer where id =" + id;
            SqlCommand objCommand = new SqlCommand(StrCommand, objConnection);

            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);
            objConnection.Close();
            lblID.Text = objDataSet.Tables[0].Rows[0][0].ToString().Trim();
            txtName.Text = objDataSet.Tables[0].Rows[0][1].ToString().Trim();
            cmbCountry.Text= objDataSet.Tables[0].Rows[0][2].ToString().Trim();
            string Gender= objDataSet.Tables[0].Rows[0][3].ToString().Trim();
            if (Gender.Equals("Male")) radioMale.Checked = true;
            else radioFemale.Checked = true;
            string Hobby = objDataSet.Tables[0].Rows[0][4].ToString().Trim();
            if (Hobby.Equals("Reading")) chkReading.Checked = true;
            else chkPainting.Checked = true;
            string Married = objDataSet.Tables[0].Rows[0][5].ToString().Trim();
            if (Married.Equals("true")) radioMarried.Checked = true;
            else radioUnrried.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Famale";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "1";
            else Status = "0";

            string strConnection = "Data Source=.;Initial Catalog=CustomerDB1;Persist Security Info=True;User ID=sa;Password=20020321;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            string strCommand = "UPDATE Customer SET CustomerName =@CustomerName, Country=@Country,"+" Gender=@Gender,Hobby=@Hobby,Married= @Married WHERE id=@id";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.Parameters.AddWithValue("@CustomerName", txtName.Text.Trim());
            objCommand.Parameters.AddWithValue("@Country", cmbCountry.SelectedIndex.ToString().Trim());
            objCommand.Parameters.AddWithValue("@Gender", Gender);
            objCommand.Parameters.AddWithValue("@Hobby", Hobby);
            objCommand.Parameters.AddWithValue("@Married", Status);
            objCommand.Parameters.AddWithValue("@id", lblID.Text.Trim());
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            clearForm();
            LoadCustomer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConnection = "Data Source=.;Initial Catalog=CustomerDB1;Persist Security Info=True;User ID=sa;Password=20020321;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strCommand ="Delete from Customer where id = ' "+lblID.Text+" '";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.ExecuteNonQuery();

            objConnection.Close();
            clearForm();
            LoadCustomer();
        }
    }

    }
