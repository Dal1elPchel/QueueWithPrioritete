namespace QueueWithPrioritete
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CreateQueueBtn = new System.Windows.Forms.Button();
            this.ClearQueueBtn = new System.Windows.Forms.Button();
            this.GetLargestBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.ChangePrioriteteBtn = new System.Windows.Forms.Button();
            this.NewElemDropDown = new System.Windows.Forms.NumericUpDown();
            this.PrioriteteFromDropDown = new System.Windows.Forms.NumericUpDown();
            this.PrioriteteToDropDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ArrayDataGridView = new System.Windows.Forms.DataGridView();
            this.HeapDataGridView = new System.Windows.Forms.DataGridView();
            this.ChooseResultdataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewElemDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioriteteFromDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioriteteToDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeapDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseResultdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrioriteteToDropDown);
            this.panel1.Controls.Add(this.PrioriteteFromDropDown);
            this.panel1.Controls.Add(this.NewElemDropDown);
            this.panel1.Controls.Add(this.ChangePrioriteteBtn);
            this.panel1.Controls.Add(this.NewBtn);
            this.panel1.Controls.Add(this.GetLargestBtn);
            this.panel1.Controls.Add(this.ClearQueueBtn);
            this.panel1.Controls.Add(this.CreateQueueBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 121);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.HeapDataGridView);
            this.panel2.Controls.Add(this.ArrayDataGridView);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 339);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ExitBtn);
            this.panel3.Controls.Add(this.ChooseResultdataGridView);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1110, 152);
            this.panel3.TabIndex = 1;
            // 
            // CreateQueueBtn
            // 
            this.CreateQueueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateQueueBtn.Location = new System.Drawing.Point(10, 5);
            this.CreateQueueBtn.Name = "CreateQueueBtn";
            this.CreateQueueBtn.Size = new System.Drawing.Size(230, 38);
            this.CreateQueueBtn.TabIndex = 0;
            this.CreateQueueBtn.Text = "Создать очередь";
            this.CreateQueueBtn.UseVisualStyleBackColor = true;
            this.CreateQueueBtn.Click += new System.EventHandler(this.CreateQueueBtn_Click);
            // 
            // ClearQueueBtn
            // 
            this.ClearQueueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearQueueBtn.Location = new System.Drawing.Point(445, 5);
            this.ClearQueueBtn.Name = "ClearQueueBtn";
            this.ClearQueueBtn.Size = new System.Drawing.Size(230, 38);
            this.ClearQueueBtn.TabIndex = 1;
            this.ClearQueueBtn.Text = "Очистить очередь";
            this.ClearQueueBtn.UseVisualStyleBackColor = true;
            this.ClearQueueBtn.Click += new System.EventHandler(this.ClearQueueBtn_Click);
            // 
            // GetLargestBtn
            // 
            this.GetLargestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetLargestBtn.Location = new System.Drawing.Point(832, 12);
            this.GetLargestBtn.Name = "GetLargestBtn";
            this.GetLargestBtn.Size = new System.Drawing.Size(230, 38);
            this.GetLargestBtn.TabIndex = 2;
            this.GetLargestBtn.Text = "Извлечь наибольший";
            this.GetLargestBtn.UseVisualStyleBackColor = true;
            this.GetLargestBtn.Click += new System.EventHandler(this.GetLargestBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewBtn.Location = new System.Drawing.Point(157, 68);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(230, 38);
            this.NewBtn.TabIndex = 3;
            this.NewBtn.Text = "Вставить новый";
            this.NewBtn.UseVisualStyleBackColor = true;
            // 
            // ChangePrioriteteBtn
            // 
            this.ChangePrioriteteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePrioriteteBtn.Location = new System.Drawing.Point(602, 66);
            this.ChangePrioriteteBtn.Name = "ChangePrioriteteBtn";
            this.ChangePrioriteteBtn.Size = new System.Drawing.Size(230, 38);
            this.ChangePrioriteteBtn.TabIndex = 4;
            this.ChangePrioriteteBtn.Text = "Изменить приоритет";
            this.ChangePrioriteteBtn.UseVisualStyleBackColor = true;
            // 
            // NewElemDropDown
            // 
            this.NewElemDropDown.Location = new System.Drawing.Point(445, 79);
            this.NewElemDropDown.Name = "NewElemDropDown";
            this.NewElemDropDown.Size = new System.Drawing.Size(50, 22);
            this.NewElemDropDown.TabIndex = 5;
            // 
            // PrioriteteFromDropDown
            // 
            this.PrioriteteFromDropDown.Location = new System.Drawing.Point(883, 74);
            this.PrioriteteFromDropDown.Name = "PrioriteteFromDropDown";
            this.PrioriteteFromDropDown.Size = new System.Drawing.Size(50, 22);
            this.PrioriteteFromDropDown.TabIndex = 6;
            // 
            // PrioriteteToDropDown
            // 
            this.PrioriteteToDropDown.Location = new System.Drawing.Point(985, 74);
            this.PrioriteteToDropDown.Name = "PrioriteteToDropDown";
            this.PrioriteteToDropDown.Size = new System.Drawing.Size(50, 22);
            this.PrioriteteToDropDown.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(854, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(946, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "На";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(370, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Представление в виде массива";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(370, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Представление в виде дерева";
            // 
            // ArrayDataGridView
            // 
            this.ArrayDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ArrayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayDataGridView.Location = new System.Drawing.Point(-1, 23);
            this.ArrayDataGridView.Name = "ArrayDataGridView";
            this.ArrayDataGridView.RowHeadersWidth = 51;
            this.ArrayDataGridView.RowTemplate.Height = 24;
            this.ArrayDataGridView.Size = new System.Drawing.Size(1105, 45);
            this.ArrayDataGridView.TabIndex = 12;
            // 
            // HeapDataGridView
            // 
            this.HeapDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.HeapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeapDataGridView.Location = new System.Drawing.Point(-1, 107);
            this.HeapDataGridView.Name = "HeapDataGridView";
            this.HeapDataGridView.RowHeadersWidth = 51;
            this.HeapDataGridView.RowTemplate.Height = 24;
            this.HeapDataGridView.Size = new System.Drawing.Size(1105, 205);
            this.HeapDataGridView.TabIndex = 13;
            // 
            // ChooseResultdataGridView
            // 
            this.ChooseResultdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ChooseResultdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChooseResultdataGridView.Location = new System.Drawing.Point(-2, 25);
            this.ChooseResultdataGridView.Name = "ChooseResultdataGridView";
            this.ChooseResultdataGridView.RowHeadersWidth = 51;
            this.ChooseResultdataGridView.RowTemplate.Height = 24;
            this.ChooseResultdataGridView.Size = new System.Drawing.Size(1105, 45);
            this.ChooseResultdataGridView.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(413, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Результат выборки";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(385, 86);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(230, 38);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1103, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewElemDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioriteteFromDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioriteteToDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeapDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseResultdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button GetLargestBtn;
        private System.Windows.Forms.Button ClearQueueBtn;
        private System.Windows.Forms.Button CreateQueueBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PrioriteteToDropDown;
        private System.Windows.Forms.NumericUpDown PrioriteteFromDropDown;
        private System.Windows.Forms.NumericUpDown NewElemDropDown;
        private System.Windows.Forms.Button ChangePrioriteteBtn;
        private System.Windows.Forms.DataGridView ArrayDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView HeapDataGridView;
        private System.Windows.Forms.DataGridView ChooseResultdataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitBtn;
    }
}

