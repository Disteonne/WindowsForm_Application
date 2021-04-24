using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs_forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.g_dataBase is null)
            {
                // WRN crutch
                Program.g_dataBase = new DataBase(1000);
            }
            else
            {
                // added logic for check actual data in database and output question to user
            }
            Program.updateInfoFromDataBase();
            Program.g_form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                if (Program.g_dataBase is null)
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
            Program.g_form.Show();
        }
    }
}
