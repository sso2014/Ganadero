using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using G.Core.Data;

namespace G.Gui
{
    public partial class CtrlCampo : UserControl
    {
        public CtrlCampo()
        {
            InitializeComponent();
            categorias = new List<Categoria>();
        }

        public object DataSeries
        {
            set
            {
                barChart.Series.Clear();
                categorias.Clear();
                categorias = (List<Categoria>)value;
              
                
                foreach (Categoria categoria in (List<Categoria>)value)
                {
                    barChart.Series.Add(categoria.Descripcion);
                }
            }
        }

        List<Categoria> categorias;

        void LoadBarChart(List<Bovino> bovinos)
        {
            barChart.Series.Clear();

            barChart.BackColor = Color.LightYellow;           
            barChart.Palette = ChartColorPalette.Fire;
            barChart.ChartAreas[0].BackColor = Color.Transparent;
            barChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            barChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            foreach (Categoria c in categorias)
            {

                barChart.Series.Add(new Series()
                    {
                        Name = c.Descripcion,
                        IsVisibleInLegend = false,
                        ChartType = SeriesChartType.Column
                    });
            }

            int count = 0;

            foreach (Series series in barChart.Series)
            {
                foreach (Bovino bovino in bovinos)
                {
                    if (bovino.Categoria.Descripcion == series.Name)
                    {
                        count++;
                        series.Points.Add(count);
                        var p1 = series.Points[0];
                        p1.Color = Color.Red;
                        p1.AxisLabel = "";
                        p1.LegendText = bovino.Categoria.Descripcion;
                        p1.Label = "70000";
                    }
                }
            }
                      
            //series[].Points.Add(70000);
            //var p1 = series.Points[0];
            //p1.Color = Color.Red;
            //p1.AxisLabel = "Hiren Khirsaria";
            //p1.LegendText = "Hiren Khirsaria";
            //p1.Label = "70000";

            //series.Points.Add(30000);
            //var p2 = series.Points[1];
            //p2.Color = Color.Yellow;
            //p2.AxisLabel = "ABC XYZ";
            //p2.LegendText = "ABC XYZ";
            //p2.Label = "30000";
            //barChart.Invalidate();
        }

        public object DataSouce
        {
            set
            {
                barChart.Series.Clear();
              
                
                foreach (Categoria categoria in categorias)
                {
                    barChart.Series.Add(categoria.Descripcion);
                }

                List<Bovino> bovinos = value as List<Bovino>;

                foreach (Series s in barChart.Series)
                {
                    //foreach (Bovino b in bovinos)
                    //{
                    //if (b.Categoria.Descripcion == s.Name)
                    //{
                    //    count++;
                    //    s.Points.AddXY(bovinos.Count, count);
                    //    var p = s.Points[0];                           
                    //    p.Color = Color.Yellow;
                    //    p.AxisLabel = b.Categoria.Descripcion;
                    //    p.LegendText = b.Categoria.Descripcion;
                    //    p.Label = s.Points.Count.ToString();                       

                    //}
                    //}
                    int count = bovinos.FindAll(b => b.Categoria.Descripcion == s.Name).Count;
                    int count2 =0; 

                    if (count != 0)
                    {
                        var p = s.Points.Add(count);
                        p.AxisLabel = s.Name;
                        p.LegendText = count.ToString();
                        p.Label = s.Name + " " + count.ToString();
                        count2++;
                    }
                }
            }
        }
    }
}