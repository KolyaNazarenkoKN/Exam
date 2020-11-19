using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Lib;
using System.Xml.Serialization;
using System.IO;

namespace Exam
{

    public partial class ToDoList : Form
    {


        public ToDoList()
        {
            InitializeComponent();
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Description");
            listView1.Columns.Add("StartDate");
            listView1.Columns.Add("EndDate");
            listView1.Columns.Add("State");


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
            listView1.Items.Add(listViewItem);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(ListViewItemCollection));

            //using (FileStream stream = File.OpenWrite(myXmlFilePath))
            //{
            //    serializer.Serialize(stream, listView1.Items);
            //}
        }




        public void SaveToXml(string myXmlFilePath)
        {

            
        }




        //public void LoadFromXML(string myXmlFilePath)
        //{
        //    if (File.Exists(myXmlFilePath))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(ListViewItemCollection));

        //        using (FileStream stream = File.OpenRead(myXmlFilePath))
        //        {
        //            myListView.Items = (ListViewItemCollection)serializer.Deserialize(stream);
        //        };
        //    };
        //}

    }


}


