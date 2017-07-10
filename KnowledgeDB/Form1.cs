using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Novacode;
using System.IO;
namespace KnowledgeDB
{
    public partial class Form1 : Form
    {
                    
        public Form1()
        {
            InitializeComponent();
        }


        public static void CreateDocx(String filename, String TableName)
        {


            // A formatting object for our headline:
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Calibri Light");
            headLineFormat.Size = 18D;
            headLineFormat.Position = 12;

            // A formatting object for our normal paragraph text:
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 10D;

            String filepath;
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), (filename + ".docx"));
            //System.IO.Path.Combine(My.Computer.FileSystem.SpecialDire
            //dim filepath as String filePath= Sys.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            // Modify to suit your machine:


            // Create a document in memory:
            var doc = DocX.Create(filepath);

            StringBuilder query = new StringBuilder();
            query.Append("SELECT NoteName, NoteContents From ");
            query.Append(TableName);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;

            con.Open();

            SqlCommand cmd = new SqlCommand(query.ToString(), con);

            SqlDataReader rder = cmd.ExecuteReader();

            while (rder.Read())
            {
                doc.InsertParagraph((rder["NoteName"].ToString()), false, headLineFormat);
                doc.InsertParagraph((rder["NoteContents"].ToString()), false, paraFormat);




            }
            rder.Close();


            // Save to the output directory:
            doc.Save();
        }

          public static void CreateDoc(String filename, String TableName)
        {

            // A formatting object for our headline:
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Calibri Light");
            headLineFormat.Size = 14D;
            headLineFormat.Position = 12;
            headLineFormat.FontColor = (Color.Teal);
            // A formatting object for our normal paragraph text:
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 10D;
  

            
            String filepath;
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), (filename + ".doc" ));
                //System.IO.Path.Combine(My.Computer.FileSystem.SpecialDire
                //dim filepath as String filePath= Sys.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            // Modify to suit your machine:
            

            // Create a document in memory:
            var doc = DocX.Create(filepath);

            StringBuilder query = new StringBuilder();
            query.Append("SELECT NoteName, NoteContents From ");
            query.Append(TableName);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;

            con.Open();

            SqlCommand cmd = new SqlCommand(query.ToString(), con);

            SqlDataReader rder = cmd.ExecuteReader();

            while (rder.Read())
            {
          doc.InsertParagraph((rder["NoteName"].ToString()), false, headLineFormat);
            //  headline.Color(System.Drawing.Color.Azure);


                doc.InsertParagraph( (rder["NoteContents"].ToString()), false, paraFormat);
                



            }
            rder.Close();
            

            // Save to the output directory:
            doc.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;

 
                con.Open();
                String tablename = lstCategories.SelectedItem.ToString();
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO ");
                query.Append(tablename);
                query.Append(" ( NoteName , NoteContents) VALUES (@Name , @Contents)");
                SqlCommand command = new SqlCommand(query.ToString(), con);
                command.Parameters.AddWithValue("@Name", txtNoteName.Text);
                command.Parameters.AddWithValue("@Contents", txtNoteContents.Text);

                command.ExecuteNonQuery();
                con.Close();
            }
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem == null)
            {
                MessageBox.Show("Please select a Category");



            }
            else
            {

                lstNotes.Items.Clear();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;
                con.Open();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT * FROM ");
                query.Append(lstCategories.SelectedItem);
                SqlCommand cmd = new SqlCommand(query.ToString(), con);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lstNotes.Items.Add((String)rdr["NoteName"]);
                }
            }


        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItem == null)
                 {
                MessageBox.Show("Please select a note");

            }
            else
            {
                String TableName = lstCategories.SelectedItem.ToString();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT");
                query.Append(" NoteName ");
                query.Append(", ");
                query.Append(" NoteContents");
                query.Append(" From ");
                query.Append(TableName);
                query.Append(" Where");
                query.Append(" ID ");
                query.Append("=");
                query.Append("@id");


                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;

                con.Open();

                SqlCommand cmd = new SqlCommand(query.ToString(), con);
                cmd.Parameters.AddWithValue("@id", lstNotes.SelectedIndex + 1);

                SqlDataReader rder = cmd.ExecuteReader();

                while (rder.Read())
                {
                    txtNoteContents.Text = (rder["NoteContents"].ToString());
                    txtNoteName.Text = (rder["NoteName"].ToString());


                }
                rder.Close();
                con.Close();
            }
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetNotes_Click()
        {
            lstNotes.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;
            con.Open();
           StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM ");
            query.Append(lstCategories.SelectedItem);
             SqlCommand cmd = new SqlCommand(query.ToString(), con); 
           
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lstNotes.Items.Add((String)rdr["NoteName"]);
            }

        
        }

        private void btnEditNote_Click(object sender, EventArgs e)
        {
            String tablename = lstCategories.SelectedItem.ToString();
            SqlConnection con = new SqlConnection();
            StringBuilder query = new StringBuilder();
            query.Append("UPDATE ");
            query.Append(tablename);
            query.Append(" SET ");
            query.Append("NoteName");
            query.Append(" = ");
            query.Append(" @Name");
            query.Append(" , ");
            query.Append("NoteContents");
            query.Append(" = ");
            query.Append("@Contents");
            query.Append(" ");
            query.Append("WHERE");
            query.Append(" ");
            query.Append("ID");
            query.Append(" = ");
            query.Append("@id");
            con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;
            con.Open(); 
            //Opening and closing the connection every iteration can be inefficient.
            //In order to fix this, making starting the connection on form opening and closing on form close
            //Should make it much more efficient.
            SqlCommand cmd = new SqlCommand(query.ToString(), con); 
            cmd.Parameters.AddWithValue("@id", lstNotes.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@Name", txtNoteName.Text);
            cmd.Parameters.AddWithValue("@Contents", txtNoteContents.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            btnGetNotes_Click();
            txtNoteContents.Text = "";
            txtNoteName.Text = "";
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            lstCategories.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.KnowledgeBaseConnectionString;
            con.Open();
            DataTable dt = con.GetSchema("Tables"); //Gets the tables
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                lstCategories.Items.Add(tablename);
            }
        }

        private void btnExportToDocx_Click(object sender, EventArgs e)
        {

            
        }


          private void btnCreateCategory_Click(object sender, EventArgs e)
        {
          frmCreateCategory form2 = new frmCreateCategory();

                form2.Show();
        }

          private void btnDoc_Click(object sender, EventArgs e)
          {
              CreateDoc(lstCategories.SelectedItem.ToString(), lstCategories.SelectedItem.ToString());
          }
    }

    }
