namespace GraphGUITest4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            ConfigurePlot1();
            ConfigurePlot2();
        }

        private void ConfigurePlot1()
        {
            var labels = new string[] { "Spotify", "YouTube", "Uber Eats" };
            var data = new double[] { 4, 10, 2 };
            var postions = new double[] { 0, 1, 2 };
            var colours = new Color[] { Color.Green, Color.Red, Color.Black };

            for (int i = 0; i < data.Length; i++)
            {
                var bar = formsPlot1.Plot.AddBar(
                    values: new double[] { data[i] },
                    positions: new double[] { postions[i] },
                    color: colours[i]
                    );
            }

            formsPlot1.Plot.XLabel("Application");
            formsPlot1.Plot.YLabel("Screen Time (Hrs)");
            formsPlot1.Plot.Title("Screen Usage");

            //formsPlot1.Plot.AddBar(data, postions);
            formsPlot1.Plot.XTicks(postions, labels);
            formsPlot1.Plot.SetAxisLimits(yMin: 0);

            formsPlot1.Plot.Grid(false);

            // disable left-click-drag pan
            formsPlot1.Configuration.Pan = false;

            // disable right-click-drag zoom
            formsPlot1.Configuration.Zoom = false;

            // disable scroll wheel zoom
            formsPlot1.Configuration.ScrollWheelZoom = false;

            // disable middle-click-drag zoom window
            formsPlot1.Configuration.MiddleClickDragZoom = false;

            formsPlot1.Refresh();
        }

        private void ConfigurePlot2()
        {
            double[] values = { 178, 500 };
            string centerText = $"£{values[0]} / £{values[1]}";
            Color color1 = Color.Yellow;
            Color color2 = Color.YellowGreen;

            var pie = Plot2.Plot.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = color2;
            pie.CenterFont.Size = 25;
            pie.OutlineSize = 2;
            pie.SliceFillColors = new Color[] { color1, color2 };

            Plot2.Refresh();

        }

        private void formsPlot2_Load(object sender, EventArgs e)
        {

        }
    }
}