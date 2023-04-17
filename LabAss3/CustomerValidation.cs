using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss3
{
    public partial class CustomerValidation : Form
    {
        public CustomerValidation()
        {
            InitializeComponent();
        }
        public void CheckCustomerName(string customerName)
        {
            if (customerName.Length > 10)
                throw new Exception("Name should be within 10 charecters.");
            else if (customerName =="")
                throw new Exception("Name is required.");
        }
    }
    

}
