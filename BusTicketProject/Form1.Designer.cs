
namespace BusTicketProject
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
            this.components = new System.ComponentModel.Container();
            this.dp = new System.Windows.Forms.Label();
            this.ap = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dp
            // 
            this.dp.AutoSize = true;
            this.dp.Location = new System.Drawing.Point(187, 30);
            this.dp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(178, 25);
            this.dp.TabIndex = 0;
            this.dp.Text = "Departure Point";
            // 
            // ap
            // 
            this.ap.AutoSize = true;
            this.ap.Location = new System.Drawing.Point(199, 158);
            this.ap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(151, 25);
            this.ap.TabIndex = 1;
            this.ap.Text = "Arrival Point";
            this.ap.Click += new System.EventHandler(this.label2_Click);
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(187, 278);
            this.dt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(173, 25);
            this.dt.TabIndex = 2;
            this.dt.Text = "Departure Time";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(89, 382);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(354, 102);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Find a Bus Ticket";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(89, 188);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(358, 33);
            this.comboBox2.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(354, 32);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(577, 672);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.dp);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dp;
        private System.Windows.Forms.Label ap;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

