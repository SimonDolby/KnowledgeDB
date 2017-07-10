using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 
namespace KnowledgeDB
{
    public partial class frmCreateCategory : Form
    {
        public frmCreateCategory()
        {
            InitializeComponent();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            String tablename = txtCategoryName.Text;
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;
            con.Open();
            StringBuilder query = new StringBuilder();
            query.Append("CREATE TABLE ");
            query.Append(tablename);
            query.Append(" ( ");
            query.Append(" ID int IDENTITY(1,1) PRIMARY KEY");
            query.Append(", ");
            query.Append("NoteName");
            query.Append(" ");
            query.Append("VARCHAR(255)");
            query.Append(", ");
            query.Append("NoteContents");
            query.Append(" ");
            query.Append("VARCHAR(255)");
            query.Append(")");
            SqlCommand command = new SqlCommand(query.ToString(), con);

             
             command.ExecuteNonQuery();
             con.Close(); 
        }

      
    }
}
