namespace Course
{
    partial class Add
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
            this.safety = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.floorNumber = new System.Windows.Forms.NumericUpDown();
            this.classroomNumber = new System.Windows.Forms.NumericUpDown();
            this.ownerName = new System.Windows.Forms.TextBox();
            this.square = new System.Windows.Forms.NumericUpDown();
            this.department = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.classroomPicture = new System.Windows.Forms.PictureBox();
            this.addPicture = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер этажа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер аудитории:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Закреплено за:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Площадь:";
            // 
            // safety
            // 
            this.safety.AutoSize = true;
            this.safety.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safety.Location = new System.Drawing.Point(447, 338);
            this.safety.Name = "safety";
            this.safety.Size = new System.Drawing.Size(289, 24);
            this.safety.TabIndex = 4;
            this.safety.Text = "Пройдена проверка безопасности";
            this.safety.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(443, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кафедра:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(443, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Вместимость:";
            // 
            // floorNumber
            // 
            this.floorNumber.Location = new System.Drawing.Point(449, 287);
            this.floorNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.floorNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.floorNumber.Name = "floorNumber";
            this.floorNumber.Size = new System.Drawing.Size(48, 20);
            this.floorNumber.TabIndex = 7;
            // 
            // classroomNumber
            // 
            this.classroomNumber.Location = new System.Drawing.Point(218, 342);
            this.classroomNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.classroomNumber.Name = "classroomNumber";
            this.classroomNumber.Size = new System.Drawing.Size(161, 20);
            this.classroomNumber.TabIndex = 8;
            // 
            // ownerName
            // 
            this.ownerName.Location = new System.Drawing.Point(218, 387);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(161, 20);
            this.ownerName.TabIndex = 9;
            // 
            // square
            // 
            this.square.DecimalPlaces = 1;
            this.square.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.square.Location = new System.Drawing.Point(218, 430);
            this.square.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.square.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(161, 20);
            this.square.TabIndex = 10;
            this.square.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(597, 385);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(161, 20);
            this.department.TabIndex = 11;
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(597, 432);
            this.capacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(161, 20);
            this.capacity.TabIndex = 12;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Location = new System.Drawing.Point(353, 491);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(101, 33);
            this.submit.TabIndex = 13;
            this.submit.Text = "Добавить";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // classroomPicture
            // 
            this.classroomPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.classroomPicture.Location = new System.Drawing.Point(301, 25);
            this.classroomPicture.Name = "classroomPicture";
            this.classroomPicture.Size = new System.Drawing.Size(213, 207);
            this.classroomPicture.TabIndex = 14;
            this.classroomPicture.TabStop = false;
            // 
            // addPicture
            // 
            this.addPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.addPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPicture.Location = new System.Drawing.Point(301, 228);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(213, 23);
            this.addPicture.TabIndex = 15;
            this.addPicture.Text = "Добавить изображение";
            this.addPicture.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.classroomPicture);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.department);
            this.Controls.Add(this.square);
            this.Controls.Add(this.ownerName);
            this.Controls.Add(this.classroomNumber);
            this.Controls.Add(this.floorNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.safety);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление аудитории";
            ((System.ComponentModel.ISupportInitialize)(this.floorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox safety;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown floorNumber;
        private System.Windows.Forms.NumericUpDown classroomNumber;
        private System.Windows.Forms.TextBox ownerName;
        private System.Windows.Forms.NumericUpDown square;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.PictureBox classroomPicture;
        private System.Windows.Forms.Button addPicture;
        private System.Windows.Forms.OpenFileDialog openImage;
    }
}