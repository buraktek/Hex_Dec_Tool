
namespace Hex_Dec_Tool
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Hex = new System.Windows.Forms.Label();
            this.label_Dec = new System.Windows.Forms.Label();
            this.textBox_Hex = new System.Windows.Forms.TextBox();
            this.textBox_Dec = new System.Windows.Forms.TextBox();
            this.button_bit7 = new System.Windows.Forms.Button();
            this.button_bit6 = new System.Windows.Forms.Button();
            this.button_bit4 = new System.Windows.Forms.Button();
            this.button_bit1 = new System.Windows.Forms.Button();
            this.button_bit0 = new System.Windows.Forms.Button();
            this.button_bit2 = new System.Windows.Forms.Button();
            this.button_bit5 = new System.Windows.Forms.Button();
            this.button_bit3 = new System.Windows.Forms.Button();
            this.button_copy_dec = new System.Windows.Forms.Button();
            this.button_copy_hex = new System.Windows.Forms.Button();
            this.button_more = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.timer_resizer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_Hex
            // 
            this.label_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Hex.Location = new System.Drawing.Point(5, 2);
            this.label_Hex.Name = "label_Hex";
            this.label_Hex.Size = new System.Drawing.Size(77, 14);
            this.label_Hex.TabIndex = 1;
            this.label_Hex.Text = "Hex";
            this.label_Hex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Hex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Action_MouseDown);
            this.label_Hex.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.label_Hex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label_Hex.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseUp);
            // 
            // label_Dec
            // 
            this.label_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Dec.Location = new System.Drawing.Point(2, 43);
            this.label_Dec.Name = "label_Dec";
            this.label_Dec.Size = new System.Drawing.Size(80, 14);
            this.label_Dec.TabIndex = 2;
            this.label_Dec.Text = "Dec";
            this.label_Dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Dec.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.label_Dec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // textBox_Hex
            // 
            this.textBox_Hex.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Hex.Location = new System.Drawing.Point(2, 22);
            this.textBox_Hex.MaxLength = 15;
            this.textBox_Hex.Name = "textBox_Hex";
            this.textBox_Hex.Size = new System.Drawing.Size(80, 20);
            this.textBox_Hex.TabIndex = 3;
            this.textBox_Hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Hex.TextChanged += new System.EventHandler(this.TextBox_Hex_TextChanged);
            this.textBox_Hex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Hex_KeyPress);
            this.textBox_Hex.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.textBox_Hex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // textBox_Dec
            // 
            this.textBox_Dec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Dec.Location = new System.Drawing.Point(2, 61);
            this.textBox_Dec.MaxLength = 15;
            this.textBox_Dec.Name = "textBox_Dec";
            this.textBox_Dec.Size = new System.Drawing.Size(80, 20);
            this.textBox_Dec.TabIndex = 4;
            this.textBox_Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Dec.TextChanged += new System.EventHandler(this.TextBox_DEC_TextChanged);
            this.textBox_Dec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric_KeyPress);
            this.textBox_Dec.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.textBox_Dec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit7
            // 
            this.button_bit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit7.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.button_bit7.Location = new System.Drawing.Point(0, 85);
            this.button_bit7.Name = "button_bit7";
            this.button_bit7.Size = new System.Drawing.Size(12, 22);
            this.button_bit7.TabIndex = 8;
            this.button_bit7.Text = "0";
            this.button_bit7.UseVisualStyleBackColor = true;
            this.button_bit7.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit7.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit6
            // 
            this.button_bit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit6.Location = new System.Drawing.Point(11, 85);
            this.button_bit6.Name = "button_bit6";
            this.button_bit6.Size = new System.Drawing.Size(12, 22);
            this.button_bit6.TabIndex = 9;
            this.button_bit6.Text = "0";
            this.button_bit6.UseVisualStyleBackColor = true;
            this.button_bit6.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit6.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit4
            // 
            this.button_bit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit4.Location = new System.Drawing.Point(33, 85);
            this.button_bit4.Name = "button_bit4";
            this.button_bit4.Size = new System.Drawing.Size(12, 22);
            this.button_bit4.TabIndex = 10;
            this.button_bit4.Text = "0";
            this.button_bit4.UseVisualStyleBackColor = true;
            this.button_bit4.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit4.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit1
            // 
            this.button_bit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit1.Location = new System.Drawing.Point(77, 85);
            this.button_bit1.Name = "button_bit1";
            this.button_bit1.Size = new System.Drawing.Size(12, 22);
            this.button_bit1.TabIndex = 11;
            this.button_bit1.Text = "0";
            this.button_bit1.UseVisualStyleBackColor = true;
            this.button_bit1.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit1.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit0
            // 
            this.button_bit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit0.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit0.Location = new System.Drawing.Point(88, 85);
            this.button_bit0.Name = "button_bit0";
            this.button_bit0.Size = new System.Drawing.Size(12, 22);
            this.button_bit0.TabIndex = 12;
            this.button_bit0.Text = "0";
            this.button_bit0.UseVisualStyleBackColor = true;
            this.button_bit0.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit0.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit2
            // 
            this.button_bit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit2.Location = new System.Drawing.Point(66, 85);
            this.button_bit2.Name = "button_bit2";
            this.button_bit2.Size = new System.Drawing.Size(12, 22);
            this.button_bit2.TabIndex = 13;
            this.button_bit2.Text = "0";
            this.button_bit2.UseVisualStyleBackColor = true;
            this.button_bit2.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit2.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit5
            // 
            this.button_bit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit5.Location = new System.Drawing.Point(22, 85);
            this.button_bit5.Name = "button_bit5";
            this.button_bit5.Size = new System.Drawing.Size(12, 22);
            this.button_bit5.TabIndex = 14;
            this.button_bit5.Text = "0";
            this.button_bit5.UseVisualStyleBackColor = true;
            this.button_bit5.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit5.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_bit3
            // 
            this.button_bit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bit3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit3.Location = new System.Drawing.Point(55, 85);
            this.button_bit3.Name = "button_bit3";
            this.button_bit3.Size = new System.Drawing.Size(12, 22);
            this.button_bit3.TabIndex = 15;
            this.button_bit3.Text = "0";
            this.button_bit3.UseVisualStyleBackColor = true;
            this.button_bit3.Click += new System.EventHandler(this.Button_bits_Click);
            this.button_bit3.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_bit3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_copy_dec
            // 
            this.button_copy_dec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_copy_dec.BackgroundImage = global::Hex_Dec_Tool.Properties.Resources._1740144041560146818_20;
            this.button_copy_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_copy_dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copy_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_copy_dec.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_copy_dec.Location = new System.Drawing.Point(82, 61);
            this.button_copy_dec.Name = "button_copy_dec";
            this.button_copy_dec.Size = new System.Drawing.Size(18, 18);
            this.button_copy_dec.TabIndex = 17;
            this.button_copy_dec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_copy_dec.UseVisualStyleBackColor = false;
            this.button_copy_dec.Click += new System.EventHandler(this.Button_copy_dec_Click);
            this.button_copy_dec.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_copy_dec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_copy_hex
            // 
            this.button_copy_hex.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_copy_hex.BackgroundImage = global::Hex_Dec_Tool.Properties.Resources._1740144041560146818_20;
            this.button_copy_hex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_copy_hex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copy_hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_copy_hex.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_copy_hex.Location = new System.Drawing.Point(82, 22);
            this.button_copy_hex.Name = "button_copy_hex";
            this.button_copy_hex.Size = new System.Drawing.Size(18, 18);
            this.button_copy_hex.TabIndex = 16;
            this.button_copy_hex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_copy_hex.UseVisualStyleBackColor = false;
            this.button_copy_hex.Click += new System.EventHandler(this.Button_copy_hex_Click);
            this.button_copy_hex.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_copy_hex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_more
            // 
            this.button_more.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_more.BackgroundImage = global::Hex_Dec_Tool.Properties.Resources.Messaging_More_icon;
            this.button_more.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_more.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_more.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_more.Location = new System.Drawing.Point(82, 44);
            this.button_more.Name = "button_more";
            this.button_more.Size = new System.Drawing.Size(14, 14);
            this.button_more.TabIndex = 7;
            this.button_more.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_more.UseVisualStyleBackColor = false;
            this.button_more.Click += new System.EventHandler(this.Button_more_Click);
            this.button_more.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_more.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_reset.BackgroundImage = global::Hex_Dec_Tool.Properties.Resources.icons8_available_updates_48;
            this.button_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_reset.Location = new System.Drawing.Point(3, 2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(15, 15);
            this.button_reset.TabIndex = 6;
            this.button_reset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            this.button_reset.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_reset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // button_move
            // 
            this.button_move.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_move.BackgroundImage = global::Hex_Dec_Tool.Properties.Resources.icons8_move_32;
            this.button_move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_move.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_move.Location = new System.Drawing.Point(68, 2);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(14, 14);
            this.button_move.TabIndex = 5;
            this.button_move.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_move.UseVisualStyleBackColor = false;
            this.button_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Action_MouseDown);
            this.button_move.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.button_move.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseUp);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_close.BackgroundImage = global::Hex_Dec_Tool.Properties.Resources.icons8_close_window_14;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_close.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_close.Location = new System.Drawing.Point(85, 2);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(14, 14);
            this.button_close.TabIndex = 0;
            this.button_close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.Button_close_Click);
            this.button_close.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.button_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // timer_resizer
            // 
            this.timer_resizer.Enabled = true;
            this.timer_resizer.Tick += new System.EventHandler(this.timer_resizer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(100, 106);
            this.Controls.Add(this.button_copy_dec);
            this.Controls.Add(this.button_copy_hex);
            this.Controls.Add(this.button_bit3);
            this.Controls.Add(this.button_bit5);
            this.Controls.Add(this.button_bit2);
            this.Controls.Add(this.button_bit0);
            this.Controls.Add(this.button_bit1);
            this.Controls.Add(this.button_bit4);
            this.Controls.Add(this.button_bit6);
            this.Controls.Add(this.button_bit7);
            this.Controls.Add(this.button_more);
            this.Controls.Add(this.label_Dec);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.textBox_Dec);
            this.Controls.Add(this.textBox_Hex);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_Hex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1750, 800);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_Hex;
        private System.Windows.Forms.Label label_Dec;
        private System.Windows.Forms.TextBox textBox_Hex;
        private System.Windows.Forms.TextBox textBox_Dec;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_more;
        private System.Windows.Forms.Button button_bit7;
        private System.Windows.Forms.Button button_bit6;
        private System.Windows.Forms.Button button_bit4;
        private System.Windows.Forms.Button button_bit1;
        private System.Windows.Forms.Button button_bit0;
        private System.Windows.Forms.Button button_bit2;
        private System.Windows.Forms.Button button_bit5;
        private System.Windows.Forms.Button button_bit3;
        private System.Windows.Forms.Button button_copy_hex;
        private System.Windows.Forms.Button button_copy_dec;
        private System.Windows.Forms.Timer timer_resizer;
    }
}

