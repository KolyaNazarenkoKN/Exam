using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Exam
{
    public partial class Add : Form 
    {
        ToDoList toDoList = new ToDoList();
        public Add()
        {
            InitializeComponent();

            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
    
            Task_Lib.Task task = new Task_Lib.Task();
            int id = task.Id = Convert.ToInt32(textBox1.Text);
            string name = task.Name = textBox2.Text;
            string desc = task.Description = textBox3.Text;
            DateTime Startdate = task.StartDate = dateTimePicker1.Value;
            DateTime Enddate = task.EndDate = dateTimePicker2.Value;
            string[] tasks = { id.ToString(), name, desc, Startdate.ToString(), Enddate.ToString() };
            var listViewItem = new ListViewItem(tasks);
            toDoList.listView1.Items.Add(listViewItem);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }
    }
}

