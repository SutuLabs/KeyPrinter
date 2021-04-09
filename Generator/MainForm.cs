namespace Generator
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NAudio.Wave;
    using NBitcoin;

    public partial class MainForm : Form
    {
        Mnemonic mnemo;
        public MainForm()
        {
            InitializeComponent();
            this.lstLanguage.SelectedIndex = 0;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            this.btnGenerate.Enabled = false;

            using var waveIn = new WaveInEvent();
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.StartRecording();

            var total = 3000; //ms

            for (int i = 0; i < 100; i++)
            {
                this.progProcess.Invoke((Action)(() =>
                {
                    this.progProcess.Value = i + 1;
                }));

                await Task.Delay(total / 100);
            }

            waveIn.StopRecording();
            waveIn.DataAvailable -= OnDataAvailable;

            this.mnemo = new Mnemonic(
                this.lstLanguage.SelectedIndex == 0 ? Wordlist.English : Wordlist.ChineseSimplified,
                WordCount.Twelve);
            var hdRoot = this.mnemo.DeriveExtKey(this.txtPassword.Text);
            this.txtMnemonic.Text = this.mnemo.ToString();
            this.txtBip32RootKey.Text = hdRoot.ToString(Network.TestNet);
            this.btnGenerate.Enabled = true;
        }

        private void OnDataAvailable(object sender, WaveInEventArgs args)
        {
            float max = 0;
            // interpret as 16 bit audio
            for (int index = 0; index < args.BytesRecorded; index += 2)
            {
                short sample = (short)((args.Buffer[index + 1] << 8) |
                                        args.Buffer[index + 0]);
                // to floating point
                var sample32 = sample / 32768f;
                // absolute value
                if (sample32 < 0) sample32 = -sample32;
                // is this the max value?
                if (sample32 > max) max = sample32;
            }

            this.progVolume.Invoke((Action)(() =>
            {
                this.progVolume.Value = (int)(max * 100);
            }));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new PrintService().Print(this.mnemo.Words, new string[] { }, "XP-58");
        }
    }
}