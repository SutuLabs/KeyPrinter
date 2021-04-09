namespace Generator
{
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Windows.Forms;
    using ZXing;
    using ZXing.QrCode;

    public class PrintService
    {
        private string[] resultWords;
        private string[] resultAddresses;

        public void Print(string[] words, string[] addresses, string defaultPrinter = null)
        {
            this.resultWords = words;
            this.resultAddresses = addresses;

            var pdoc = new PrintDocument();
            pdoc.PrintPage += new PrintPageEventHandler(this.PrintDrawingHandler);
            var pdlg = new PrintDialog();
            pdlg.AllowSomePages = true;
            pdlg.ShowHelp = true;
            pdlg.Document = pdoc;
            if (string.IsNullOrWhiteSpace(defaultPrinter))
            {
                var result = pdlg.ShowDialog();
                if (result != DialogResult.OK)
                    return;
            }
            else
            {
                pdoc.PrinterSettings.PrinterName = defaultPrinter;
            }
            pdoc.Print();
        }

        private static Bitmap GenQrCode(int size, string url)
        {
            var margin = 0;

            var qrCodeWriter = new BarcodeWriterPixelData
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = size,
                    Width = size,
                    Margin = margin,
                    //ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.M
                }
            };
            var pixelData = qrCodeWriter.Write(url);
            var bitmap = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            var bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, pixelData.Width, pixelData.Height),
                System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            try
            {
                // we assume that the row stride of the bitmap is aligned to 4 byte multiplied by the width of the image
                System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0,
                pixelData.Pixels.Length);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return bitmap;
        }

        private void PrintDrawingHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            var yhsmall = new Font("Microsoft YaHei", 7);
            var yhnormal = new Font("Microsoft YaHei", 8);
            var yhbig = new Font("Microsoft YaHei", 13);
            var yhtitle = new Font("Microsoft YaHei", 15);
            var logo = new Bitmap("logo.png");

            var g = ppeArgs.Graphics;
            float yPos = 0;
            float leftMargin = 0;
            float topMargin = 0;

            int paperWidth = 178;
            int qrcodesize = 100;


            yPos += topMargin;

            var height = 0;

            g.DrawImage(logo, new RectangleF(0, yPos, logo.Width, logo.Height));

            yPos += logo.Height;

            height = DrawText("您的账户助记词可以帮助您轻松备份和恢复个人账户", yhnormal, g, yPos, leftMargin, paperWidth, 20);
            yPos += height;

            height = DrawText(string.Join(" ", this.resultWords), yhbig, g, yPos, leftMargin, paperWidth, 20);
            yPos += height;

            height = DrawText("警告：切勿向他人透露您的账户助记词。任何人一旦持有该账户助记词，即可控制您的token", yhsmall, g, yPos, leftMargin + 10, paperWidth, 20);
            yPos += height;

            height = DrawText("请将该助记词抄到纸上，并保存在安全的地方", yhnormal, g, yPos, leftMargin + 10, paperWidth, 20);
            yPos += height;

            height = DrawText("======沿此线折叠======", yhnormal, g, yPos, leftMargin + 10, paperWidth, 20);
            yPos += height;

            int num = 0;
            foreach (var address in this.resultAddresses)
            {
                num++;
                height = DrawText($"收款码 #{num}", yhnormal, g, yPos, leftMargin + 10, paperWidth, 20);
                yPos += height;

                var qrcode = GenQrCode(qrcodesize, address);
                g.DrawImage(qrcode, new RectangleF(leftMargin + (paperWidth - qrcodesize) / 2, yPos, qrcodesize, qrcodesize));
                qrcode.Save("test.png");
                yPos += qrcodesize;
            }

            height = DrawText("感谢您参与区块链探索沙龙！", yhnormal, g, yPos, leftMargin + 10, paperWidth, 20);
            yPos += height;

            height = DrawText("技术提供方：上海素图科技有限公司", yhsmall, g, yPos, leftMargin + 10, paperWidth, 20);
            yPos += height;

            ppeArgs.HasMorePages = false;
        }

        private int DrawText(string text, Font font, Graphics g, float y, float x, int width, int maxHeight = 0, StringAlignment alignment = StringAlignment.Near)
        {
            var size = TextRenderer.MeasureText(text, font, new Size(width, maxHeight), TextFormatFlags.WordBreak);
            g.DrawString(text, font, Brushes.Black, new RectangleF(x, y, size.Width, size.Height),
                new StringFormat() { Alignment = alignment });
            return (int)((double)size.Height / g.DpiY * 100);
        }
    }

}
