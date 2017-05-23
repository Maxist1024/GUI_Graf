using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        List<Vertex> vertex;
        List<ListViewItem> lvi;
        int counter;

        public Form1()
        {
            InitializeComponent();

            vertex = new List<Vertex>();
            lvi = new List<ListViewItem>();
            counter = 0;
            temp = "";
        }

        private void addVerButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(nameVerTextbox.Text)))
            {
                if (!(CheckVer(vertex,nameVerTextbox.Text)))
                {
                    vertex.Add(new Vertex(nameVerTextbox.Text));
                    lvi.Add(new ListViewItem(nameVerTextbox.Text));
                    listView.Items.Add(lvi.ElementAt<ListViewItem>(counter));       //dodajemy wierzchołki do listview
                    counter++;
                }
                else
                    MessageBox.Show("Podany wierzchołek już istnieje.", "Upss..coś poszło nie tak.");
            }
            else
                MessageBox.Show("Nie została podana nazwa wierzchołka!", "Upss..coś poszło nie tak.");
            AddVerLabel.Text = "Dodano wierzchołek: " + nameVerTextbox.Text;
            nameVerTextbox.Clear();
            AddVerLabel.Visible = true;
        }

        bool CheckVer(List<Vertex> v1, string v2)
        {
            foreach (Vertex item in v1)
            {
                if (item.GetName() == v2)
                {
                    return true;
                }
            }
            return false;
        }

        Vertex FindVertex(List<Vertex> v, string v1)
        {
            foreach (Vertex item in v)
            {
                if (item.GetName() == v1)
                {
                    return item;
                }
            }
            return null;
        }

        ListViewItem FindLvI(List<ListViewItem> l, string name)
        {
            foreach (ListViewItem item in l)
            {
                if (item.SubItems[0].Text == name)
                {
                    return item;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FromVerTextBox.Text))
            {
                if (!string.IsNullOrWhiteSpace(ToVerTextBox.Text)) //sprawdzamy czy sa nazwy wierz
                {
                    if (CheckVer(vertex,FromVerTextBox.Text)) //istnieje lewy w
                    {
                        if (CheckVer(vertex, ToVerTextBox.Text)) //istnieje prawy w
                        {
                            if (directedCheckBox.Checked)
                            {
                                FindVertex(vertex, FromVerTextBox.Text).AddEdge(FindVertex(vertex, ToVerTextBox.Text));
                                FindLvI(lvi, FromVerTextBox.Text).SubItems.Add(ToVerTextBox.Text + ",");                     //dodanie krawędzi do listview                            
                                FromToLabel.Text = "Dodano krawędź z " + FromVerTextBox.Text + " do " + ToVerTextBox.Text;
                            }   //skierowany
                            else
                            {
                                FindVertex(vertex, FromVerTextBox.Text).AddEdge(FindVertex(vertex, ToVerTextBox.Text));
                                FindVertex(vertex, ToVerTextBox.Text).AddEdge(FindVertex(vertex, FromVerTextBox.Text));
                                FindLvI(lvi, FromVerTextBox.Text).SubItems.Add(ToVerTextBox.Text+",");
                                FindLvI(lvi, ToVerTextBox.Text).SubItems.Add(FromVerTextBox.Text + ",");
                                FromToLabel.Text = "Dodano krawędź z " + FromVerTextBox.Text + " do " + ToVerTextBox.Text + " oraz \n z " 
                                    + ToVerTextBox.Text + " do " + FromVerTextBox.Text;
                            }   //nieskierowany
                            FromToLabel.Visible = true;
                            FromVerTextBox.Clear();
                            ToVerTextBox.Clear();
                            listView.Refresh();
                        }
                        else
                            MessageBox.Show("Podany prawy wierzchołek nie istnieje.", "Upss..coś poszło nie tak.");
                    }
                    else
                        MessageBox.Show("Podany lewy wierzchołek nie istnieje.", "Upss..coś poszło nie tak.");
                }
                else
                    MessageBox.Show("Nie została podana nazwa wierzchołka!", "Upss..coś poszło nie tak.");
            }
            else
                MessageBox.Show("Nie została podana nazwa wierzchołka!", "Upss..coś poszło nie tak.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vertex[] vertexArray = vertex.ToArray();
            Graph graph = new Graph(vertexArray);
            VertexTriangleList triangles = graph.FindTriangles();

            foreach (VertexTriangle t in triangles)
            {
                foundTriLabel.Text += t.ToString() + "\n";
            }
            foundTriLabel.Visible = true;
            //foundTriLabel.Text = "";
        }

    }
}
