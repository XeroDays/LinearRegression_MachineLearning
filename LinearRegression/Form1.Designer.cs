
namespace LinearRegression
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
            this.txtTrainingSet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtxx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtTestingSet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTrainingSet
            // 
            this.txtTrainingSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainingSet.Location = new System.Drawing.Point(12, 23);
            this.txtTrainingSet.Multiline = true;
            this.txtTrainingSet.Name = "txtTrainingSet";
            this.txtTrainingSet.Size = new System.Drawing.Size(135, 458);
            this.txtTrainingSet.TabIndex = 0;
            this.txtTrainingSet.Text = resources.GetString("txtTrainingSet.Text");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(296, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Precision Algorithm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(684, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Override Values";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtxx
            // 
            this.txtxx.Location = new System.Drawing.Point(724, 50);
            this.txtxx.Name = "txtxx";
            this.txtxx.Size = new System.Drawing.Size(48, 20);
            this.txtxx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Σ( x ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Σ( x² ) :";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(724, 76);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(48, 20);
            this.txtx2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Σ( xy ) :";
            // 
            // txtxy
            // 
            this.txtxy.Location = new System.Drawing.Point(724, 129);
            this.txtxy.Name = "txtxy";
            this.txtxy.Size = new System.Drawing.Size(48, 20);
            this.txtxy.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Σ( y ) :";
            // 
            // txtyy
            // 
            this.txtyy.Location = new System.Drawing.Point(724, 103);
            this.txtyy.Name = "txtyy";
            this.txtyy.Size = new System.Drawing.Size(48, 20);
            this.txtyy.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "n : ";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(724, 155);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(48, 20);
            this.txtn.TabIndex = 12;
            // 
            // txtTestingSet
            // 
            this.txtTestingSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestingSet.Location = new System.Drawing.Point(153, 23);
            this.txtTestingSet.Multiline = true;
            this.txtTestingSet.Name = "txtTestingSet";
            this.txtTestingSet.Size = new System.Drawing.Size(132, 458);
            this.txtTestingSet.TabIndex = 14;
            this.txtTestingSet.Text = resources.GetString("txtTestingSet.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(12, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "       Traning Data                   Testing Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 493);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTestingSet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtxy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtyy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtxx);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTrainingSet);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrainingSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtxx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtxy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtyy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtTestingSet;
        private System.Windows.Forms.Label label7;
    }
}

