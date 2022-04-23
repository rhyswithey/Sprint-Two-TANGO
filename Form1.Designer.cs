namespace SPRINT_TWO
{
    partial class TangoInc
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
            this.findbutton = new System.Windows.Forms.Button();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.initilise = new System.Windows.Forms.Button();
            this.Arraybox = new System.Windows.Forms.ListBox();
            this.deletbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bubblesort = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.midextreme = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.range = new System.Windows.Forms.Button();
            this.sequentialsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findbutton
            // 
            this.findbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.findbutton.Location = new System.Drawing.Point(176, 112);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(99, 20);
            this.findbutton.TabIndex = 1;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // inputbox
            // 
            this.inputbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputbox.Location = new System.Drawing.Point(175, 225);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(100, 26);
            this.inputbox.TabIndex = 2;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            this.inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputbox_KeyDown);
            this.inputbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputbox_KeyPress);
            // 
            // addbutton
            // 
            this.addbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbutton.Location = new System.Drawing.Point(176, 138);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(99, 23);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // initilise
            // 
            this.initilise.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.initilise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initilise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initilise.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.initilise.Location = new System.Drawing.Point(12, 80);
            this.initilise.Name = "initilise";
            this.initilise.Size = new System.Drawing.Size(139, 26);
            this.initilise.TabIndex = 6;
            this.initilise.Text = "Initilise";
            this.initilise.UseVisualStyleBackColor = false;
            this.initilise.Click += new System.EventHandler(this.initilise_Click);
            // 
            // Arraybox
            // 
            this.Arraybox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Arraybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arraybox.ForeColor = System.Drawing.SystemColors.Window;
            this.Arraybox.FormattingEnabled = true;
            this.Arraybox.ItemHeight = 16;
            this.Arraybox.Location = new System.Drawing.Point(12, 112);
            this.Arraybox.Name = "Arraybox";
            this.Arraybox.Size = new System.Drawing.Size(139, 404);
            this.Arraybox.TabIndex = 7;
            this.Arraybox.Click += new System.EventHandler(this.Arraybox_Click);
            // 
            // deletbutton
            // 
            this.deletbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletbutton.Location = new System.Drawing.Point(176, 167);
            this.deletbutton.Name = "deletbutton";
            this.deletbutton.Size = new System.Drawing.Size(99, 23);
            this.deletbutton.TabIndex = 8;
            this.deletbutton.Text = "Delete";
            this.deletbutton.UseVisualStyleBackColor = true;
            this.deletbutton.Click += new System.EventHandler(this.deletbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(277, 69);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Astronomical Processing";
            // 
            // bubblesort
            // 
            this.bubblesort.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bubblesort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bubblesort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bubblesort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubblesort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bubblesort.Location = new System.Drawing.Point(175, 80);
            this.bubblesort.Name = "bubblesort";
            this.bubblesort.Size = new System.Drawing.Size(100, 26);
            this.bubblesort.TabIndex = 10;
            this.bubblesort.Text = "Sort";
            this.bubblesort.UseVisualStyleBackColor = false;
            this.bubblesort.Click += new System.EventHandler(this.bubblesort_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(161, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Calculations";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(175, 427);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // midextreme
            // 
            this.midextreme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.midextreme.Location = new System.Drawing.Point(175, 311);
            this.midextreme.Name = "midextreme";
            this.midextreme.Size = new System.Drawing.Size(101, 23);
            this.midextreme.TabIndex = 13;
            this.midextreme.Text = "mid-extreme";
            this.midextreme.UseVisualStyleBackColor = true;
            this.midextreme.Click += new System.EventHandler(this.midextreme_Click);
            // 
            // mode
            // 
            this.mode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mode.Location = new System.Drawing.Point(175, 340);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(101, 23);
            this.mode.TabIndex = 14;
            this.mode.Text = "mode";
            this.mode.UseVisualStyleBackColor = true;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // average
            // 
            this.average.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.average.Location = new System.Drawing.Point(175, 369);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(101, 23);
            this.average.TabIndex = 15;
            this.average.Text = "average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.average_Click);
            // 
            // range
            // 
            this.range.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.range.Location = new System.Drawing.Point(175, 398);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(101, 23);
            this.range.TabIndex = 16;
            this.range.Text = "range";
            this.range.UseVisualStyleBackColor = true;
            this.range.Click += new System.EventHandler(this.range_Click);
            // 
            // sequentialsearch
            // 
            this.sequentialsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sequentialsearch.Location = new System.Drawing.Point(176, 196);
            this.sequentialsearch.Name = "sequentialsearch";
            this.sequentialsearch.Size = new System.Drawing.Size(99, 23);
            this.sequentialsearch.TabIndex = 17;
            this.sequentialsearch.Text = "sequential search";
            this.sequentialsearch.UseVisualStyleBackColor = true;
            this.sequentialsearch.Click += new System.EventHandler(this.sequentialsearch_Click);
            // 
            // TangoInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(292, 542);
            this.Controls.Add(this.sequentialsearch);
            this.Controls.Add(this.range);
            this.Controls.Add(this.average);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.midextreme);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bubblesort);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.deletbutton);
            this.Controls.Add(this.Arraybox);
            this.Controls.Add(this.initilise);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.findbutton);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "TangoInc";
            this.Text = "Tango Inc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button initilise;
        private System.Windows.Forms.ListBox Arraybox;
        private System.Windows.Forms.Button deletbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bubblesort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button midextreme;
        private System.Windows.Forms.Button mode;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button range;
        private System.Windows.Forms.Button sequentialsearch;
    }
}

