namespace ApartmanOtomasyonu
{
    partial class Operations
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Incomes = new System.Windows.Forms.TabPage();
            this.dgv_Incomes = new System.Windows.Forms.DataGridView();
            this.gb_InsertDues = new System.Windows.Forms.GroupBox();
            this.nud_IncomesAmount = new System.Windows.Forms.NumericUpDown();
            this.nud_Room = new System.Windows.Forms.NumericUpDown();
            this.btn_IncomesAdd = new System.Windows.Forms.Button();
            this.dt_IncomesDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_Expenses = new System.Windows.Forms.TabPage();
            this.dgv_Expenses = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ExpensesAdd = new System.Windows.Forms.Button();
            this.dt_ExpensesDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_ExpensesAmount = new System.Windows.Forms.NumericUpDown();
            this.rbtn_Electricity = new System.Windows.Forms.RadioButton();
            this.rbtn_Water = new System.Windows.Forms.RadioButton();
            this.rbtn_Elevator = new System.Windows.Forms.RadioButton();
            this.rbtn_Cleaning = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tp_Incomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Incomes)).BeginInit();
            this.gb_InsertDues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_IncomesAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Room)).BeginInit();
            this.tp_Expenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expenses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ExpensesAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Incomes);
            this.tabControl1.Controls.Add(this.tp_Expenses);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 412);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Operations_Load);
            // 
            // tp_Incomes
            // 
            this.tp_Incomes.Controls.Add(this.dgv_Incomes);
            this.tp_Incomes.Controls.Add(this.gb_InsertDues);
            this.tp_Incomes.Location = new System.Drawing.Point(4, 22);
            this.tp_Incomes.Name = "tp_Incomes";
            this.tp_Incomes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Incomes.Size = new System.Drawing.Size(494, 386);
            this.tp_Incomes.TabIndex = 0;
            this.tp_Incomes.Text = "Gelirler";
            this.tp_Incomes.UseVisualStyleBackColor = true;
            // 
            // dgv_Incomes
            // 
            this.dgv_Incomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Incomes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Incomes.Location = new System.Drawing.Point(3, 155);
            this.dgv_Incomes.Name = "dgv_Incomes";
            this.dgv_Incomes.Size = new System.Drawing.Size(488, 228);
            this.dgv_Incomes.TabIndex = 3;
            // 
            // gb_InsertDues
            // 
            this.gb_InsertDues.Controls.Add(this.nud_IncomesAmount);
            this.gb_InsertDues.Controls.Add(this.nud_Room);
            this.gb_InsertDues.Controls.Add(this.btn_IncomesAdd);
            this.gb_InsertDues.Controls.Add(this.dt_IncomesDate);
            this.gb_InsertDues.Controls.Add(this.label3);
            this.gb_InsertDues.Controls.Add(this.label2);
            this.gb_InsertDues.Controls.Add(this.label1);
            this.gb_InsertDues.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_InsertDues.Location = new System.Drawing.Point(2, 5);
            this.gb_InsertDues.Margin = new System.Windows.Forms.Padding(2);
            this.gb_InsertDues.Name = "gb_InsertDues";
            this.gb_InsertDues.Padding = new System.Windows.Forms.Padding(2);
            this.gb_InsertDues.Size = new System.Drawing.Size(484, 145);
            this.gb_InsertDues.TabIndex = 2;
            this.gb_InsertDues.TabStop = false;
            this.gb_InsertDues.Text = "Yeni Aidat Ekle";
            // 
            // nud_IncomesAmount
            // 
            this.nud_IncomesAmount.Location = new System.Drawing.Point(100, 84);
            this.nud_IncomesAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nud_IncomesAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_IncomesAmount.Name = "nud_IncomesAmount";
            this.nud_IncomesAmount.Size = new System.Drawing.Size(90, 30);
            this.nud_IncomesAmount.TabIndex = 4;
            // 
            // nud_Room
            // 
            this.nud_Room.Location = new System.Drawing.Point(100, 36);
            this.nud_Room.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Room.Name = "nud_Room";
            this.nud_Room.Size = new System.Drawing.Size(90, 30);
            this.nud_Room.TabIndex = 0;
            // 
            // btn_IncomesAdd
            // 
            this.btn_IncomesAdd.Location = new System.Drawing.Point(295, 91);
            this.btn_IncomesAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_IncomesAdd.Name = "btn_IncomesAdd";
            this.btn_IncomesAdd.Size = new System.Drawing.Size(134, 41);
            this.btn_IncomesAdd.TabIndex = 3;
            this.btn_IncomesAdd.Text = "Ekle";
            this.btn_IncomesAdd.UseVisualStyleBackColor = true;
            this.btn_IncomesAdd.Click += new System.EventHandler(this.btn_IncomesAdd_Click);
            // 
            // dt_IncomesDate
            // 
            this.dt_IncomesDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_IncomesDate.Location = new System.Drawing.Point(295, 33);
            this.dt_IncomesDate.Margin = new System.Windows.Forms.Padding(2);
            this.dt_IncomesDate.Name = "dt_IncomesDate";
            this.dt_IncomesDate.Size = new System.Drawing.Size(151, 30);
            this.dt_IncomesDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tutar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daire no:";
            // 
            // tp_Expenses
            // 
            this.tp_Expenses.Controls.Add(this.dgv_Expenses);
            this.tp_Expenses.Controls.Add(this.groupBox1);
            this.tp_Expenses.Location = new System.Drawing.Point(4, 22);
            this.tp_Expenses.Name = "tp_Expenses";
            this.tp_Expenses.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Expenses.Size = new System.Drawing.Size(494, 386);
            this.tp_Expenses.TabIndex = 1;
            this.tp_Expenses.Text = "Giderler";
            this.tp_Expenses.UseVisualStyleBackColor = true;
            // 
            // dgv_Expenses
            // 
            this.dgv_Expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Expenses.Location = new System.Drawing.Point(3, 164);
            this.dgv_Expenses.Name = "dgv_Expenses";
            this.dgv_Expenses.Size = new System.Drawing.Size(488, 219);
            this.dgv_Expenses.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Cleaning);
            this.groupBox1.Controls.Add(this.rbtn_Elevator);
            this.groupBox1.Controls.Add(this.rbtn_Water);
            this.groupBox1.Controls.Add(this.rbtn_Electricity);
            this.groupBox1.Controls.Add(this.nud_ExpensesAmount);
            this.groupBox1.Controls.Add(this.btn_ExpensesAdd);
            this.groupBox1.Controls.Add(this.dt_ExpensesDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Gider Ekle";
            // 
            // btn_ExpensesAdd
            // 
            this.btn_ExpensesAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExpensesAdd.Location = new System.Drawing.Point(285, 97);
            this.btn_ExpensesAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ExpensesAdd.Name = "btn_ExpensesAdd";
            this.btn_ExpensesAdd.Size = new System.Drawing.Size(134, 41);
            this.btn_ExpensesAdd.TabIndex = 8;
            this.btn_ExpensesAdd.Text = "Ekle";
            this.btn_ExpensesAdd.UseVisualStyleBackColor = true;
            this.btn_ExpensesAdd.Click += new System.EventHandler(this.btn_ExpensesAdd_Click);
            // 
            // dt_ExpensesDate
            // 
            this.dt_ExpensesDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_ExpensesDate.Location = new System.Drawing.Point(278, 63);
            this.dt_ExpensesDate.Margin = new System.Windows.Forms.Padding(2);
            this.dt_ExpensesDate.Name = "dt_ExpensesDate";
            this.dt_ExpensesDate.Size = new System.Drawing.Size(151, 30);
            this.dt_ExpensesDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(214, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(209, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tutar:";
            // 
            // nud_ExpensesAmount
            // 
            this.nud_ExpensesAmount.Location = new System.Drawing.Point(278, 27);
            this.nud_ExpensesAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nud_ExpensesAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_ExpensesAmount.Name = "nud_ExpensesAmount";
            this.nud_ExpensesAmount.Size = new System.Drawing.Size(151, 30);
            this.nud_ExpensesAmount.TabIndex = 9;
            // 
            // rbtn_Electricity
            // 
            this.rbtn_Electricity.AutoSize = true;
            this.rbtn_Electricity.Location = new System.Drawing.Point(6, 35);
            this.rbtn_Electricity.Name = "rbtn_Electricity";
            this.rbtn_Electricity.Size = new System.Drawing.Size(89, 27);
            this.rbtn_Electricity.TabIndex = 10;
            this.rbtn_Electricity.TabStop = true;
            this.rbtn_Electricity.Text = "Elektrik";
            this.rbtn_Electricity.UseVisualStyleBackColor = true;
            // 
            // rbtn_Water
            // 
            this.rbtn_Water.AutoSize = true;
            this.rbtn_Water.Location = new System.Drawing.Point(6, 63);
            this.rbtn_Water.Name = "rbtn_Water";
            this.rbtn_Water.Size = new System.Drawing.Size(47, 27);
            this.rbtn_Water.TabIndex = 11;
            this.rbtn_Water.TabStop = true;
            this.rbtn_Water.Text = "Su";
            this.rbtn_Water.UseVisualStyleBackColor = true;
            // 
            // rbtn_Elevator
            // 
            this.rbtn_Elevator.AutoSize = true;
            this.rbtn_Elevator.Location = new System.Drawing.Point(6, 88);
            this.rbtn_Elevator.Name = "rbtn_Elevator";
            this.rbtn_Elevator.Size = new System.Drawing.Size(89, 27);
            this.rbtn_Elevator.TabIndex = 12;
            this.rbtn_Elevator.TabStop = true;
            this.rbtn_Elevator.Text = "Asansör";
            this.rbtn_Elevator.UseVisualStyleBackColor = true;
            // 
            // rbtn_Cleaning
            // 
            this.rbtn_Cleaning.AutoSize = true;
            this.rbtn_Cleaning.Location = new System.Drawing.Point(5, 113);
            this.rbtn_Cleaning.Name = "rbtn_Cleaning";
            this.rbtn_Cleaning.Size = new System.Drawing.Size(90, 27);
            this.rbtn_Cleaning.TabIndex = 13;
            this.rbtn_Cleaning.TabStop = true;
            this.rbtn_Cleaning.Text = "Temizlik";
            this.rbtn_Cleaning.UseVisualStyleBackColor = true;
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 415);
            this.Controls.Add(this.tabControl1);
            this.Name = "Operations";
            this.Text = "İşlemler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Operations_FormClosed);
            this.Load += new System.EventHandler(this.Operations_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_Incomes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Incomes)).EndInit();
            this.gb_InsertDues.ResumeLayout(false);
            this.gb_InsertDues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_IncomesAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Room)).EndInit();
            this.tp_Expenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expenses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ExpensesAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Incomes;
        private System.Windows.Forms.DataGridView dgv_Incomes;
        private System.Windows.Forms.GroupBox gb_InsertDues;
        private System.Windows.Forms.NumericUpDown nud_Room;
        private System.Windows.Forms.Button btn_IncomesAdd;
        private System.Windows.Forms.DateTimePicker dt_IncomesDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_Expenses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ExpensesAdd;
        private System.Windows.Forms.DateTimePicker dt_ExpensesDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Expenses;
        private System.Windows.Forms.NumericUpDown nud_IncomesAmount;
        private System.Windows.Forms.NumericUpDown nud_ExpensesAmount;
        private System.Windows.Forms.RadioButton rbtn_Cleaning;
        private System.Windows.Forms.RadioButton rbtn_Elevator;
        private System.Windows.Forms.RadioButton rbtn_Water;
        private System.Windows.Forms.RadioButton rbtn_Electricity;
    }
}