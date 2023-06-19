namespace zd3_v7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addCableButton = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfWiresTextBox = new System.Windows.Forms.TextBox();
            this.diameterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeCableButton = new System.Windows.Forms.Button();
            this.cablesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.currentStrengthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pCheckBox = new System.Windows.Forms.CheckBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cablesDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCableButton
            // 
            this.addCableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCableButton.Location = new System.Drawing.Point(24, 201);
            this.addCableButton.Name = "addCableButton";
            this.addCableButton.Size = new System.Drawing.Size(159, 41);
            this.addCableButton.TabIndex = 2;
            this.addCableButton.Text = "Добавить кабель";
            this.addCableButton.UseVisualStyleBackColor = true;
            this.addCableButton.Click += new System.EventHandler(this.addCable_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTextBox.Location = new System.Drawing.Point(139, 25);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(159, 26);
            this.typeTextBox.TabIndex = 3;
            // 
            // numberOfWiresTextBox
            // 
            this.numberOfWiresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfWiresTextBox.Location = new System.Drawing.Point(139, 57);
            this.numberOfWiresTextBox.Name = "numberOfWiresTextBox";
            this.numberOfWiresTextBox.Size = new System.Drawing.Size(159, 26);
            this.numberOfWiresTextBox.TabIndex = 4;
            // 
            // diameterTextBox
            // 
            this.diameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diameterTextBox.Location = new System.Drawing.Point(139, 89);
            this.diameterTextBox.Name = "diameterTextBox";
            this.diameterTextBox.Size = new System.Drawing.Size(159, 26);
            this.diameterTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Кол-во жил:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Диаметр:";
            // 
            // removeCableButton
            // 
            this.removeCableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeCableButton.Location = new System.Drawing.Point(203, 201);
            this.removeCableButton.Name = "removeCableButton";
            this.removeCableButton.Size = new System.Drawing.Size(159, 41);
            this.removeCableButton.TabIndex = 12;
            this.removeCableButton.Text = "Удалить кабель";
            this.removeCableButton.UseVisualStyleBackColor = true;
            this.removeCableButton.Click += new System.EventHandler(this.removeCableButton_Click);
            // 
            // cablesDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cablesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cablesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cablesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cablesDataGridView.Location = new System.Drawing.Point(3, 248);
            this.cablesDataGridView.Name = "cablesDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cablesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cablesDataGridView.Size = new System.Drawing.Size(750, 173);
            this.cablesDataGridView.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 450);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.currentStrengthTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lengthTextBox);
            this.tabPage1.Controls.Add(this.exitButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pCheckBox);
            this.tabPage1.Controls.Add(this.colorTextBox);
            this.tabPage1.Controls.Add(this.typeTextBox);
            this.tabPage1.Controls.Add(this.cablesDataGridView);
            this.tabPage1.Controls.Add(this.addCableButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.diameterTextBox);
            this.tabPage1.Controls.Add(this.removeCableButton);
            this.tabPage1.Controls.Add(this.numberOfWiresTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кабель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(304, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Мощность тока:";
            // 
            // currentStrengthTextBox
            // 
            this.currentStrengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStrengthTextBox.Location = new System.Drawing.Point(441, 54);
            this.currentStrengthTextBox.Name = "currentStrengthTextBox";
            this.currentStrengthTextBox.Size = new System.Drawing.Size(159, 26);
            this.currentStrengthTextBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(373, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Длина:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthTextBox.Location = new System.Drawing.Point(441, 19);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(159, 26);
            this.lengthTextBox.TabIndex = 25;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(589, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 41);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Цвет оплётки:";
            // 
            // pCheckBox
            // 
            this.pCheckBox.AutoSize = true;
            this.pCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pCheckBox.Location = new System.Drawing.Point(139, 121);
            this.pCheckBox.Name = "pCheckBox";
            this.pCheckBox.Size = new System.Drawing.Size(162, 24);
            this.pCheckBox.TabIndex = 21;
            this.pCheckBox.Text = "Наличие оплётки";
            this.pCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorTextBox.Location = new System.Drawing.Point(139, 151);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(159, 26);
            this.colorTextBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Кабель";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cablesDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentStrengthTextBox;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.CheckBox pCheckBox;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.DataGridView cablesDataGridView;

        private System.Windows.Forms.Button removeCableButton;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox diameterTextBox;

        private System.Windows.Forms.TextBox numberOfWiresTextBox;

        private System.Windows.Forms.TextBox typeTextBox;

        private System.Windows.Forms.Button addCableButton;

        #endregion
    }
}