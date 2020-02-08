namespace harjoitustyö
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_tiedosto = new System.Windows.Forms.ToolStripDropDownButton();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_väri = new System.Windows.Forms.ToolStripButton();
            this.textBox_haku = new System.Windows.Forms.TextBox();
            this.button_haku = new System.Windows.Forms.Button();
            this.richTextBox_main = new System.Windows.Forms.RichTextBox();
            this.button_kopio = new System.Windows.Forms.Button();
            this.button_kumi = new System.Windows.Forms.Button();
            this.label_matsit = new System.Windows.Forms.Label();
            this.button_seuraava = new System.Windows.Forms.Button();
            this.button_takaisin = new System.Windows.Forms.Button();
            this.toolStripButton_debug = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tiedosto,
            this.toolStripSeparator1,
            this.toolStripButton_väri,
            this.toolStripButton_debug});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_tiedosto
            // 
            this.toolStrip_tiedosto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_tiedosto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallennaToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.hakuToolStripMenuItem,
            this.suljeToolStripMenuItem});
            this.toolStrip_tiedosto.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_tiedosto.Image")));
            this.toolStrip_tiedosto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_tiedosto.Name = "toolStrip_tiedosto";
            this.toolStrip_tiedosto.Size = new System.Drawing.Size(66, 22);
            this.toolStrip_tiedosto.Text = "Tiedosto";
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // hakuToolStripMenuItem
            // 
            this.hakuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regexToolStripMenuItem});
            this.hakuToolStripMenuItem.Name = "hakuToolStripMenuItem";
            this.hakuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakuToolStripMenuItem.Text = "Haku";
            this.hakuToolStripMenuItem.Click += new System.EventHandler(this.hakuToolStripMenuItem_Click);
            // 
            // regexToolStripMenuItem
            // 
            this.regexToolStripMenuItem.Name = "regexToolStripMenuItem";
            this.regexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regexToolStripMenuItem.Text = "Regex";
            this.regexToolStripMenuItem.Click += new System.EventHandler(this.regexToolStripMenuItem_Click);
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suljeToolStripMenuItem.Text = "Sulje";
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_väri
            // 
            this.toolStripButton_väri.AutoToolTip = false;
            this.toolStripButton_väri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_väri.Image = global::harjoitustyö.Properties.Resources.aurinko;
            this.toolStripButton_väri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_väri.Name = "toolStripButton_väri";
            this.toolStripButton_väri.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_väri.ToolTipText = "Tumma moodi";
            this.toolStripButton_väri.Click += new System.EventHandler(this.toolStripButton_väri_Click);
            // 
            // textBox_haku
            // 
            this.textBox_haku.Location = new System.Drawing.Point(12, 447);
            this.textBox_haku.Name = "textBox_haku";
            this.textBox_haku.Size = new System.Drawing.Size(100, 20);
            this.textBox_haku.TabIndex = 2;
            this.textBox_haku.Visible = false;
            // 
            // button_haku
            // 
            this.button_haku.Location = new System.Drawing.Point(118, 446);
            this.button_haku.Name = "button_haku";
            this.button_haku.Size = new System.Drawing.Size(75, 23);
            this.button_haku.TabIndex = 4;
            this.button_haku.Text = "button1";
            this.button_haku.UseVisualStyleBackColor = true;
            this.button_haku.Visible = false;
            this.button_haku.Click += new System.EventHandler(this.button_haku_Click);
            // 
            // richTextBox_main
            // 
            this.richTextBox_main.Location = new System.Drawing.Point(12, 28);
            this.richTextBox_main.Name = "richTextBox_main";
            this.richTextBox_main.Size = new System.Drawing.Size(776, 413);
            this.richTextBox_main.TabIndex = 5;
            this.richTextBox_main.Text = "";
            // 
            // button_kopio
            // 
            this.button_kopio.BackgroundImage = global::harjoitustyö.Properties.Resources.kopio;
            this.button_kopio.Location = new System.Drawing.Point(235, 447);
            this.button_kopio.Name = "button_kopio";
            this.button_kopio.Size = new System.Drawing.Size(30, 30);
            this.button_kopio.TabIndex = 7;
            this.button_kopio.UseVisualStyleBackColor = true;
            this.button_kopio.Visible = false;
            this.button_kopio.Click += new System.EventHandler(this.button_kopio_Click);
            this.button_kopio.MouseHover += new System.EventHandler(this.button_kopio_MouseHover);
            // 
            // button_kumi
            // 
            this.button_kumi.BackgroundImage = global::harjoitustyö.Properties.Resources.pyyhekumi30x30;
            this.button_kumi.Location = new System.Drawing.Point(199, 447);
            this.button_kumi.Name = "button_kumi";
            this.button_kumi.Size = new System.Drawing.Size(30, 30);
            this.button_kumi.TabIndex = 6;
            this.button_kumi.UseVisualStyleBackColor = true;
            this.button_kumi.Visible = false;
            this.button_kumi.Click += new System.EventHandler(this.button_kumi_Click);
            this.button_kumi.MouseHover += new System.EventHandler(this.button_kumi_MouseHover);
            // 
            // label_matsit
            // 
            this.label_matsit.AutoSize = true;
            this.label_matsit.Location = new System.Drawing.Point(271, 444);
            this.label_matsit.Name = "label_matsit";
            this.label_matsit.Size = new System.Drawing.Size(35, 13);
            this.label_matsit.TabIndex = 8;
            this.label_matsit.Text = "label1";
            this.label_matsit.Visible = false;
            // 
            // button_seuraava
            // 
            this.button_seuraava.Location = new System.Drawing.Point(394, 444);
            this.button_seuraava.Name = "button_seuraava";
            this.button_seuraava.Size = new System.Drawing.Size(69, 33);
            this.button_seuraava.TabIndex = 10;
            this.button_seuraava.Text = ">";
            this.button_seuraava.UseVisualStyleBackColor = true;
            this.button_seuraava.Visible = false;
            this.button_seuraava.Click += new System.EventHandler(this.button_seuraava_Click);
            // 
            // button_takaisin
            // 
            this.button_takaisin.Location = new System.Drawing.Point(319, 444);
            this.button_takaisin.Name = "button_takaisin";
            this.button_takaisin.Size = new System.Drawing.Size(69, 33);
            this.button_takaisin.TabIndex = 11;
            this.button_takaisin.Text = "<";
            this.button_takaisin.UseVisualStyleBackColor = true;
            this.button_takaisin.Visible = false;
            this.button_takaisin.Click += new System.EventHandler(this.button_takaisin_Click);
            // 
            // toolStripButton_debug
            // 
            this.toolStripButton_debug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_debug.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_debug.Image")));
            this.toolStripButton_debug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_debug.Name = "toolStripButton_debug";
            this.toolStripButton_debug.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_debug.Text = "?";
            this.toolStripButton_debug.ToolTipText = "Avaa regex debuggeri";
            this.toolStripButton_debug.Click += new System.EventHandler(this.toolStripButton_debug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.button_takaisin);
            this.Controls.Add(this.button_seuraava);
            this.Controls.Add(this.label_matsit);
            this.Controls.Add(this.button_kopio);
            this.Controls.Add(this.button_kumi);
            this.Controls.Add(this.richTextBox_main);
            this.Controls.Add(this.button_haku);
            this.Controls.Add(this.textBox_haku);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Tekstieditori";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStrip_tiedosto;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakuToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_väri;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_haku;
        private System.Windows.Forms.Button button_haku;
        private System.Windows.Forms.RichTextBox richTextBox_main;
        private System.Windows.Forms.Button button_kumi;
        private System.Windows.Forms.Button button_kopio;
        private System.Windows.Forms.ToolStripMenuItem regexToolStripMenuItem;
        private System.Windows.Forms.Label label_matsit;
        private System.Windows.Forms.Button button_seuraava;
        private System.Windows.Forms.Button button_takaisin;
        private System.Windows.Forms.ToolStripButton toolStripButton_debug;
    }
}

