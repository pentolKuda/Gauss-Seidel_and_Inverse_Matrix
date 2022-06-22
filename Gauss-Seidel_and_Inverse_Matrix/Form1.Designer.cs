
namespace Gauss_Seidel_and_Inverse_Matrix
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGauss = new System.Windows.Forms.RadioButton();
            this.rbInverse = new System.Windows.Forms.RadioButton();
            this.tbInputNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupEquation = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbOk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupEquation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInverse);
            this.groupBox1.Controls.Add(this.rbGauss);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Method";
            // 
            // rbGauss
            // 
            this.rbGauss.AutoSize = true;
            this.rbGauss.Location = new System.Drawing.Point(28, 35);
            this.rbGauss.Name = "rbGauss";
            this.rbGauss.Size = new System.Drawing.Size(114, 21);
            this.rbGauss.TabIndex = 0;
            this.rbGauss.TabStop = true;
            this.rbGauss.Text = "Gauss-Seidel";
            this.rbGauss.UseVisualStyleBackColor = true;
            // 
            // rbInverse
            // 
            this.rbInverse.AutoSize = true;
            this.rbInverse.Location = new System.Drawing.Point(28, 61);
            this.rbInverse.Name = "rbInverse";
            this.rbInverse.Size = new System.Drawing.Size(116, 21);
            this.rbInverse.TabIndex = 1;
            this.rbInverse.TabStop = true;
            this.rbInverse.Text = "Inverse Matrix";
            this.rbInverse.UseVisualStyleBackColor = true;
            // 
            // tbInputNumber
            // 
            this.tbInputNumber.Location = new System.Drawing.Point(121, 33);
            this.tbInputNumber.Name = "tbInputNumber";
            this.tbInputNumber.Size = new System.Drawing.Size(100, 22);
            this.tbInputNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOk);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbInputNumber);
            this.groupBox2.Location = new System.Drawing.Point(280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equation Setup";
            // 
            // groupEquation
            // 
            this.groupEquation.Controls.Add(this.dataGridView2);
            this.groupEquation.Controls.Add(this.dataGridView1);
            this.groupEquation.Controls.Add(this.button5);
            this.groupEquation.Controls.Add(this.button1);
            this.groupEquation.Controls.Add(this.button2);
            this.groupEquation.Controls.Add(this.label6);
            this.groupEquation.Controls.Add(this.label5);
            this.groupEquation.Location = new System.Drawing.Point(12, 170);
            this.groupEquation.Name = "groupEquation";
            this.groupEquation.Size = new System.Drawing.Size(607, 533);
            this.groupEquation.TabIndex = 7;
            this.groupEquation.TabStop = false;
            this.groupEquation.Text = "Equation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matrix Size Equation:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "number";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Solve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbOk
            // 
            this.cbOk.AutoSize = true;
            this.cbOk.Location = new System.Drawing.Point(121, 76);
            this.cbOk.Name = "cbOk";
            this.cbOk.Size = new System.Drawing.Size(50, 21);
            this.cbOk.TabIndex = 5;
            this.cbOk.Text = "OK";
            this.cbOk.UseVisualStyleBackColor = true;
            this.cbOk.CheckedChanged += new System.EventHandler(this.cbOk_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 25);
            this.button5.TabIndex = 14;
            this.button5.Text = "delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(316, 314);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(386, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(193, 314);
            this.dataGridView2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 733);
            this.Controls.Add(this.groupEquation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "System Linear Equation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupEquation.ResumeLayout(false);
            this.groupEquation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInverse;
        private System.Windows.Forms.RadioButton rbGauss;
        private System.Windows.Forms.TextBox tbInputNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupEquation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbOk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

