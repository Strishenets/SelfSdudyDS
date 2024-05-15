using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Selfstudy1Viz
{

    public partial class Form1 : Form
    {
        private Dictionary<int, Point> vertexPositions = new Dictionary<int, Point>();
        private List<(int, int)> edges = new List<(int, int)>();

        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            Button button1 = new Button();
            button1.Text = "Практична №3";
            button1.Location = new Point(20, 350);
            button1.Size = new Size(150, 40);
            button1.Click += (sender, e) => DrawGraph3();

            Button button2 = new Button();
            button2.Text = "Практична №4";
            button2.Size = new Size(150, 40);
            button2.Location = new Point(220, 350);
            button2.Click += (sender, e) => DrawGraph4();

            Button button3 = new Button();
            button3.Text = "Практична №5";
            button3.Size = new Size(150, 40);
            button3.Location = new Point(420, 350);
            button3.Click += (sender, e) => DrawGraph5();

            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
        }

        private void DrawGraph3()
        {
            ClearGraph();
            InitializeGraph3();
            Invalidate();
        }

        private void DrawGraph4()
        {
            ClearGraph();
            InitializeGraph4();
            Invalidate();
        }

        private void DrawGraph5()
        {
            ClearGraph();
            InitializeGraph5();
            Invalidate();
        }

        private void ClearGraph()
        {
            vertexPositions.Clear();
            edges.Clear();
        }

        private void InitializeGraph3()
        {
            AddVertex(1, new Point(50, 100));
            AddVertex(2, new Point(150, 50));
            AddVertex(3, new Point(60, 150));
            AddVertex(4, new Point(350, 100));
            AddVertex(5, new Point(250, 150));
            AddVertex(6, new Point(150, 150));

            AddEdge(1, 2);
            AddEdge(2, 5);
            AddEdge(2, 5);
            AddEdge(2, 4);
            AddEdge(2, 3);
            AddEdge(3, 6);
            AddEdge(4, 5);
            AddEdge(5, 6);
        }

        private void InitializeGraph4()
        {
            AddVertex(1, new Point(50, 100));
            AddVertex(2, new Point(150, 50));
            AddVertex(3, new Point(60, 150));
            AddVertex(4, new Point(250, 50));
            AddVertex(5, new Point(250, 190));
            AddVertex(6, new Point(150, 200));

            AddEdge(1, 2);
            AddEdge(1, 3);
            AddEdge(1, 4);
            AddEdge(1, 5);
            AddEdge(1, 6);
            AddEdge(3, 5);
            AddEdge(3, 4);
            AddEdge(5, 6);
            AddEdge(5, 4);
            AddEdge(6, 4);
        }

        private void InitializeGraph5()
        {
            AddVertex(1, new Point(50, 100));
            AddVertex(2, new Point(150, 50));
            AddVertex(3, new Point(350, 100));
            AddVertex(4, new Point(60, 150));
            AddVertex(5, new Point(200, 200));
            AddVertex(6, new Point(350, 150));
            AddVertex(7, new Point(250, 100));
            AddVertex(8, new Point(150, 150));

            AddEdge(1, 2);
            AddEdge(1, 4);
            AddEdge(1, 8);
            AddEdge(2, 3);
            AddEdge(2, 7);
            AddEdge(4, 5);
            AddEdge(5, 6);
            AddEdge(5, 8);
            AddEdge(6, 7);
            AddEdge(6, 8);
            AddEdge(7, 8);
        }

        private void AddVertex(int vertex, Point position)
        {
            vertexPositions[vertex] = position;
        }

        private void AddEdge(int startVertex, int endVertex)
        {
            edges.Add((startVertex, endVertex));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var vertex in vertexPositions)
            {
                e.Graphics.FillEllipse(Brushes.Yellow, vertex.Value.X - 10, vertex.Value.Y - 10, 20, 20);
                e.Graphics.DrawString(vertex.Key.ToString(), Font, Brushes.Black, vertex.Value.X - 5, vertex.Value.Y - 5);
            }

            foreach (var edge in edges)
            {
                Point startPoint = vertexPositions[edge.Item1];
                Point endPoint = vertexPositions[edge.Item2];
                e.Graphics.DrawLine(Pens.Red, startPoint, endPoint);
            }
        }
    }
}
