using _16_Gokhlia_Money.parser;
using _16_Gokhlia_Money.parser.loaders;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _16_Gokhlia_Money.chart
{
    public class ChartWriter
    {
        private Chart Chart;
        private Parser parser = new Parser();
        private HtmlLoader Loader = new HtmlLoader(new ParserSettings());
        private string[] xValues;
        private string[] yValues;
        private ChartProperties Properties;
        public ChartWriter(Chart chart)
        {
            if(chart != null)
            {
                Chart = chart;
            }
            GetData();
        }
        private async void GetData()
        {
            string source = await Loader.LoadDocument();
            HtmlParser htmlParser = new HtmlParser();
            var document = await htmlParser.ParseDocumentAsync(source);
            xValues = parser.Parse(document, "td", "day");
            yValues = parser.Parse(document, "td", "moneyUp");
            Properties = new ChartProperties(xValues, yValues);
            WriteChart();
        }
        private void WriteChart()
        {
            double borderLeft = 0,
                   borderRight = Properties.XPoints[Properties.XPoints.Length - 1];
            int count = 0;
            Chart.Series[0].Points.Clear();
            while(borderLeft < borderRight)
            {
                Chart.Series[0].Points.AddXY(Properties.XPoints[count], Properties.YPoints[count]);
                double index = Properties.YPoints[count];
                Chart.Series[0].Points[count].Label = $"{index}руб";
                count += 1;
                borderLeft += 1;
            }
        }
    }
}
