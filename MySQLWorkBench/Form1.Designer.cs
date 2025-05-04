namespace MySQLWorkBench
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Datatext = new System.Windows.Forms.TextBox();
            this.TableText = new System.Windows.Forms.TextBox();
            this.ColumnText = new System.Windows.Forms.TextBox();
            this.updateText = new System.Windows.Forms.TextBox();
            this.crtData = new System.Windows.Forms.Button();
            this.CrtTable = new System.Windows.Forms.Button();
            this.addClmn = new System.Windows.Forms.Button();
            this.Updatecll = new System.Windows.Forms.Button();
            this.db_Lbox = new System.Windows.Forms.ListBox();
            this.tb_Lbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dltData = new System.Windows.Forms.Button();
            this.dltTable = new System.Windows.Forms.Button();
            this.clrTable = new System.Windows.Forms.Button();
            this.clrCell = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MySQL Workbench Kerem Cepni 230211019";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Database : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create Table : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add Coluımn : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Update Cell : ";
            // 
            // Datatext
            // 
            this.Datatext.Location = new System.Drawing.Point(236, 131);
            this.Datatext.Name = "Datatext";
            this.Datatext.Size = new System.Drawing.Size(217, 34);
            this.Datatext.TabIndex = 5;
            // 
            // TableText
            // 
            this.TableText.Location = new System.Drawing.Point(236, 187);
            this.TableText.Name = "TableText";
            this.TableText.Size = new System.Drawing.Size(217, 34);
            this.TableText.TabIndex = 6;
            // 
            // ColumnText
            // 
            this.ColumnText.Location = new System.Drawing.Point(236, 246);
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.Size = new System.Drawing.Size(217, 34);
            this.ColumnText.TabIndex = 7;
            // 
            // updateText
            // 
            this.updateText.Location = new System.Drawing.Point(236, 307);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(217, 34);
            this.updateText.TabIndex = 8;
            // 
            // crtData
            // 
            this.crtData.Location = new System.Drawing.Point(479, 131);
            this.crtData.Name = "crtData";
            this.crtData.Size = new System.Drawing.Size(126, 34);
            this.crtData.TabIndex = 9;
            this.crtData.Text = "Create";
            this.crtData.UseVisualStyleBackColor = true;
            this.crtData.Click += new System.EventHandler(this.crtData_Click);
            // 
            // CrtTable
            // 
            this.CrtTable.Location = new System.Drawing.Point(479, 186);
            this.CrtTable.Name = "CrtTable";
            this.CrtTable.Size = new System.Drawing.Size(126, 34);
            this.CrtTable.TabIndex = 10;
            this.CrtTable.Text = "Create";
            this.CrtTable.UseVisualStyleBackColor = true;
            this.CrtTable.Click += new System.EventHandler(this.CrtTable_Click);
            // 
            // addClmn
            // 
            this.addClmn.Location = new System.Drawing.Point(479, 246);
            this.addClmn.Name = "addClmn";
            this.addClmn.Size = new System.Drawing.Size(126, 34);
            this.addClmn.TabIndex = 11;
            this.addClmn.Text = "Add";
            this.addClmn.UseVisualStyleBackColor = true;
            // 
            // Updatecll
            // 
            this.Updatecll.Location = new System.Drawing.Point(479, 306);
            this.Updatecll.Name = "Updatecll";
            this.Updatecll.Size = new System.Drawing.Size(126, 34);
            this.Updatecll.TabIndex = 12;
            this.Updatecll.Text = "Update";
            this.Updatecll.UseVisualStyleBackColor = true;
            // 
            // db_Lbox
            // 
            this.db_Lbox.FormattingEnabled = true;
            this.db_Lbox.ItemHeight = 26;
            this.db_Lbox.Location = new System.Drawing.Point(757, 155);
            this.db_Lbox.Name = "db_Lbox";
            this.db_Lbox.Size = new System.Drawing.Size(220, 290);
            this.db_Lbox.TabIndex = 13;
            this.db_Lbox.SelectedIndexChanged += new System.EventHandler(this.db_Lbox_SelectedIndexChanged);
            // 
            // tb_Lbox
            // 
            this.tb_Lbox.FormattingEnabled = true;
            this.tb_Lbox.ItemHeight = 26;
            this.tb_Lbox.Location = new System.Drawing.Point(1010, 155);
            this.tb_Lbox.Name = "tb_Lbox";
            this.tb_Lbox.Size = new System.Drawing.Size(220, 290);
            this.tb_Lbox.TabIndex = 14;
            this.tb_Lbox.SelectedIndexChanged += new System.EventHandler(this.tb_Lbox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "List of Databases : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1005, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "List of Tables : ";
            // 
            // dltData
            // 
            this.dltData.Location = new System.Drawing.Point(795, 476);
            this.dltData.Name = "dltData";
            this.dltData.Size = new System.Drawing.Size(126, 34);
            this.dltData.TabIndex = 17;
            this.dltData.Text = "Delete";
            this.dltData.UseVisualStyleBackColor = true;
            this.dltData.Click += new System.EventHandler(this.dltData_Click);
            // 
            // dltTable
            // 
            this.dltTable.Location = new System.Drawing.Point(1069, 476);
            this.dltTable.Name = "dltTable";
            this.dltTable.Size = new System.Drawing.Size(126, 34);
            this.dltTable.TabIndex = 18;
            this.dltTable.Text = "Delete";
            this.dltTable.UseVisualStyleBackColor = true;
            this.dltTable.Click += new System.EventHandler(this.dltTable_Click);
            // 
            // clrTable
            // 
            this.clrTable.Location = new System.Drawing.Point(41, 402);
            this.clrTable.Name = "clrTable";
            this.clrTable.Size = new System.Drawing.Size(206, 43);
            this.clrTable.TabIndex = 19;
            this.clrTable.Text = "Clear Table";
            this.clrTable.UseVisualStyleBackColor = true;
            this.clrTable.Click += new System.EventHandler(this.clrTable_Click);
            // 
            // clrCell
            // 
            this.clrCell.Location = new System.Drawing.Point(281, 402);
            this.clrCell.Name = "clrCell";
            this.clrCell.Size = new System.Drawing.Size(200, 43);
            this.clrCell.TabIndex = 20;
            this.clrCell.Text = "Clear Cell";
            this.clrCell.UseVisualStyleBackColor = true;
            this.clrCell.Click += new System.EventHandler(this.clrCell_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add New Row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 43);
            this.button2.TabIndex = 22;
            this.button2.Text = "Delete Current Row";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 43);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete Current Column \r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 626);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 247);
            this.dataGridView1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1242, 885);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clrCell);
            this.Controls.Add(this.clrTable);
            this.Controls.Add(this.dltTable);
            this.Controls.Add(this.dltData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Lbox);
            this.Controls.Add(this.db_Lbox);
            this.Controls.Add(this.Updatecll);
            this.Controls.Add(this.addClmn);
            this.Controls.Add(this.CrtTable);
            this.Controls.Add(this.crtData);
            this.Controls.Add(this.updateText);
            this.Controls.Add(this.ColumnText);
            this.Controls.Add(this.TableText);
            this.Controls.Add(this.Datatext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Datatext;
        private System.Windows.Forms.TextBox TableText;
        private System.Windows.Forms.TextBox ColumnText;
        private System.Windows.Forms.TextBox updateText;
        private System.Windows.Forms.Button crtData;
        private System.Windows.Forms.Button CrtTable;
        private System.Windows.Forms.Button addClmn;
        private System.Windows.Forms.Button Updatecll;
        private System.Windows.Forms.ListBox db_Lbox;
        private System.Windows.Forms.ListBox tb_Lbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button dltData;
        private System.Windows.Forms.Button dltTable;
        private System.Windows.Forms.Button clrTable;
        private System.Windows.Forms.Button clrCell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

