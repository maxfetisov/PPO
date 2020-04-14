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
            this.floorNumberLabel = new System.Windows.Forms.Label();
            this.classroomLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.safety = new System.Windows.Forms.CheckBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
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
            // floorNumberLabel
            // 
            this.floorNumberLabel.AutoSize = true;
            this.floorNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorNumberLabel.Location = new System.Drawing.Point(329, 284);
            this.floorNumberLabel.Name = "floorNumberLabel";
            this.floorNumberLabel.Size = new System.Drawing.Size(114, 20);
            this.floorNumberLabel.TabIndex = 0;
            this.floorNumberLabel.Text = "Номер этажа:";
            // 
            // classroomLabel
            // 
            this.classroomLabel.AutoSize = true;
            this.classroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classroomLabel.Location = new System.Drawing.Point(49, 339);
            this.classroomLabel.Name = "classroomLabel";
            this.classroomLabel.Size = new System.Drawing.Size(148, 20);
            this.classroomLabel.TabIndex = 1;
            this.classroomLabel.Text = "Номер аудитории:";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLabel.Location = new System.Drawing.Point(49, 385);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(126, 20);
            this.ownerLabel.TabIndex = 2;
            this.ownerLabel.Text = "Закреплено за:";
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareLabel.Location = new System.Drawing.Point(49, 431);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(86, 20);
            this.squareLabel.TabIndex = 3;
            this.squareLabel.Text = "Площадь:";
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
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLabel.Location = new System.Drawing.Point(443, 383);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(85, 20);
            this.departmentLabel.TabIndex = 5;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacityLabel.Location = new System.Drawing.Point(443, 429);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(116, 20);
            this.capacityLabel.TabIndex = 6;
            this.capacityLabel.Text = "Вместимость:";
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
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.safety);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.classroomLabel);
            this.Controls.Add(this.floorNumberLabel);
            this.MaximumSize = new System.Drawing.Size(816, 576);
            this.MinimumSize = new System.Drawing.Size(816, 576);
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

        private System.Windows.Forms.Label floorNumberLabel;
        private System.Windows.Forms.Label classroomLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.CheckBox safety;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label capacityLabel;
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