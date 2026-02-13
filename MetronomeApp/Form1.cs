using System.Media;
using MetronomeApp.Global;

namespace MetronomeApp
{
    public partial class Form1 : Form
    {

        private bool running = false;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            running = !running;
            btn_start.Text = "PARAR";

            if (running)
            {
                SoundPlayer player = new SoundPlayer(Path.Combine(Config.MetronomeSoundsPath, "Perc_Can_hi.wav"));
                while (running)
                {                    
                    player.Play();
                    Application.DoEvents();
                    await Task.Delay(60000 / tbar_bpm.Value);
                }
            }
            else
            {
                btn_start.Text = "INICIAR";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_bpm.Text = $"{tbar_bpm.Value.ToString()} BPM";
        }

        private void tbar_bpm_Scroll(object sender, EventArgs e)
        {
            lbl_bpm.Text = $"{tbar_bpm.Value.ToString()} BPM";
            if (tbar_bpm.Value == 0)
            {
                running = false;
                btn_start.Text = "INICIAR";
            }

        }
    }
}
