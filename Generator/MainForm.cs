namespace Generator
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NAudio.Wave;
    using NBitcoin;

    public partial class MainForm : Form
    {
        Mnemonic mnemo;
        string[] addresses;
        public MainForm()
        {
            InitializeComponent();
            this.lstLanguage.SelectedIndex = 0;
            this.btnPrint.Visible = false;
            this.progProcess.Visible = false;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            this.btnGenerate.Enabled = false;
            this.lblVolumeHint.Visible = true;
            this.progVolume.Visible = true;
            this.btnPrint.Visible = false;
            this.progProcess.Visible = true;

            using var waveIn = new WaveInEvent();
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.StartRecording();

            var total = 5000; //ms

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

            this.addresses = Enumerable.Range(1, 3)
                .Select(num => hdRoot
                    .Derive(new KeyPath($"m/84'/1'/0'/0/{num}"))
                    .GetPublicKey()
                    .GetAddress(ScriptPubKeyType.Segwit, Network.Main)
                    .ToString())
                .ToArray();

            this.lblVolumeHint.Visible = false;
            this.progVolume.Visible = false;
            this.btnGenerate.Enabled = true;
            this.btnPrint.Visible = true;
            this.progProcess.Visible = false;
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
                this.progVolume.Value = (int)(Math.Sqrt(max) * 90) + 10;
            }));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new PrintService().Print(this.mnemo.Words, this.addresses, "XP-58");
            this.btnPrint.Visible = false;
            this.txtMnemonic.Text = "";
            this.txtPassword.Text = "";
        }
    }
}