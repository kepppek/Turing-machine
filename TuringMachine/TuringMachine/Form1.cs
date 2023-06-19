using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        public static int index=0;

        public static void MoveLenta(DataGridView dgv, DataGridView lenta)
        {
            for(int i=0;i<27;i++)
            {
                dgv.Rows[0].Cells[i].Value = index - 13 + i;

                lenta.Rows[0].Cells[i].Value = data[Index(index - 13 + i)];
            }
        }

        public static int Index(int v)
        {
            int id = v;

            if (v < 0)
                id = v * -1 + 999;

            return id;
        }

        public static void AddValue(int id, string word)
        {
            data[Index(id)] = word;
        }

        public static void DeleteValue(int id)
        {
            data[Index(id)] = null;
        }

        public static string [] data = new string[1999];


        private void Form1_Load(object sender, EventArgs e)
        {
            lenta.RowCount = 1;
            lenta.ColumnCount = 27;

            numbers.RowCount = 1;
            numbers.ColumnCount = 27;
           
            alfavit.Columns.Add("cell","Алфавит");

            lenta.ClearSelection();
            numbers.ClearSelection();

            numbers.Rows[0].Cells[13].Style.BackColor = Color.Coral;
            lenta.Rows[0].Cells[13].Style.BackColor = Color.Coral;

            command.Columns.Add("q1","q1");
            command.Columns.Add("q2", "q2");
            command.Rows.Add(1);
            command.Rows[0].HeaderCell.Value = "_";

            cb1.Items.Add("_");

            cb2.Items.Add(">");
            cb2.Items.Add("<");
            cb2.Items.Add(".");

            cb3.Items.Add("0");
            cb3.Items.Add("q1");
            cb3.Items.Add("q2");

            MoveLenta(numbers,lenta);

            command.ClearSelection();
        }
            
        List<string> a = new List<string>();

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < lenta.ColumnCount && e.RowIndex < lenta.RowCount && e.Button == MouseButtons.Right)
            {
                lenta.CurrentCell = lenta.Rows[e.RowIndex].Cells[e.ColumnIndex];
                lenta.CurrentCell.Value = "";
                DeleteValue(int.Parse(numbers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }
            else
            {
                if (word != "")
                {
                    lenta.ClearSelection();
                    lenta.CurrentCell.Value = word;
                    AddValue(int.Parse(numbers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()), word);
                   
                }
            }
            lenta.ClearSelection();
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (index+1 < 986)
            {
                index++;
                MoveLenta(numbers, lenta);
            }            
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (index-1 > -986)
            {
                index--;
                MoveLenta(numbers, lenta);
            }
        }

        string word = "";

        private void alfavit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          if(e.RowIndex>-1)
          if(alfavit.Rows[e.RowIndex].Cells[0].Value!=null)
                 word = alfavit.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void alfavit_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            alfavit.ClearSelection();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null)
                    if (data[i] == word)
                    {
                        data[i] = null;
                        MoveLenta(numbers,lenta);
                    }
            }
           for (int i = 0; i < command.RowCount; i++)
            {
              if (command.Rows[i].HeaderCell.Value.ToString() == word)
                {
                    cb1.Items.RemoveAt(i-1);
                    command.Rows.RemoveAt(i);
                    word = "";
                    return;
                }
            }        
            
        }

        private void alfavit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            alfavit.ClearSelection();
            for(int i=0;i<alfavit.RowCount-1;i++)
            {
                if(alfavit.Rows[i].Cells[0].Value.ToString() == alfavit.Rows[e.RowIndex].Cells[0].Value.ToString() && i!=e.RowIndex)
                {
                    alfavit.Rows.RemoveAt(e.RowIndex);
                    return;
                }
            }

            for (int i = 0; i < command.RowCount; i++)
            {
                if (command.Rows[i].HeaderCell.Value.ToString() == alfavit.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    return;
                }
            }

            cb1.Items.Add(alfavit.Rows[e.RowIndex].Cells[0].Value.ToString());

            command.Rows.Add(1);
            command.Rows[command.RowCount-1].HeaderCell.Value = alfavit.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        public static int qCount=2;

        private void plus_Click(object sender, EventArgs e)
        {
            qCount++;
            command.Columns.Add("q"+qCount, "q"+qCount);
            cb3.Items.Add("q" + qCount);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (qCount > 2)
            {
                cb3.Items.RemoveAt(qCount);
                command.Columns.RemoveAt(command.ColumnCount - 1);
                qCount--;
            }
        }

        private void command_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string s = "";

                if (cb1.Text == "" || cb2.Text == "" || cb3.Text == "")
                {
                    MessageBox.Show("Поля пусты.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                s = cb1.Text + cb2.Text + cb3.Text;
                command.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s;
            }
            else
                command.ClearSelection();
        }

        bool stop;

        private async void play_Click(object sender, EventArgs e)
        {
            stop = false;
            int q = 1;
            string s = "";

            while (true)
            {
                command.ClearSelection();

                if(stop)
                {
                    return;
                }

                for(int i=0;i<command.RowCount;i++)
                {                  
                    
                    if(data[Index(index)] == command.Rows[i].HeaderCell.Value.ToString()
                        || (data[Index(index)]==null && command.Rows[i].HeaderCell.Value.ToString()=="_"))
                    {
                        command.Rows[i].Cells[q - 1].Selected = true;
                        s = command.Rows[i].Cells[q - 1].Value.ToString();

                        data[Index(index)] = s[0].ToString();

                        if (s[0] == '_')
                            data[Index(index)] = null;

                        switch (s[1])
                        {
                            case '>':                            
                                    index++;
                                if (index > 986)
                                {
                                    index = -986;
                                }
                                    MoveLenta(numbers,lenta);
                                break;

                            case '<':                               
                                  index--;
                                if (index < -986)
                                {
                                    index = 986;
                                }
                                  MoveLenta(numbers, lenta);
                                break;
                        }

                        if (s[s.Length - 1] == '0')
                        {
                            MessageBox.Show("Выполнение программы завершено", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                            q = int.Parse(s[s.Length - 1].ToString());
                    }
                    await Task.Delay(100);
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
