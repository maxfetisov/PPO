namespace Course
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.source = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.floor = new System.Windows.Forms.TabPage();
            this.floorDataGridView = new System.Windows.Forms.DataGridView();
            this.floorNumberDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroomsDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autosave = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.message = new System.Windows.Forms.Label();
            this.watchPanel = new System.Windows.Forms.Panel();
            this.changeImage = new System.Windows.Forms.Button();
            this.cancelChange = new System.Windows.Forms.Button();
            this.submitChange = new System.Windows.Forms.Button();
            this.classroomsBox = new System.Windows.Forms.TextBox();
            this.classroomsLabel = new System.Windows.Forms.Label();
            this.closeWatchPanel = new System.Windows.Forms.Button();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.department = new System.Windows.Forms.TextBox();
            this.square = new System.Windows.Forms.NumericUpDown();
            this.ownerName = new System.Windows.Forms.TextBox();
            this.classroomNumber = new System.Windows.Forms.NumericUpDown();
            this.safety = new System.Windows.Forms.CheckBox();
            this.removeData = new System.Windows.Forms.Button();
            this.changeData = new System.Windows.Forms.Button();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.classroomLabel = new System.Windows.Forms.Label();
            this.floorNumber = new System.Windows.Forms.NumericUpDown();
            this.floorLabel = new System.Windows.Forms.Label();
            this.classroomPicture = new System.Windows.Forms.PictureBox();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.imageMessage = new System.Windows.Forms.Label();
            this.removeImage = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.floor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorDataGridView)).BeginInit();
            this.watchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.source,
            this.toolStripSeparator,
            this.add,
            this.toolStripSeparator1,
            this.saveButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(915, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // source
            // 
            this.source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.source.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.source.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.source.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.source.Image = ((System.Drawing.Image)(resources.GetObject("source.Image")));
            this.source.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(100, 22);
            this.source.Text = "Выбрать папку";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator.Visible = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 22);
            this.add.Text = "Добавить";
            this.add.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 22);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.floor);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(915, 733);
            this.tabControl.TabIndex = 1;
            this.tabControl.Visible = false;
            // 
            // floor
            // 
            this.floor.Controls.Add(this.floorDataGridView);
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor.Location = new System.Drawing.Point(4, 25);
            this.floor.Name = "floor";
            this.floor.Padding = new System.Windows.Forms.Padding(3);
            this.floor.Size = new System.Drawing.Size(907, 704);
            this.floor.TabIndex = 0;
            this.floor.Text = "Этажи";
            this.floor.UseVisualStyleBackColor = true;
            // 
            // floorDataGridView
            // 
            this.floorDataGridView.AllowUserToAddRows = false;
            this.floorDataGridView.AllowUserToDeleteRows = false;
            this.floorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.floorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.floorNumberDGV,
            this.classroomsDGV});
            this.floorDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.floorDataGridView.Location = new System.Drawing.Point(3, 3);
            this.floorDataGridView.Name = "floorDataGridView";
            this.floorDataGridView.Size = new System.Drawing.Size(903, 695);
            this.floorDataGridView.TabIndex = 0;
            // 
            // floorNumberDGV
            // 
            this.floorNumberDGV.HeaderText = "Номер этажа";
            this.floorNumberDGV.Name = "floorNumberDGV";
            this.floorNumberDGV.ReadOnly = true;
            this.floorNumberDGV.Width = 60;
            // 
            // classroomsDGV
            // 
            this.classroomsDGV.HeaderText = "Аудитории";
            this.classroomsDGV.Name = "classroomsDGV";
            this.classroomsDGV.ReadOnly = true;
            this.classroomsDGV.Width = 800;
            // 
            // autosave
            // 
            this.autosave.AutoSize = true;
            this.autosave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autosave.Location = new System.Drawing.Point(12, 793);
            this.autosave.Name = "autosave";
            this.autosave.Size = new System.Drawing.Size(136, 20);
            this.autosave.TabIndex = 2;
            this.autosave.Text = "Автосохранение";
            this.autosave.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.Location = new System.Drawing.Point(246, 392);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(428, 25);
            this.message.TabIndex = 3;
            this.message.Text = "Пока не открыто ни одного источника";
            // 
            // watchPanel
            // 
            this.watchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.watchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.watchPanel.Controls.Add(this.removeImage);
            this.watchPanel.Controls.Add(this.imageMessage);
            this.watchPanel.Controls.Add(this.changeImage);
            this.watchPanel.Controls.Add(this.cancelChange);
            this.watchPanel.Controls.Add(this.submitChange);
            this.watchPanel.Controls.Add(this.classroomsBox);
            this.watchPanel.Controls.Add(this.classroomsLabel);
            this.watchPanel.Controls.Add(this.closeWatchPanel);
            this.watchPanel.Controls.Add(this.capacity);
            this.watchPanel.Controls.Add(this.department);
            this.watchPanel.Controls.Add(this.square);
            this.watchPanel.Controls.Add(this.ownerName);
            this.watchPanel.Controls.Add(this.classroomNumber);
            this.watchPanel.Controls.Add(this.safety);
            this.watchPanel.Controls.Add(this.removeData);
            this.watchPanel.Controls.Add(this.changeData);
            this.watchPanel.Controls.Add(this.departmentLabel);
            this.watchPanel.Controls.Add(this.capacityLabel);
            this.watchPanel.Controls.Add(this.ownerLabel);
            this.watchPanel.Controls.Add(this.squareLabel);
            this.watchPanel.Controls.Add(this.classroomLabel);
            this.watchPanel.Controls.Add(this.floorNumber);
            this.watchPanel.Controls.Add(this.floorLabel);
            this.watchPanel.Controls.Add(this.classroomPicture);
            this.watchPanel.Location = new System.Drawing.Point(7, 448);
            this.watchPanel.Name = "watchPanel";
            this.watchPanel.Size = new System.Drawing.Size(904, 313);
            this.watchPanel.TabIndex = 4;
            this.watchPanel.Visible = false;
            // 
            // changeImage
            // 
            this.changeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.changeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeImage.Location = new System.Drawing.Point(6, 279);
            this.changeImage.Name = "changeImage";
            this.changeImage.Size = new System.Drawing.Size(176, 23);
            this.changeImage.TabIndex = 21;
            this.changeImage.Text = "Сменить изображение";
            this.changeImage.UseVisualStyleBackColor = false;
            // 
            // cancelChange
            // 
            this.cancelChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.cancelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelChange.Location = new System.Drawing.Point(489, 279);
            this.cancelChange.Name = "cancelChange";
            this.cancelChange.Size = new System.Drawing.Size(80, 23);
            this.cancelChange.TabIndex = 20;
            this.cancelChange.Text = "Отмена";
            this.cancelChange.UseVisualStyleBackColor = false;
            this.cancelChange.Visible = false;
            // 
            // submitChange
            // 
            this.submitChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.submitChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitChange.Location = new System.Drawing.Point(369, 279);
            this.submitChange.Name = "submitChange";
            this.submitChange.Size = new System.Drawing.Size(114, 23);
            this.submitChange.TabIndex = 19;
            this.submitChange.Text = "Подтвердить";
            this.submitChange.UseVisualStyleBackColor = false;
            this.submitChange.Visible = false;
            // 
            // classroomsBox
            // 
            this.classroomsBox.Enabled = false;
            this.classroomsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classroomsBox.Location = new System.Drawing.Point(306, 158);
            this.classroomsBox.Name = "classroomsBox";
            this.classroomsBox.Size = new System.Drawing.Size(360, 22);
            this.classroomsBox.TabIndex = 18;
            // 
            // classroomsLabel
            // 
            this.classroomsLabel.AutoSize = true;
            this.classroomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classroomsLabel.Location = new System.Drawing.Point(207, 158);
            this.classroomsLabel.Name = "classroomsLabel";
            this.classroomsLabel.Size = new System.Drawing.Size(85, 18);
            this.classroomsLabel.TabIndex = 17;
            this.classroomsLabel.Text = "Аудитории:";
            // 
            // closeWatchPanel
            // 
            this.closeWatchPanel.BackColor = System.Drawing.Color.Transparent;
            this.closeWatchPanel.BackgroundImage = global::Course.Properties.Resources.crest;
            this.closeWatchPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWatchPanel.FlatAppearance.BorderSize = 0;
            this.closeWatchPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWatchPanel.Location = new System.Drawing.Point(861, 15);
            this.closeWatchPanel.Name = "closeWatchPanel";
            this.closeWatchPanel.Size = new System.Drawing.Size(27, 27);
            this.closeWatchPanel.TabIndex = 16;
            this.closeWatchPanel.UseVisualStyleBackColor = false;
            // 
            // capacity
            // 
            this.capacity.Enabled = false;
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacity.Location = new System.Drawing.Point(768, 201);
            this.capacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(120, 22);
            this.capacity.TabIndex = 15;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // department
            // 
            this.department.Enabled = false;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department.Location = new System.Drawing.Point(768, 154);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(120, 22);
            this.department.TabIndex = 14;
            // 
            // square
            // 
            this.square.DecimalPlaces = 1;
            this.square.Enabled = false;
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.square.Location = new System.Drawing.Point(509, 201);
            this.square.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.square.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(120, 22);
            this.square.TabIndex = 13;
            this.square.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // ownerName
            // 
            this.ownerName.Enabled = false;
            this.ownerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerName.Location = new System.Drawing.Point(509, 154);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(120, 22);
            this.ownerName.TabIndex = 12;
            // 
            // classroomNumber
            // 
            this.classroomNumber.Enabled = false;
            this.classroomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classroomNumber.Location = new System.Drawing.Point(509, 106);
            this.classroomNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.classroomNumber.Name = "classroomNumber";
            this.classroomNumber.Size = new System.Drawing.Size(120, 22);
            this.classroomNumber.TabIndex = 11;
            // 
            // safety
            // 
            this.safety.AutoSize = true;
            this.safety.Enabled = false;
            this.safety.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safety.Location = new System.Drawing.Point(645, 106);
            this.safety.Name = "safety";
            this.safety.Size = new System.Drawing.Size(253, 22);
            this.safety.TabIndex = 10;
            this.safety.Text = "Прошла проверку безопасности";
            this.safety.UseVisualStyleBackColor = true;
            // 
            // removeData
            // 
            this.removeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.removeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeData.Location = new System.Drawing.Point(489, 279);
            this.removeData.Name = "removeData";
            this.removeData.Size = new System.Drawing.Size(80, 23);
            this.removeData.TabIndex = 9;
            this.removeData.Text = "Удалить";
            this.removeData.UseVisualStyleBackColor = false;
            // 
            // changeData
            // 
            this.changeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.changeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeData.Location = new System.Drawing.Point(369, 279);
            this.changeData.Name = "changeData";
            this.changeData.Size = new System.Drawing.Size(94, 23);
            this.changeData.TabIndex = 8;
            this.changeData.Text = "Изменить";
            this.changeData.UseVisualStyleBackColor = false;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLabel.Location = new System.Drawing.Point(642, 155);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(76, 18);
            this.departmentLabel.TabIndex = 7;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacityLabel.Location = new System.Drawing.Point(642, 201);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(107, 18);
            this.capacityLabel.TabIndex = 6;
            this.capacityLabel.Text = "Вместимость:";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLabel.Location = new System.Drawing.Point(368, 155);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(115, 18);
            this.ownerLabel.TabIndex = 5;
            this.ownerLabel.Text = "Закреплена за:";
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareLabel.Location = new System.Drawing.Point(368, 201);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(77, 18);
            this.squareLabel.TabIndex = 4;
            this.squareLabel.Text = "Площадь:";
            // 
            // classroomLabel
            // 
            this.classroomLabel.AutoSize = true;
            this.classroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classroomLabel.Location = new System.Drawing.Point(368, 106);
            this.classroomLabel.Name = "classroomLabel";
            this.classroomLabel.Size = new System.Drawing.Size(135, 18);
            this.classroomLabel.TabIndex = 3;
            this.classroomLabel.Text = "Номер аудитории:";
            // 
            // floorNumber
            // 
            this.floorNumber.Enabled = false;
            this.floorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorNumber.Location = new System.Drawing.Point(444, 55);
            this.floorNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.floorNumber.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.floorNumber.Name = "floorNumber";
            this.floorNumber.Size = new System.Drawing.Size(59, 22);
            this.floorNumber.TabIndex = 2;
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorLabel.Location = new System.Drawing.Point(368, 55);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(49, 18);
            this.floorLabel.TabIndex = 1;
            this.floorLabel.Text = "Этаж:";
            // 
            // classroomPicture
            // 
            this.classroomPicture.Location = new System.Drawing.Point(6, 15);
            this.classroomPicture.Name = "classroomPicture";
            this.classroomPicture.Size = new System.Drawing.Size(353, 263);
            this.classroomPicture.TabIndex = 0;
            this.classroomPicture.TabStop = false;
            // 
            // removeAllButton
            // 
            this.removeAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.removeAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeAllButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removeAllButton.Location = new System.Drawing.Point(794, 790);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(109, 23);
            this.removeAllButton.TabIndex = 5;
            this.removeAllButton.Text = "Удалить все";
            this.removeAllButton.UseVisualStyleBackColor = false;
            this.removeAllButton.Visible = false;
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog";
            // 
            // imageMessage
            // 
            this.imageMessage.AutoSize = true;
            this.imageMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageMessage.Location = new System.Drawing.Point(69, 153);
            this.imageMessage.Name = "imageMessage";
            this.imageMessage.Size = new System.Drawing.Size(231, 20);
            this.imageMessage.TabIndex = 22;
            this.imageMessage.Text = "Изображение отсутствует";
            // 
            // removeImage
            // 
            this.removeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(74)))), ((int)(((byte)(120)))));
            this.removeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeImage.Location = new System.Drawing.Point(183, 279);
            this.removeImage.Name = "removeImage";
            this.removeImage.Size = new System.Drawing.Size(176, 23);
            this.removeImage.TabIndex = 23;
            this.removeImage.Text = "Удалить изображение";
            this.removeImage.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(223)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(915, 825);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.watchPanel);
            this.Controls.Add(this.autosave);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.message);
            this.MinimumSize = new System.Drawing.Size(931, 833);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.floor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floorDataGridView)).EndInit();
            this.watchPanel.ResumeLayout(false);
            this.watchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton source;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage floor;
        private System.Windows.Forms.DataGridView floorDataGridView;
        private System.Windows.Forms.CheckBox autosave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Panel watchPanel;
        private System.Windows.Forms.Button closeWatchPanel;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.NumericUpDown square;
        private System.Windows.Forms.TextBox ownerName;
        private System.Windows.Forms.NumericUpDown classroomNumber;
        private System.Windows.Forms.CheckBox safety;
        private System.Windows.Forms.Button removeData;
        private System.Windows.Forms.Button changeData;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.Label classroomLabel;
        private System.Windows.Forms.NumericUpDown floorNumber;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.PictureBox classroomPicture;
        private System.Windows.Forms.TextBox classroomsBox;
        private System.Windows.Forms.Label classroomsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroomsDGV;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button cancelChange;
        private System.Windows.Forms.Button submitChange;
        private System.Windows.Forms.Button changeImage;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Label imageMessage;
        private System.Windows.Forms.Button removeImage;
    }
}

