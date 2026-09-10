namespace day15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var gauge = new TemperatureGauge
            {
                Location = new Point(60, 20),
                ActualTemperature = 45,
                SetTemperature = 60,
                MaxTemperature = 60,
                Size = new Size(170, 180),
            };

            panel3.Controls.Add(gauge);
        }

    }
}
