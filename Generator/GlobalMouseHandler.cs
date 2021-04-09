namespace Generator
{
    using System;
    using System.Windows.Forms;

    // https://stackoverflow.com/a/2064009
    public class GlobalMouseHandler : IMessageFilter
    {
        private const int WM_MOUSEMOVE = 0x0200;

        public event EventHandler TheMouseMoved;

        #region IMessageFilter Members

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE)
            {
                TheMouseMoved?.Invoke(this, null);
            }

            // Always allow message to continue to the next filter control
            return false;
        }

        #endregion
    }
}
