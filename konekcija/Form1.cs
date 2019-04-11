using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace konekcija
{
    public partial class Form1 : Form
    {
        const string databaselocation = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\ASManager\\ASRes\\ASConfig.mdb;Persist Security Info = False;";
        List<string> tables = new List<string>();
        public Form1()
        {
            InitializeComponent();
            BAZA.Click += new EventHandler(Button1_Click);
        }
        private void Button1_Click(object sender, EventArgs e)

        {
            labela.Text = "Hello ";
            labela.Refresh();
            MessageBox.Show("zdravo");

            GetTableNames();
            const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\ASManager\\ASRes\\ASConfig.mdb;Persist Security Info = False;";
            const string connectionStringDest = "Data Source = PD; Initial Catalog=Moja;Integrated Security=SSPI;";
             using (var sourceConnection = new OleDbConnection(connectionString))
             {
                 sourceConnection.Open();

                 using (var destinationConnection = new SqlConnection(connectionStringDest))
                 {
                    MessageBox.Show("SQL");
                    destinationConnection.Open();
                    MessageBox.Show("SQL");
                    foreach (string tbl in tables)
                    {
                        if (tbl == "Cardholder")
                        {
                            MessageBox.Show("Cardholder ulaz");
                            
                            var commandSourceData1 = new OleDbCommand("Select MAX(CardholderID) from " + tbl, sourceConnection);
                            var commandSourceData2 = new OleDbCommand("Select COUNT(CardholderID) from " + tbl, sourceConnection);
                            int m1 = (int)commandSourceData1.ExecuteScalar();
                            int n1= (int)commandSourceData2.ExecuteScalar();
                            MessageBox.Show(" maksimalni "+ m1 + " ,broj redova "+ n1);
                            
//                            var commandSourceData = new OleDbCommand("Select CardholderID, Name, FirstName, LastName, Gender from " + tbl, sourceConnection);
//                            var reader = commandSourceData.ExecuteReader();
                            using (var bulkCopy = new SqlBulkCopy(destinationConnection))
                            {

                                var commandDestinationData1 = new SqlCommand("Select MAX(CardholderID) from " + tbl, destinationConnection);
                                var commandDestinationData2 = new SqlCommand("Select COUNT(CardholderID) from " + tbl, destinationConnection);
                                int n2 = (int)commandDestinationData2.ExecuteScalar();
                                if (n2!=0) {
                                    int m2 = (int)commandDestinationData1.ExecuteScalar();
                                    MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);
                                    if (n1 != n2 && m1 > m2)
                                    {
                                        var commandSourceData = new OleDbCommand("Select CardholderID, Name, FirstName, LastName, Gender from " + tbl + " where CardholderiD <" + m1 + " and CardholderID >" + m2, sourceConnection);
                                        var reader = commandSourceData.ExecuteReader();
                                        MessageBox.Show("ima novih kardholdera,kopira se");
                                        bulkCopy.DestinationTableName = "dbo." + tbl;
                                        try { bulkCopy.WriteToServer(reader); }
                                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                                        finally { reader.Close(); }
                                        n2 = n2 + 1;
                                    }
                                    else {
                                    }
                                }
                                else {
                                    var commandSourceData = new OleDbCommand("Select CardholderID, Name, FirstName, LastName, Gender from " + tbl, sourceConnection);
                                    var reader = commandSourceData.ExecuteReader();
                                    MessageBox.Show("ima novih kardholdera,kopira se");
                                    bulkCopy.DestinationTableName = "dbo." + tbl;
                                    try { bulkCopy.WriteToServer(reader); }
                                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                                    finally { reader.Close(); }
                                }

                            }
                            MessageBox.Show("Cardholder izlaz");
                            return;
                        }
                        else

                        {
                            MessageBox.Show("nije cardholder");


                        }

                    }
                 }
             } 


        }
        
        
        public List<string> GetTableNames()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(databaselocation))
                {
                    con.Open();
                    //DataTable schema = con.GetSchema("Columns");
                    //foreach (DataRow row in schema.Rows)
                    //{
                    //    tables.Add(row.Field<string>("TABLE_NAME"));
                    //}
                foreach (DataRow r in con.GetSchema("Tables").Select("TABLE_TYPE = 'TABLE'"))
                    {
                        tables.Add(r["TABLE_NAME"].ToString());
                    }
                    return tables;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return tables;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }

        private void btnTimeReport_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.ShowDialog();
        }
    }
}
