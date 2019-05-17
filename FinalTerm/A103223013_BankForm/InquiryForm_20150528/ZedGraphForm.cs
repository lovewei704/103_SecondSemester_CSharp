using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Collections;

namespace InquiryForm_20150528
{
    public partial class ZedGraphForm : Form
    {
        // 宣告 //

        private GraphPane zedGraphPane;
        private List<string[]> pieChartList;

        public ZedGraphForm(string showString)
        {
            InitializeComponent();
            zedGraphPane = zedGraph.GraphPane;
            FillPaneBackground(); 

            ProcessPieChartData(showString);
            CreatePieChart();
        }

        // 處裡資料（string）
        private void ProcessPieChartData(string showString)
        {
            pieChartList = new List<string[]>();
            string[] graphInputRows = showString.Split('\n');
     
            for (int i = 0; i < graphInputRows.Length; i++)
            {
                if (graphInputRows[i].Replace("\r", "") != "")
                {
                    string[] pointsTemp = graphInputRows[i].Split('\t');
                    pieChartList.Add(pointsTemp);
                }
            }
        }

        // 製作 PieChart
        public void CreatePieChart()
        {
            zedGraphPane.CurveList.Clear();
            zedGraphPane.Title.Text = "Result";

            Color[] colors = { Color.Green, Color.Red, Color.Yellow, Color.Blue, Color.Purple };
            int colorIndex = 0;
            foreach (string[] currentStringArray in pieChartList)
            {
                string title = currentStringArray[0] + "\t" + currentStringArray[1];
                double value = Convert.ToDouble(currentStringArray[1]);

                zedGraphPane.AddPieSlice(value, colors[colorIndex % 5], 0, title);
                colorIndex++;
            }
            zedGraph.AxisChange();
        }

        // 背景填色
        private void FillPaneBackground()
        {
            zedGraphPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            
            zedGraphPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);
        }
    }
}
