namespace Generator
{
    using NBitcoin;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.lstLanguage.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var mnemo = new Mnemonic(
                this.lstLanguage.SelectedIndex == 0 ? Wordlist.English : Wordlist.ChineseSimplified,
                WordCount.Twelve);
            var hdRoot = mnemo.DeriveExtKey(this.txtPassword.Text);
            this.txtMnemonic.Text = mnemo.ToString();
            this.txtBip32RootKey.Text = hdRoot.ToString(Network.TestNet);

            //GlobalMouseHandler gmh = new GlobalMouseHandler();
            //gmh.TheMouseMoved += (s,e)=> {
            //    this.progressBar1.Value++;
            //};
            //Application.AddMessageFilter(gmh);

        }
    }
}
