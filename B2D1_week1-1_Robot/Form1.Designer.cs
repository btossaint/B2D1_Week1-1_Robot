namespace B2D1_week1_1_Robot
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
            this.nudRichting = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPlaats = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bInitialiseer = new System.Windows.Forms.Button();
            this.bzetStap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bgaNaar = new System.Windows.Forms.Button();
            this.lgaNaar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRichting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaats)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRichting
            // 
            this.nudRichting.Location = new System.Drawing.Point(24, 33);
            this.nudRichting.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRichting.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudRichting.Name = "nudRichting";
            this.nudRichting.Size = new System.Drawing.Size(61, 20);
            this.nudRichting.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Richting";
            // 
            // nudPlaats
            // 
            this.nudPlaats.Location = new System.Drawing.Point(123, 33);
            this.nudPlaats.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudPlaats.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.nudPlaats.Name = "nudPlaats";
            this.nudPlaats.Size = new System.Drawing.Size(72, 20);
            this.nudPlaats.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plaats";
            // 
            // bInitialiseer
            // 
            this.bInitialiseer.Location = new System.Drawing.Point(242, 33);
            this.bInitialiseer.Name = "bInitialiseer";
            this.bInitialiseer.Size = new System.Drawing.Size(75, 23);
            this.bInitialiseer.TabIndex = 4;
            this.bInitialiseer.Text = "Initialiseer";
            this.bInitialiseer.UseVisualStyleBackColor = true;
            this.bInitialiseer.Click += new System.EventHandler(this.bInitialiseer_Click);
            // 
            // bzetStap
            // 
            this.bzetStap.Location = new System.Drawing.Point(99, 88);
            this.bzetStap.Name = "bzetStap";
            this.bzetStap.Size = new System.Drawing.Size(127, 23);
            this.bzetStap.TabIndex = 5;
            this.bzetStap.Text = "Zet stap";
            this.bzetStap.UseVisualStyleBackColor = true;
            this.bzetStap.Click += new System.EventHandler(this.bzetStap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "50";
            // 
            // bgaNaar
            // 
            this.bgaNaar.Location = new System.Drawing.Point(194, 174);
            this.bgaNaar.Name = "bgaNaar";
            this.bgaNaar.Size = new System.Drawing.Size(75, 23);
            this.bgaNaar.TabIndex = 7;
            this.bgaNaar.Text = "Ga naar";
            this.bgaNaar.UseVisualStyleBackColor = true;
            this.bgaNaar.Click += new System.EventHandler(this.bgaNaar_Click);
            // 
            // lgaNaar
            // 
            this.lgaNaar.AutoSize = true;
            this.lgaNaar.Location = new System.Drawing.Point(24, 155);
            this.lgaNaar.Name = "lgaNaar";
            this.lgaNaar.Size = new System.Drawing.Size(47, 13);
            this.lgaNaar.TabIndex = 8;
            this.lgaNaar.Text = "Ga Naar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.lgaNaar);
            this.Controls.Add(this.bgaNaar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bzetStap);
            this.Controls.Add(this.bInitialiseer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPlaats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRichting);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudRichting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRichting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPlaats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bInitialiseer;
        private System.Windows.Forms.Button bzetStap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bgaNaar;
        private System.Windows.Forms.Label lgaNaar;
    }
}

