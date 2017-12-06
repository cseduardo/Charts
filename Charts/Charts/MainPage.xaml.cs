using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using Entry = Microcharts.Entry;
using Microcharts;

namespace Charts
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(400)
            {
                Color=SKColor.Parse("#FF00FF"),
                Label="Noviembre",
                ValueLabel="400"
            },
            new Entry(200)
            {
                Color=SKColor.Parse("#00BFFF"),
                Label="Julio",
                ValueLabel="200"
            },
            new Entry(-100)
            {
                Color=SKColor.Parse("#FF0000"),
                Label="Enero",
                ValueLabel="-100"
            },
            new Entry(50)
            {
                Color=SKColor.Parse("#82FA58"),
                Label="Marzo",
                ValueLabel="50"
            }
        };
        public MainPage()
        {
            InitializeComponent();

            Grafica1.Chart = new RadialGaugeChart() { Entries = entries };
            Grafica2.Chart = new BarChart() { Entries = entries };
            Grafica3.Chart = new DonutChart() { Entries = entries };
            Grafica4.Chart = new PointChart() { Entries = entries };
            Grafica5.Chart = new LineChart() { Entries = entries };
            Grafica6.Chart = new RadarChart() { Entries = entries };
        }
    }
}
