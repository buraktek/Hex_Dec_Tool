using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hex_Dec_Tool
{
    public partial class Form1 : Form
    {
        bool mouse_click = false;
        int old_x, old_y;
        bool tamam = false;
        bool bit_islemi = false;
        KeyboardHook hook = new KeyboardHook();

        public Form1()
        {
            InitializeComponent();

            this.Location = new System.Drawing.Point(Hex_Dec_Tool.Properties.Settings.Default.Default_Location_X, Hex_Dec_Tool.Properties.Settings.Default.Default_Location_Y);
            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + B combination as hot key.
            hook.RegisterHotKey(Hex_Dec_Tool.ModifierKeys.Control, Keys.B);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            try
            {
                if (Clipboard.GetText().Length > 0)
                {
                    string text = Clipboard.GetText().Length.ToString();
                    this.TopMost = true;
                    AutoClosingMessageBox.Show(text, "Uzunluk", 800);
                }
            }
            catch
            {
            }
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MouseDown_Action_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_click = true;
            button_move.Cursor = Cursors.SizeAll; //SizeAll yapmamımızın amacı taşırken hoş görüntü olması içindir
        }

        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_click)
            {
                int x, y;
                int eski_x, eski_y;
                x = e.X;
                y = e.Y;
                if ((old_x != x) || (old_y != y))
                {
                    if ((Math.Abs(old_x - x) < 50) || (Math.Abs(old_y - y) < 50))
                    {
                        eski_x = Location.X;
                        eski_y = Location.Y;
                        this.Location = new System.Drawing.Point(eski_x + x, eski_y + y);
                        old_x = x;
                        old_y = y;
                        Hex_Dec_Tool.Properties.Settings.Default.Default_Location_X = Location.X;
                        Hex_Dec_Tool.Properties.Settings.Default.Default_Location_Y = Location.Y;
                        Hex_Dec_Tool.Properties.Settings.Default.Save();
                    }
                }
            }
            try
            {
                Opacity = 1;
            }
            catch
            {

            }
        }

        private void Hex_To_Bit()
        {
            long hex = Convert.ToInt64(textBox_Hex.Text, 16);
            if ((hex & (0x00000001)) == 0x01)
            {
                button_bit0.Text = "1";
            }
            else
            {
                button_bit0.Text = "0";
            }
            if ((hex & (0x00000002)) == 0x02)
            {
                button_bit1.Text = "1";
            }
            else
            {
                button_bit1.Text = "0";
            }
            if ((hex & (0x00000004)) == 0x04)
            {
                button_bit2.Text = "1";
            }
            else
            {
                button_bit2.Text = "0";
            }
            if ((hex & (0x00000008)) == 0x08)
            {
                button_bit3.Text = "1";
            }
            else
            {
                button_bit3.Text = "0";
            }

            if ((hex & (0x00000010)) == 0x10)
            {
                button_bit4.Text = "1";
            }
            else
            {
                button_bit4.Text = "0";
            }
            if ((hex & (0x00000020)) == 0x20)
            {
                button_bit5.Text = "1";
            }
            else
            {
                button_bit5.Text = "0";
            }
            if ((hex & (0x00000040)) == 0x40)
            {
                button_bit6.Text = "1";
            }
            else
            {
                button_bit6.Text = "0";
            }
            if ((hex & (0x00000080)) == 0x80)
            {
                button_bit7.Text = "1";
            }
            else
            {
                button_bit7.Text = "0";
            }

        }
        private void TextBox_Hex_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_Hex.TextLength > 0) && (tamam == false))
            {
                try
                {
                    string HEX_textbox = textBox_Hex.Text.Replace(" ", "");
                    long DEC = 0;
                    long dec1, dec2;
                    int index = textBox_Hex.Text.IndexOf("-");
                    if (index != -1)
                    {
                        dec1 = Convert.ToInt64(textBox_Hex.Text.Substring(0, index), 16);
                        dec2 = Convert.ToInt64(textBox_Hex.Text.Substring(index + 1, (textBox_Hex.Text.Length - index - 1)), 16);
                        DEC = dec1 - dec2;
                    }
                    else
                    {
                        index = textBox_Hex.Text.IndexOf("+");
                        if (index != -1)
                        {
                            dec1 = Convert.ToInt64(textBox_Hex.Text.Substring(0, index), 16);
                            dec2 = Convert.ToInt64(textBox_Hex.Text.Substring(index + 1, (textBox_Hex.Text.Length - index - 1)), 16);
                            DEC = dec1 + dec2;
                        }
                        else
                        {
                            DEC = Convert.ToInt64(HEX_textbox, 16);
                        }
                    }

                    tamam = true;
                    string DEC_string = DEC.ToString();
                    textBox_Dec.Text = DEC_string;
                    Hex_To_Bit();
                }
                catch
                {

                }
                return;
            }
            else if (textBox_Hex.TextLength == 0)
                textBox_Dec.Text = "";
            tamam = false;
        }

        private void TextBox_DEC_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_Dec.TextLength > 0) && (tamam == false))
            {
                try
                {
                    string DEC_textbox = textBox_Dec.Text.Replace(" ", "");
                    int uzunluk = textBox_Dec.TextLength;
                    if (uzunluk % 2 != 0)
                    {
                        uzunluk++;
                    }
                    byte[] hex_byte = new byte[uzunluk];
                    long DEC = Convert.ToInt64(DEC_textbox);
                    if (DEC < 256)
                    {
                        hex_byte = HexStringConverter.ToByteArray(DEC.ToString("X2"));
                    }
                    else if (DEC < 65536)
                    {
                        hex_byte = HexStringConverter.ToByteArray(DEC.ToString("X4"));
                    }
                    else if (DEC < 16777216)
                    {
                        hex_byte = HexStringConverter.ToByteArray(DEC.ToString("X6"));
                    }
                    else if (DEC < 4294967296)
                    {
                        hex_byte = HexStringConverter.ToByteArray(DEC.ToString("X8"));
                    }
                    else
                    {
                        string HEX_ERROR = "ERROR";
                        tamam = true;
                        textBox_Hex.Text = HEX_ERROR;
                        return;
                    }
                    string HEX = BitConverter.ToString(hex_byte).Replace("-", "");
                    tamam = true;
                    textBox_Hex.Text = HEX;
                    Hex_To_Bit();
                }
                catch
                {

                }
                return;
            }
            else if (textBox_Dec.TextLength == 0)
                textBox_Hex.Text = "";
            tamam = false;
        }

        static class HexStringConverter
        {
            public static byte[] ToByteArray(String HexString)
            {
                int NumberChars = HexString.Length;
                if ((NumberChars % 2) == 1)
                {
                    NumberChars += 1;
                    HexString = "0" + HexString;
                }

                byte[] bytes = new byte[NumberChars / 2];
                for (int i = 0; i < NumberChars; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
                }
                return bytes;
            }
        }

        private void Only_Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void Only_Hex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) == 'A') || (e.KeyChar == 'B') || (e.KeyChar == 'C') || (e.KeyChar == 'D') || (e.KeyChar == 'E') || (e.KeyChar == 'F'))
            {
                return;
            }
            if (((e.KeyChar) == 'a') || (e.KeyChar == 'b') || (e.KeyChar == 'c') || (e.KeyChar == 'd') || (e.KeyChar == 'e') || (e.KeyChar == 'f'))
            {
                return;
            }
            if ((e.KeyChar == '+') || (e.KeyChar == '-'))
            {
                return;
            }
            if (e.KeyChar == (char)13)
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Dec.Text)).ToString("X2");
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox_Dec.Text = "";
            textBox_Hex.Text = "";
            button_bit0.Text = "0";
            button_bit1.Text = "0";
            button_bit2.Text = "0";
            button_bit3.Text = "0";
            button_bit4.Text = "0";
            button_bit5.Text = "0";
            button_bit6.Text = "0";
            button_bit7.Text = "0";
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Opacity = 0.75;
            }
            catch
            {

            }
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Opacity = 1;
            }
            catch
            {

            }
        }


        private void Button_more_Click(object sender, EventArgs e)
        {
            if (bit_islemi)
            {
                bit_islemi = false;
                this.ClientSize = new System.Drawing.Size(100, 85);
            }
            else
            {
                bit_islemi = true;
                this.ClientSize = new System.Drawing.Size(100, 107);

            }
        }

        #region Bit işlemleri

        private void Button_bit0_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit0.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x01).ToString("X");
                button_bit0.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x01)).ToString("X");
                button_bit0.Text = "0";
            }
            label_Hex.Select();
        }

        private void Button_bit1_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit1.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x02).ToString("X");
                button_bit1.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x02)).ToString("X");
                button_bit1.Text = "0";
            }
            label_Hex.Select();
        }
        private void Button_bit2_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit2.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x04).ToString("X");
                button_bit2.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x04)).ToString("X");
                button_bit2.Text = "0";
            }
            label_Hex.Select();
        }

        private void Button_bit3_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit3.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x08).ToString("X");
                button_bit3.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x08)).ToString("X");
                button_bit3.Text = "0";
            }
            label_Hex.Select();

        }

        private void Button_bit4_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit4.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x10).ToString("X");
                button_bit4.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x10)).ToString("X");
                button_bit4.Text = "0";
            }
            label_Hex.Select();
        }

        private void Button_bit5_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit5.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x20).ToString("X");
                button_bit5.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x20)).ToString("X");
                button_bit5.Text = "0";
            }
            label_Hex.Select();
        }

        private void Button_bit6_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit6.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x40).ToString("X");
                button_bit6.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x40)).ToString("X");
                button_bit6.Text = "0";
            }
            label_Hex.Select();
        }

        private void Button_bit7_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.Text == "")
                textBox_Hex.Text = "0";
            if (button_bit7.Text == "0")
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) | 0x80).ToString("X");
                button_bit7.Text = "1";
            }
            else
            {
                textBox_Hex.Text = (Convert.ToInt64(textBox_Hex.Text, 16) & ~(0x80)).ToString("X");
                button_bit7.Text = "0";
            }
            label_Hex.Select();
        }

        #endregion Bit işlemleri
        private void Button_copy_hex_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.TextLength > 0)
                Clipboard.SetText(textBox_Hex.Text);
        }

        private void Button_copy_dec_Click(object sender, EventArgs e)
        {
            if (textBox_Hex.TextLength > 0)
                Clipboard.SetText(textBox_Dec.Text);
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Location = new System.Drawing.Point(1024, 800);
            Hex_Dec_Tool.Properties.Settings.Default.Default_Location_X = Location.X;
            Hex_Dec_Tool.Properties.Settings.Default.Default_Location_Y = Location.Y;
            Hex_Dec_Tool.Properties.Settings.Default.Save();
            this.TopMost = false;
            this.TopMost = true;
        }

        private void Button2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_click = false;
        }
    }

    #region KeyboardHook
    public sealed class KeyboardHook : IDisposable
    {
        // Registers a hot key with Windows.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// Represents the window that is used internally to get the messages.
        /// </summary>
        private class Window : NativeWindow, IDisposable
        {
            private static int WM_HOTKEY = 0x0312;

            public Window()
            {
                // create the handle for the window.
                this.CreateHandle(new CreateParams());
            }

            /// <summary>
            /// Overridden to get the notifications.
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                // check if we got a hot key pressed.
                if (m.Msg == WM_HOTKEY)
                {
                    // get the keys.
                    Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                    ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

                    // invoke the event to notify the parent.
                    if (KeyPressed != null)
                        KeyPressed(this, new KeyPressedEventArgs(modifier, key));
                }
            }

            public event EventHandler<KeyPressedEventArgs> KeyPressed;

            #region IDisposable Members

            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }

        private Window _window = new Window();
        private int _currentId;

        public KeyboardHook()
        {
            // register the event of the inner native window.
            _window.KeyPressed += delegate (object sender, KeyPressedEventArgs args)
            {
                if (KeyPressed != null)
                    KeyPressed(this, args);
            };
        }

        /// <summary>
        /// Registers a hot key in the system.
        /// </summary>
        /// <param name="modifier">The modifiers that are associated with the hot key.</param>
        /// <param name="key">The key itself that is associated with the hot key.</param>
        public void RegisterHotKey(ModifierKeys modifier, Keys key)
        {
            // increment the counter.
            _currentId = _currentId + 1;

            // register the hot key.
            if (!RegisterHotKey(_window.Handle, _currentId, (uint)modifier, (uint)key))
                throw new InvalidOperationException("Couldn’t register the hot key.");
        }

        /// <summary>
        /// A hot key has been pressed.
        /// </summary>
        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        #region IDisposable Members

        public void Dispose()
        {
            // unregister all the registered hot keys.
            for (int i = _currentId; i > 0; i--)
            {
                UnregisterHotKey(_window.Handle, i);
            }

            // dispose the inner native window.
            _window.Dispose();
        }

        #endregion KeyboardHook
    }

    /// <summary>
    /// Event Args for the event that is fired after the hot key has been pressed.
    /// </summary>
    public class KeyPressedEventArgs : EventArgs
    {
        private ModifierKeys _modifier;
        private Keys _key;

        internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
        {
            _modifier = modifier;
            _key = key;
        }

        public ModifierKeys Modifier
        {
            get { return _modifier; }
        }

        public Keys Key
        {
            get { return _key; }
        }
    }

    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModifierKeys : uint
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }

    #endregion

    #region AutoClosingMessageBox
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {

            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }

    #endregion AutoClosingMessageBox

}

