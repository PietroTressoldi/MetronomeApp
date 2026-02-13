using System.Media;
using MetronomeApp.Global;
using MetronomeApp.Model;

namespace MetronomeApp
{
    public partial class Metronomo : Form
    {

        private bool running = false;
        public Metronomo()
        {
            InitializeComponent();
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            running = !running;
            btn_start.Text = "PARAR";

            if (running)
            {
                PlayMetronomeSound(tbar_bpm.Value);
            }
            else
            {
                btn_start.Text = "INICIAR";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_bpm.Text = $"{tbar_bpm.Value.ToString()} BPM";

            LoadSounds();
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
        private async void PlayMetronomeSound(int bpm)
        {
            MetronomeSound selectedSound = cbox_sounds.SelectedItem as MetronomeSound;
            SoundPlayer player = new SoundPlayer(selectedSound.path);
            while (running)
            {
                player.Play();
                Application.DoEvents();
                await Task.Delay(60000 / tbar_bpm.Value);
            }
        }
        private void cbox_sounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            running = false;
        }

        private void LoadSounds()
        {
            string[] soundFiles = Directory.GetFiles(Config.MetronomeSoundsPath, "*.wav");

            foreach (string soundFile in soundFiles)
            {
                var sound = new MetronomeSound
                {
                    path = soundFile,
                    name = Path.GetFileNameWithoutExtension(soundFile)
                };

                cbox_sounds.Items.Add(sound);

            }
            if (cbox_sounds.Items.Count > 0)
            {
                cbox_sounds.SelectedIndex = 0;
            }
        }
    }
}
