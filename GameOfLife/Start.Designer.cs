namespace GameOfLife
{
    partial class FrmStart
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_begin = new System.Windows.Forms.Button();
            this.btn_rdm_begin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_turns = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_prob = new System.Windows.Forms.NumericUpDown();
            this.nud_width = new System.Windows.Forms.NumericUpDown();
            this.nud_height = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_turns)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(447, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Design your game";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_begin);
            this.groupBox4.Controls.Add(this.btn_rdm_begin);
            this.groupBox4.Location = new System.Drawing.Point(25, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 89);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Start simulations";
            // 
            // btn_begin
            // 
            this.btn_begin.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_begin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_begin.ForeColor = System.Drawing.Color.White;
            this.btn_begin.Location = new System.Drawing.Point(216, 28);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(123, 36);
            this.btn_begin.TabIndex = 5;
            this.btn_begin.Text = "Begin";
            this.btn_begin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_begin.UseVisualStyleBackColor = false;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // btn_rdm_begin
            // 
            this.btn_rdm_begin.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_rdm_begin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rdm_begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rdm_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rdm_begin.ForeColor = System.Drawing.Color.White;
            this.btn_rdm_begin.Location = new System.Drawing.Point(27, 28);
            this.btn_rdm_begin.Name = "btn_rdm_begin";
            this.btn_rdm_begin.Size = new System.Drawing.Size(183, 36);
            this.btn_rdm_begin.TabIndex = 4;
            this.btn_rdm_begin.Text = "Random inputs";
            this.btn_rdm_begin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rdm_begin.UseVisualStyleBackColor = false;
            this.btn_rdm_begin.Click += new System.EventHandler(this.btn_rdm_begin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nud_turns);
            this.groupBox3.Location = new System.Drawing.Point(25, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Grid output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of turns";
            // 
            // nud_turns
            // 
            this.nud_turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_turns.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_turns.Location = new System.Drawing.Point(268, 30);
            this.nud_turns.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nud_turns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_turns.Name = "nud_turns";
            this.nud_turns.Size = new System.Drawing.Size(71, 29);
            this.nud_turns.TabIndex = 3;
            this.nud_turns.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nud_prob);
            this.groupBox2.Controls.Add(this.nud_width);
            this.groupBox2.Controls.Add(this.nud_height);
            this.groupBox2.Location = new System.Drawing.Point(25, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Grid inputs (max. values)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Probability of live cells";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Height (# of cells)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width (# of cells)";
            // 
            // nud_prob
            // 
            this.nud_prob.DecimalPlaces = 2;
            this.nud_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_prob.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nud_prob.Location = new System.Drawing.Point(268, 82);
            this.nud_prob.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_prob.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob.Name = "nud_prob";
            this.nud_prob.Size = new System.Drawing.Size(71, 29);
            this.nud_prob.TabIndex = 2;
            this.nud_prob.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // nud_width
            // 
            this.nud_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_width.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_width.Location = new System.Drawing.Point(268, 30);
            this.nud_width.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_width.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_width.Name = "nud_width";
            this.nud_width.Size = new System.Drawing.Size(71, 29);
            this.nud_width.TabIndex = 0;
            this.nud_width.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // nud_height
            // 
            this.nud_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_height.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_height.Location = new System.Drawing.Point(268, 56);
            this.nud_height.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_height.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_height.Name = "nud_height";
            this.nud_height.Size = new System.Drawing.Size(71, 29);
            this.nud_height.TabIndex = 1;
            this.nud_height.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStart";
            this.Text = "Game of Life - Start";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_turns)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_turns;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_prob;
        private System.Windows.Forms.NumericUpDown nud_width;
        private System.Windows.Forms.NumericUpDown nud_height;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.Button btn_rdm_begin;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}