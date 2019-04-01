using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;


namespace konekcija
{
    public partial class Form1 : Form
    {
        //lokacija Access baze 
        //ova lokacija se kooristi u fji GetTableNames() kao argumetn OleDbConnection() fje 
        //ovdje je trebalo instalirati microsoft Access Database Engine 2010 ali za 32bitni sistem tacnije sa ovog linka :https://www.microsoft.com/en-us/download/confirmation.aspx?id=13255
        const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\ASManager\\ASRes\\ASConfig.mdb;Persist Security Info = False;";

        // lista(spisak) tabela u Access bazi, ova lista je nadalje vidljiva i u funkciji koja sakuplja imena tabela GetTableNames();
        List<string> tables = new List<string>();
        SqlConnection destinationConnection;
        OleDbConnection sourceConnection;

        public Form1()
        {
            // inicijalizacija same Forme, svih komponenata
            InitializeComponent();
            //dodavanje Event handlera na klik dugmeta button1 
            Button1.Click += new EventHandler(Button1_Click);
        }

        //akcije na klik dugmeta
        private void Button1_Click(object sender, EventArgs e)
        {
            //kada se klikne laabela mjenja ime na Hello, a pojavljuje se poruka sa sadrzajem "zdravo" 
            //ovo je radjeno samo zbog testiranja
            labela.Text = "Hello ";
            labela.Refresh();
            MessageBox.Show("zdravo");

            //sakupljanje imena tabela
            GetTableNames();

            //komunikacija izmedju dvije baze
            //lokacija za SQL server 
            const string connectionStringDest = "Data Source = PD; Initial Catalog=Moja;Integrated Security=SSPI; MultipleActiveResultSets=true;";

            using (sourceConnection = new OleDbConnection(connectionString))
            {
                //otvaranje izvorne baze Access
                sourceConnection.Open();

                //konektovanje na SQL bazu
                using (destinationConnection = new SqlConnection(connectionStringDest))
                {
                    //otvaranje SQL baze
                    destinationConnection.Open();

                    MessageBox.Show("SQL baza otvorena");
                    foreach (string tbl in tables)
                    {
                        if (tbl == "Cardholder")
                        {
                            Cardholder_update(sourceConnection, destinationConnection, tbl);
                            return;
                        }
                        else
                        {
                            if (tbl == "AccessLog")
                            {
                                Logs_update(sourceConnection, destinationConnection, tbl);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("nije cardholder ni AccessLog");
                            }
                        }
                    }
                    sourceConnection.Close();
                    destinationConnection.Close();
                }
            }
        }

            public List<string> GetTableNames()
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(connectionString))
                    {
                        con.Open();

                        //shema koja sadrzi imena tabela u Access bazi
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

            public void Logs_update(OleDbConnection sourceConnection, SqlConnection destinationConnection, string tbl) {
                return;
            }

            public void Cardholder_update(OleDbConnection sourceConnection, SqlConnection destinationConnection, string tbl) {

                MessageBox.Show("Cardholder ulaz");
                // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
                var commandSourceData1 = new OleDbCommand("Select MAX(CardholderID) from " + tbl, sourceConnection);
                var commandSourceData2 = new OleDbCommand("Select COUNT(CardholderID) from " + tbl, sourceConnection);
                int m1 = (int)commandSourceData1.ExecuteScalar();
                int n1 = (int)commandSourceData2.ExecuteScalar();
                MessageBox.Show(" maksimalni " + m1 + " ,broj redova " + n1);

                // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
                var commandDestinationData1 = new SqlCommand("Select MAX(CardholderID) from " + tbl, destinationConnection);
                var commandDestinationData2 = new SqlCommand("Select COUNT(CardholderID) from " + tbl, destinationConnection);
                int n2 = (int)commandDestinationData2.ExecuteScalar();

                //kopiranje
                using (var bulkCopy = new SqlBulkCopy(destinationConnection))
                {
                    //ako je tabela u SQL-u NIJE prazna
                    //problem -----> ako je prazna ne moze da se nadje maximalni CardholderID 
                    if (n2 != 0)
                    {
                        //ako je prazna ne moze da se nadje maximalni CardholderID , pa se tek sada racuna
                        int m2 = (int)commandDestinationData1.ExecuteScalar();
                        MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);

                        // ako broj redova NIJE isti i ako je m1 u accessu veci od m2u SQL kopiraju se oni koji su novi   
                        if (n1 != n2 && m1 > m2)
                        {

                            MessageBox.Show("ima novih kardholdera,kopira se");
                            // iz  access tablel izvlace se podaci(korisnici) koji su novi 
                            var commandSourceData = new OleDbCommand("Select CardholderID, Name, FirstName, LastName, Gender from " + tbl + " where CardholderID <=" + @m1 + " and CardholderID >" + @m2, sourceConnection);

                            // ispisuje se CardholderID koji se dodaje u tabelu
                            var commandSourceData3 = new OleDbCommand("Select CardholderID from " + tbl + " where CardholderID <=" + @m1 + "and CardholderID >" + @m2, sourceConnection);
                            int c = (int)commandSourceData3.ExecuteScalar();
                            MessageBox.Show(" Ubacje se CardholderID " + c);

                            //cita se iz izvorne Access tabele
                            var reader = commandSourceData.ExecuteReader();
                            //ime tabele u SQL bazi
                            bulkCopy.DestinationTableName = "dbo." + tbl;
                            //pisanje u tabelu 
                            try { bulkCopy.WriteToServer(reader); }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                            finally { reader.Close(); }

                        }
                        //brisanje
                        else
                        { }
                    }
                    else
                    {
                        //ako je tabela SQL prazna sve kopiramo 
                        var commandSourceData = new OleDbCommand("Select CardholderID, Name, FirstName, LastName, Gender from " + tbl, sourceConnection);
                        var reader = commandSourceData.ExecuteReader();
                        MessageBox.Show("tabela prazna ----> ima novih kardholdera,kopira se");
                        bulkCopy.DestinationTableName = "dbo." + tbl;
                        try { bulkCopy.WriteToServer(reader); }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally { reader.Close(); }
                    }
                }

                if (n2 != 0)
                {
                    int m2 = (int)commandDestinationData1.ExecuteScalar();
                    MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);
                    if (n1 < n2)
                    {
                        // lista cardholderID-a iz SQL baze

                        SqlDataReader rdr = null;
                        List<int> lista = new List<int>();
                        var commandDestinationData3 = new SqlCommand("Select CardholderID from " + tbl, destinationConnection);
                        rdr = commandDestinationData3.ExecuteReader();
                        while (rdr.Read())
                        {
                            // MessageBox.Show(" "+rdr[0]);
                            lista.Add(rdr.GetInt32(0));
                        }

                        // lista  CardholderId iz Access baze
                        OleDbDataReader Sourcerdr = null;
                        List<int> sourceLista = new List<int>();
                        var commandSourceData3 = new OleDbCommand("Select CardholderID from " + tbl, sourceConnection);
                        Sourcerdr = commandSourceData3.ExecuteReader();
                        while (Sourcerdr.Read())
                        {
                            // MessageBox.Show(" "+rdr[0]); 
                            sourceLista.Add(Sourcerdr.GetInt32(0));
                        }
                        //for (int i = 0; i < sourceLista.Count; i++)
                        //MessageBox.Show(" " + sourceLista[i]);
                        var firstNotSecond = lista.Except(sourceLista).ToList();
                        MessageBox.Show(" proslo");
                        //var commandDestinationData4= new SqlCommand("Select * from "+tbl, destinationConnection);
                        Sourcerdr.Close();

                        MessageBox.Show(" proslo");
                        SqlDataReader rdr1 = null;
                        for (int i = 0; i < firstNotSecond.Count; i++)
                        {
                            MessageBox.Show(" " + firstNotSecond[i]);
                            int n = (int)firstNotSecond[i];
                            var command = new SqlCommand("Delete from " + tbl + " where CardholderID=" + @firstNotSecond[i], destinationConnection);
                            try
                            {
                                rdr1 = command.ExecuteReader();
                                MessageBox.Show("successfully data Deleted", "user information");
                                while (rdr1.Read())
                                {}
                            }
                            catch (Exception ec)
                            {
                                MessageBox.Show(ec.Message);
                            }
                        }
                    }
                    else { }
                }
                else { }

                MessageBox.Show("Cardholder izlaz");
                return;
            }
        
    }
}

