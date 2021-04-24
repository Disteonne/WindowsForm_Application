using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace labs_forms
{
    public partial class DataBaseWorker : Form
    {
        //private DataBase db = new DataBase(100);
        public DataBaseWorker()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PleaseClose();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.g_dataBase is null)
            {
                // WRN crutch
                Program.g_dataBase = new DataBase(1024);
            }
            else
            {
                // added logic for check actual data in database and output question to user
            }
            Program.updateInfoFromDataBase();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((!(Program.g_dataBase is null)))
            {
                //output warning
                // if (user want save choose)
                // сохранитьКакToolStripMenuItem_Click();
            }
            string path = null;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                path = choofdlog.FileName;
            }
            if (IOHelper.isReadFile(path))
            {
                Program.g_dataBase = IOHelper.createDataBaseFromFile(path);
                Program.g_path = path;
                if(Program.g_dataBase is null)
                {
                    Program.g_dataBase = null;
                    bool bbb = Program.g_dataBase.neededSave();
                    //exeption
                    return;
                }
            }
            else
            {
                Program.g_dataBase = null;
                bool bbb = Program.g_dataBase.neededSave();
                //exeption
                return;
            }
            Program.updateInfoFromDataBase();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Program.g_dataBase is null)
            {
                //exeption
                return;
            }
            string path = null;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                path = choofdlog.FileName;
            }
            if (IOHelper.isWrittenFile(path))
            {
                IOHelper.createFileFromDataBase(Program.g_dataBase, path);
                Program.g_path = Path.GetFileName(path);
            }
            else
            {
                // exeption
                return;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((!(Program.g_dataBase is null)) && IOHelper.isWrittenFile(Program.g_path))
            {
                IOHelper.createFileFromDataBase(Program.g_dataBase, Program.g_path);
            }
            else
            {
                // exeption
                return;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((!(Program.g_dataBase is null)) && Program.g_dataBase.neededSave())
            {
                //output message
            }
            Program.g_dataBase = null;
            Program.g_path = "";
            Program.updateInfoFromDataBase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Receipt tmp = IOHelper.createTransactionData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,textBox8.Text);
            //if (Program.g_dataBase is null || dataGridView1 is null || tmp is null)
            //{
            //exeption
            //return;
            //}
            DataBase db = Program.g_dataBase;
            if (db.add(tmp))
            //if (db.add(tmp))
            {
               
                String[] row = { tmp.name, Convert.ToString(tmp.price),
                                    tmp.nameClient,tmp.phoneClient,tmp.nameReceipt, tmp.address,
                                    tmp.date.ToString("dd/MM/yyyy"),Convert.ToString(db.find(tmp))};
                dataGridView1.Rows.Add(row);
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Receipt tmp = IOHelper.createTransactionData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text);
            int index = Program.g_dataBase.find(tmp);
            if (index >= 0 && index < Program.g_dataBase.dataBaseSize())
            {
                if (Program.g_dataBase.delete(tmp)!=0)
                {
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        Receipt iter = IOHelper.createTransactionDataFromRow(row);
                        if (iter == tmp)
                        {
                            dataGridView1.Rows.RemoveAt(row.Index);
                            break;
                        }
                    }
                }
                else
                {
                    // WRN data base dont have this record
                }
            }
            else
            {
                //exeption
            }
        }


        private void buttonReplace_Click(object sender, EventArgs e)
        {
            //Form2 newForm = new Form2();
            //Program.g_form.Hide();
            //newForm.Show();
            String index = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
            Receipt upload = IOHelper.createTransactionData(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, 
                textBox6.Text,textBox8.Text);
            Program.g_dataBase.replace(Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString()),
               upload);


            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
            dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
            dataGridView1.CurrentRow.Cells[6].Value = Convert.ToDateTime(textBox8.Text).ToShortDateString();

        }

        public void swapInDataBase(int index)
        {
            Receipt tmp = IOHelper.createTransactionData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text);
            if (Program.g_dataBase is null || dataGridView1 is null)
            {
                //exeption
                return;
            }
            if (Program.g_dataBase.replace(index, tmp))
            {
                String[] row = { tmp.name, Convert.ToString(tmp.price),
                                    tmp.nameClient,tmp.phoneClient,tmp.nameReceipt, tmp.address,
                                    tmp.date.ToString("dd/MM/yyyy")};
                dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
                dataGridView1.Rows.Insert(index, row);
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Receipt tmp = IOHelper.createTransactionData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text);
            if (Program.g_dataBase is null || dataGridView1 is null)
            {
                //exeption
                return;
            }
            int index = Program.g_dataBase.find(tmp);
            if(index == -1)
            {
                // informing
                // element not found
                return;
            }
            Program.g_form.dataGridView1.ClearSelection();
            Program.g_form.dataGridView1.CurrentCell = Program.g_form.dataGridView1.Rows[index].Cells[0];
            Program.g_form.dataGridView1.Rows[index].Selected = true;
        }

        private void buttonSearchNext_Click(object sender, EventArgs e)
        {
            Receipt tmp = IOHelper.createTransactionData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text);
            if (Program.g_dataBase is null || dataGridView1 is null)
            {
                //exeption
                return;
            }
            int startSearchIndex = Program.g_form.dataGridView1.CurrentRow.Index + 1;
            int index = Program.g_dataBase.findNext(tmp, startSearchIndex);
            if (index == -1)
            {
                // informing
                // element not found
                return;
            }
            Program.g_form.dataGridView1.ClearSelection();
            Program.g_form.dataGridView1.CurrentCell = Program.g_form.dataGridView1.Rows[index].Cells[0];
            Program.g_form.dataGridView1.Rows[index].Selected = true;
        }

        private void nameClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.g_form.dataGridView1.Columns[0].Visible = !Program.g_form.dataGridView1.Columns[0].Visible;
        }

        private void phoneClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.g_form.dataGridView1.Columns[1].Visible = !Program.g_form.dataGridView1.Columns[1].Visible;
        }
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.g_form.dataGridView1.Columns[0].Visible = !Program.g_form.dataGridView1.Columns[0].Visible;
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.g_form.dataGridView1.Columns[2].Visible = !Program.g_form.dataGridView1.Columns[2].Visible;
        }
        private void nameReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.g_form.dataGridView1.Columns[0].Visible = !Program.g_form.dataGridView1.Columns[0].Visible;
        }
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.g_form.dataGridView1.Columns[3].Visible = !Program.g_form.dataGridView1.Columns[3].Visible;
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.g_form.dataGridView1.Columns[5].Visible = !Program.g_form.dataGridView1.Columns[5].Visible;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            //Form3 newForm = new Form3();
            //Program.g_form.Hide();
            //newForm.Show();
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form4 newForm = new Form4();
            //Program.g_form.Hide();
            //newForm.Show();
        }

        private void sortByNameClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.g_dataBase is null) return;
            Program.g_dataBase.sortingByName();
            Program.updateInfoFromDataBase();
        }

        private void sortByPhoneClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.g_dataBase is null) return;
            Program.g_dataBase.sortingByPhone();
            Program.updateInfoFromDataBase();
        }

        private void sortByPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.g_dataBase is null) return;
            Program.g_dataBase.sortingByPrice();
            Program.updateInfoFromDataBase();
        }

        private void sortByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.g_dataBase is null) return;
            Program.g_dataBase.sortingByPropertyDate();
            Program.updateInfoFromDataBase();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Правка_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.g_dataBase is null)
            {
                //exeption
                return;
            }
            string path = null;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                path = choofdlog.FileName;
            }
            if (IOHelper.isWrittenFile(path))
            {
                IOHelper.createFileFromDataBase(Program.g_dataBase, path);
                Program.g_path = Path.GetFileName(path);
            }
            else
            {
                // exeption
                return;
            }
        }
    }
}
