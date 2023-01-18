namespace VectorsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.vectorAddX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.vectorAddY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.vectorDelById = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vectorUpdateById = new System.Windows.Forms.TextBox();
            this.vectorUpdateX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.triangleUpdateY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.triangleDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.triangleUpdateById = new System.Windows.Forms.TextBox();
            this.triangleUpdateX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.triangleAddY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.triangleAddX = new System.Windows.Forms.TextBox();
            this.triangleDelById = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.vectorUpdateY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vectorAddX
            // 
            this.vectorAddX.Location = new System.Drawing.Point(67, 181);
            this.vectorAddX.Name = "vectorAddX";
            this.vectorAddX.Size = new System.Drawing.Size(150, 31);
            this.vectorAddX.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(15, 181);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 25);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(15, 235);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(22, 25);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y";
            // 
            // vectorAddY
            // 
            this.vectorAddY.Location = new System.Drawing.Point(67, 235);
            this.vectorAddY.Name = "vectorAddY";
            this.vectorAddY.Size = new System.Drawing.Size(150, 31);
            this.vectorAddY.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(983, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "VectorBase";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(744, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(565, 382);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 84);
            this.button2.TabIndex = 25;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // vectorDelById
            // 
            this.vectorDelById.Location = new System.Drawing.Point(418, 181);
            this.vectorDelById.Name = "vectorDelById";
            this.vectorDelById.Size = new System.Drawing.Size(150, 31);
            this.vectorDelById.TabIndex = 26;
            this.vectorDelById.TextChanged += new System.EventHandler(this.textDelById_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 81);
            this.button3.TabIndex = 28;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "id";
            // 
            // vectorUpdateById
            // 
            this.vectorUpdateById.Location = new System.Drawing.Point(67, 408);
            this.vectorUpdateById.Name = "vectorUpdateById";
            this.vectorUpdateById.Size = new System.Drawing.Size(150, 31);
            this.vectorUpdateById.TabIndex = 30;
            // 
            // vectorUpdateX
            // 
            this.vectorUpdateX.Location = new System.Drawing.Point(67, 471);
            this.vectorUpdateX.Name = "vectorUpdateX";
            this.vectorUpdateX.Size = new System.Drawing.Size(150, 31);
            this.vectorUpdateX.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.panel1.Controls.Add(this.triangleUpdateY);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.triangleDataGridView);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.triangleUpdateById);
            this.panel1.Controls.Add(this.triangleUpdateX);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.triangleAddY);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.triangleAddX);
            this.panel1.Controls.Add(this.triangleDelById);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.vectorUpdateY);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.vectorUpdateById);
            this.panel1.Controls.Add(this.vectorUpdateX);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.vectorAddY);
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vectorAddX);
            this.panel1.Controls.Add(this.vectorDelById);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 506);
            this.panel1.TabIndex = 32;
            // 
            // triangleUpdateY
            // 
            this.triangleUpdateY.Location = new System.Drawing.Point(97, 1140);
            this.triangleUpdateY.Name = "triangleUpdateY";
            this.triangleUpdateY.Size = new System.Drawing.Size(150, 31);
            this.triangleUpdateY.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 1146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 25);
            this.label12.TabIndex = 50;
            this.label12.Text = "V2 id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 1094);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "V1 id";
            // 
            // triangleDataGridView
            // 
            this.triangleDataGridView.AllowUserToAddRows = false;
            this.triangleDataGridView.AllowUserToDeleteRows = false;
            this.triangleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triangleDataGridView.Location = new System.Drawing.Point(754, 807);
            this.triangleDataGridView.Name = "triangleDataGridView";
            this.triangleDataGridView.ReadOnly = true;
            this.triangleDataGridView.RowHeadersWidth = 62;
            this.triangleDataGridView.RowTemplate.Height = 33;
            this.triangleDataGridView.Size = new System.Drawing.Size(565, 382);
            this.triangleDataGridView.TabIndex = 41;
            this.triangleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.triangleDataGridView_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 1025);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "id";
            // 
            // triangleUpdateById
            // 
            this.triangleUpdateById.Location = new System.Drawing.Point(77, 1025);
            this.triangleUpdateById.Name = "triangleUpdateById";
            this.triangleUpdateById.Size = new System.Drawing.Size(150, 31);
            this.triangleUpdateById.TabIndex = 47;
            // 
            // triangleUpdateX
            // 
            this.triangleUpdateX.Location = new System.Drawing.Point(97, 1091);
            this.triangleUpdateX.Name = "triangleUpdateX";
            this.triangleUpdateX.Size = new System.Drawing.Size(150, 31);
            this.triangleUpdateX.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(993, 764);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "TriangleBase";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 852);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "V2 id";
            // 
            // triangleAddY
            // 
            this.triangleAddY.Location = new System.Drawing.Point(87, 852);
            this.triangleAddY.Name = "triangleAddY";
            this.triangleAddY.Size = new System.Drawing.Size(150, 31);
            this.triangleAddY.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 798);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "V1 id";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 915);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 81);
            this.button4.TabIndex = 45;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(391, 657);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 84);
            this.button5.TabIndex = 42;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 798);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "id";
            // 
            // triangleAddX
            // 
            this.triangleAddX.Location = new System.Drawing.Point(87, 798);
            this.triangleAddX.Name = "triangleAddX";
            this.triangleAddX.Size = new System.Drawing.Size(150, 31);
            this.triangleAddX.TabIndex = 36;
            this.triangleAddX.TextChanged += new System.EventHandler(this.triangleAddX_TextChanged);
            // 
            // triangleDelById
            // 
            this.triangleDelById.Location = new System.Drawing.Point(428, 798);
            this.triangleDelById.Name = "triangleDelById";
            this.triangleDelById.Size = new System.Drawing.Size(150, 31);
            this.triangleDelById.TabIndex = 43;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 655);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 86);
            this.button6.TabIndex = 35;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // vectorUpdateY
            // 
            this.vectorUpdateY.Location = new System.Drawing.Point(67, 541);
            this.vectorUpdateY.Name = "vectorUpdateY";
            this.vectorUpdateY.Size = new System.Drawing.Size(150, 31);
            this.vectorUpdateY.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 552);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private TextBox vectorAddX;
        private Label labelX;
        private Label labelY;
        private TextBox vectorAddY;
        private Label label9;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox vectorDelById;
        private Label label1;
        private Button button3;
        private Label label2;
        private TextBox vectorUpdateById;
        private TextBox vectorUpdateX;
        private Panel panel1;
        private Label label3;
        private TextBox vectorUpdateY;
        private Label label4;
        private TextBox triangleUpdateY;
        private Label label12;
        private Label label5;
        private DataGridView triangleDataGridView;
        private Label label6;
        private TextBox triangleUpdateById;
        private TextBox triangleUpdateX;
        private Label label7;
        private Label label8;
        private TextBox triangleAddY;
        private Label label10;
        private Button button4;
        private Button button5;
        private Label label11;
        private TextBox triangleAddX;
        private TextBox triangleDelById;
        private Button button6;
    }
}