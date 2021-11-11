using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Human> HumanList = new List<Human> { };
        
        public Form1()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        public void Initial()
        {
            HumanAdd();
            DataTable table = new DataTable();

            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Surname");
            table.Columns.Add("Age");
            table.Columns.Add("Sex");
            table.Columns.Add("Country");
            table.Columns.Add("City");
            table.Columns.Add("Street");
            table.Columns.Add("Number of house");

            HumanAdd();
            int i;
            for (i = 0; i < 5; i++)
            {
                
                Human human = HumanList[i];
                table.Rows.Add(HumanList[i]._id, HumanList[i]._name, HumanList[i]._surname, HumanList[i]._age, HumanList[i].Sex, HumanList[i].address._country, HumanList[i].address._city, HumanList[i].address._street, HumanList[i].address._house_number);
                
            }

            this.dataGridView1.DataSource = table;
            
        }

        private void HumanAdd()
        {
            int i = 1;
            while (i < 10) 
            {
                Human human1 = new Human(i, "Mikhola", "Vdovski", 25, Sex.Male, new Address("Kyiv", "Ukraina", "Universitetskaya", 14));
                i++;
                Human human2 = new Human(i, "Ivan", "Bog", 23, Sex.Male, new Address("Kyiv", "Ukraina", "Universitetskaya", 14));
                i++;
                Human human3 = new Human(i, "Lyudmila", "Vdovski", 27, Sex.Female, new Address("Kyiv", "Ukraina", "Universitetskaya", 14));
                i++;
                Human human4 = new Human(i, "Vlada", "Septenta", 15, Sex.Female, new Address("Kyiv", "Ukraina", "Universitetskaya", 14));
                i++;
                Human human5 = new Human(i, "David", "Bolognieze", 55, Sex.Male, new Address("Kyiv", "Ukraina", "Universitetskaya", 14));
                HumanList.Add(human1);
                HumanList.Add(human2);
                HumanList.Add(human3);
                HumanList.Add(human4);
                HumanList.Add(human5);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initial();
            Chart();
            InitialCombobox();
            InitialTreeView();
        }

        private void Chart()
        {

            for (int i = 0; i<5;i++)
            {
                this.chart1.Series["Age"].Points.AddXY(HumanList[i]._name, HumanList[i]._age);
            }
        }

        private void InitialCombobox()
        {
            Marks.Items.Add("A");
            Marks.Items.Add("B");
            Marks.Items.Add("C");
            Marks.Items.Add("D");
            Marks.Items.Add("F");


        }

        public void InitialTreeView()
        {
            asfdasfasfa
               
            }

        
    }
}
