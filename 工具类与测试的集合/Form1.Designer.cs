namespace 工具类与测试的集合
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.offset_CAAText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.offset_CAA = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btFactory = new System.Windows.Forms.Button();
            this.btXMLSelect = new System.Windows.Forms.Button();
            this.btSingleton = new System.Windows.Forms.Button();
            this.btJson = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTricolor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_推拉力 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 116);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // offset_CAAText
            // 
            this.offset_CAAText.Location = new System.Drawing.Point(235, 126);
            this.offset_CAAText.Name = "offset_CAAText";
            this.offset_CAAText.Size = new System.Drawing.Size(44, 21);
            this.offset_CAAText.TabIndex = 166;
            this.offset_CAAText.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 167;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDoubleClick);
            // 
            // offset_CAA
            // 
            this.offset_CAA.FormattingEnabled = true;
            this.offset_CAA.Items.AddRange(new object[] {
            "offset_CAA1",
            "offset_CAA2",
            "offset_CAA3",
            "offset_CAA4",
            "offset_CAA5",
            "offset_CAA6"});
            this.offset_CAA.Location = new System.Drawing.Point(90, 126);
            this.offset_CAA.Name = "offset_CAA";
            this.offset_CAA.Size = new System.Drawing.Size(96, 20);
            this.offset_CAA.TabIndex = 168;
            this.offset_CAA.Visible = false;
            this.offset_CAA.SelectedIndexChanged += new System.EventHandler(this.offset_CAA_SelectedIndexChanged);
            this.offset_CAA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.offset_CAA_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btFactory
            // 
            this.btFactory.Location = new System.Drawing.Point(391, 1);
            this.btFactory.Name = "btFactory";
            this.btFactory.Size = new System.Drawing.Size(78, 23);
            this.btFactory.TabIndex = 169;
            this.btFactory.Text = "Factory";
            this.btFactory.UseVisualStyleBackColor = true;
            this.btFactory.Click += new System.EventHandler(this.bt_Click);
            // 
            // btXMLSelect
            // 
            this.btXMLSelect.Location = new System.Drawing.Point(0, 123);
            this.btXMLSelect.Name = "btXMLSelect";
            this.btXMLSelect.Size = new System.Drawing.Size(75, 23);
            this.btXMLSelect.TabIndex = 170;
            this.btXMLSelect.Text = "20200516";
            this.btXMLSelect.UseVisualStyleBackColor = true;
            this.btXMLSelect.Click += new System.EventHandler(this.btXMLSelect_Click);
            // 
            // btSingleton
            // 
            this.btSingleton.Location = new System.Drawing.Point(391, 30);
            this.btSingleton.Name = "btSingleton";
            this.btSingleton.Size = new System.Drawing.Size(78, 23);
            this.btSingleton.TabIndex = 171;
            this.btSingleton.Text = "Singleton";
            this.btSingleton.UseVisualStyleBackColor = true;
            this.btSingleton.Click += new System.EventHandler(this.bt_Click);
            // 
            // btJson
            // 
            this.btJson.Location = new System.Drawing.Point(0, 218);
            this.btJson.Name = "btJson";
            this.btJson.Size = new System.Drawing.Size(95, 23);
            this.btJson.TabIndex = 172;
            this.btJson.Text = "Json转换测试";
            this.btJson.UseVisualStyleBackColor = true;
            this.btJson.Click += new System.EventHandler(this.btJson_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(391, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(536, 288);
            this.dataGridView1.TabIndex = 173;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 42;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Number";
            this.Column2.HeaderText = "Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 66;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Category";
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Code";
            this.Column4.HeaderText = "Code";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 54;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Explain";
            this.Column5.HeaderText = "Explain";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 72;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "Plc";
            this.Column6.HeaderText = "Plc";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 48;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Address";
            this.Column7.HeaderText = "Address";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 72;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "Color";
            this.Column8.HeaderText = "Color";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.DataPropertyName = "Remarks";
            this.Column9.HeaderText = "Remarks";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 72;
            // 
            // btTricolor
            // 
            this.btTricolor.Location = new System.Drawing.Point(111, 218);
            this.btTricolor.Name = "btTricolor";
            this.btTricolor.Size = new System.Drawing.Size(75, 23);
            this.btTricolor.TabIndex = 174;
            this.btTricolor.Text = "三色灯";
            this.btTricolor.UseVisualStyleBackColor = true;
            this.btTricolor.Click += new System.EventHandler(this.btTricolor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 175;
            this.button2.Text = "传输From";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_推拉力
            // 
            this.bt_推拉力.Location = new System.Drawing.Point(286, 218);
            this.bt_推拉力.Name = "bt_推拉力";
            this.bt_推拉力.Size = new System.Drawing.Size(75, 23);
            this.bt_推拉力.TabIndex = 176;
            this.bt_推拉力.Text = "推拉力";
            this.bt_推拉力.UseVisualStyleBackColor = true;
            this.bt_推拉力.Click += new System.EventHandler(this.bt_推拉力_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 177;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 178;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 179;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 181;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 183;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(787, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 185;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(848, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 187;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 189;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 191;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 488);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_推拉力);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btTricolor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btJson);
            this.Controls.Add(this.btSingleton);
            this.Controls.Add(this.btXMLSelect);
            this.Controls.Add(this.btFactory);
            this.Controls.Add(this.offset_CAA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.offset_CAAText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox offset_CAAText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox offset_CAA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btFactory;
        private System.Windows.Forms.Button btXMLSelect;
        private System.Windows.Forms.Button btSingleton;
        private System.Windows.Forms.Button btJson;
        private System.Windows.Forms.Button btTricolor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_推拉力;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}