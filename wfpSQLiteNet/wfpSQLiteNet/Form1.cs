using SQLite;

namespace wfpSQLiteNet
{
    public partial class Form1 : Form
    {
        private SQLiteConnection db;

        public Form1()
        {
            InitializeComponent();

            db = new SQLiteConnection("myDb.db");
            db.CreateTable<Log>();
            db.CreateTable<User>();
            db.CreateTable<City>();

            db.Insert(new Log() { DT = DateTime.Now });
            listView1.View = View.Details;
            listView1.Columns.Add("Date and time", 200);

            foreach (var item in db.Table<Log>())
            {
                listView1.Items.Add(item.DT.ToString());
            }

            buShowLogs.Click += (s, e) => dataGridView1.DataSource = db.Table<Log>().ToList();
            buShowUsers.Click += (s, e) => dataGridView1.DataSource = db.Table<User>().ToList();
            buShowCities.Click += (s, e) => dataGridView1.DataSource = db.Table<City>().ToList();

            buExecuteSQL.Click += (s, e) => dataGridView1.DataSource = db.Query<User>(textBox1.Text).ToList();
            buExecuteOne.Click += (s, e) => MessageBox.Show(db.ExecuteScalar<int>(textBox1.Text).ToString());
        }
    }

    [Table("Cities")]
    internal class City
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    internal class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

    }

    internal class Log
    {
        public DateTime DT { get; set; }
    }
}