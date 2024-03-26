using ScottPlot;

namespace GraphingGUITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var xData = new string[] { "Spotify", "YouTube", "Uber Eats" };

            var x = new double[] { 1, 2, 3 };
            var yData = new double[] { 4, 10, 2 };

            ScottPlot.Bar[] bars =
            {
                new() { Position = 1, Value = yData[0],FillColor=Colors.Green},
                new() { Position = 2, Value = yData[1],FillColor=Colors.Red},
                new() { Position = 3, Value = yData[2],FillColor=Colors.Black}
            };

            formsPlot1.Plot.Add.Bars(bars);

            Tick[] ticks =
            {
                new(1, xData[0]),
                new(2, xData[1]),
                new(3, xData[2])
            };

            

            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;

            formsPlot1.Plot.XLabel("Apps");
            formsPlot1.Plot.YLabel("Screen Time in hours");

            formsPlot1.Plot.Axes.Margins(bottom: 0);
            
            formsPlot1.Refresh();

            

        }


    }
}