namespace IlCAts_WiForm
{
    partial class TableModelCar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_ModelCar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Craete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 41);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(319, 9);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(166, 22);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "REFRESH";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 337);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label_Name);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Controls.Add(this.textBox_Id);
            this.panel2.Controls.Add(this.label_Id);
            this.panel2.Controls.Add(this.label_ModelCar);
            this.panel2.Location = new System.Drawing.Point(3, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 106);
            this.panel2.TabIndex = 3;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Name.Location = new System.Drawing.Point(9, 40);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(58, 20);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Name:";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(73, 40);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(412, 22);
            this.textBox_Name.TabIndex = 3;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged_1);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(73, 68);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(412, 22);
            this.textBox_Id.TabIndex = 2;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Id.Location = new System.Drawing.Point(40, 70);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(27, 20);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "Id:";
            this.label_Id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ModelCar
            // 
            this.label_ModelCar.AutoSize = true;
            this.label_ModelCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_ModelCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ModelCar.Location = new System.Drawing.Point(10, 11);
            this.label_ModelCar.Name = "label_ModelCar";
            this.label_ModelCar.Size = new System.Drawing.Size(110, 20);
            this.label_ModelCar.TabIndex = 0;
            this.label_ModelCar.Text = "MODEL CAR";
            this.label_ModelCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button_Craete);
            this.panel3.Location = new System.Drawing.Point(3, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 64);
            this.panel3.TabIndex = 4;
            // 
            // button_Craete
            // 
            this.button_Craete.Location = new System.Drawing.Point(109, 13);
            this.button_Craete.Name = "button_Craete";
            this.button_Craete.Size = new System.Drawing.Size(247, 39);
            this.button_Craete.TabIndex = 0;
            this.button_Craete.Text = "CREATE NEW MODEL CAR";
            this.button_Craete.UseVisualStyleBackColor = true;
            this.button_Craete.Click += new System.EventHandler(this.button_Craete_Click);
            // 
            // TableModelCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "TableModelCar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Craete;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_ModelCar;
    }
}

