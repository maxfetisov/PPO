using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Course
{
    public partial class Main : Form
    {
        public static SList<Floor> mainList = new SList<Floor>(); //Список этажей зданияздания
        public static string mainPath; //Путь к главному файлу
        public static bool autosaveInFile = false; //Включено ли автосохранение
        private int bufIndex; 
        public Main()
        {
            InitializeComponent();
            sourceButton.Click += Source_Click;
            mainList.onListChange += MainListChanged;
            addButton.Click += Add_Click;
            saveButton.Click += SaveButton_Click;
            autosave.CheckedChanged += Autosave_CheckedChanged;
            floorDataGridView.CellClick += FloorDataGridView_CellClick;
            floorDataGridView.CellDoubleClick += FloorDataGridView_CellDoubleClick;
            closeWatchPanel.Click += CloseWatchPanel_Click;
            floorclassroomTabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            removeData.Click += RemoveData_Click;
            removeAllButton.Click += RemoveAllButton_Click;
            changeData.Click += ChangeData_Click;
            cancelChange.Click += CancelChange_Click;
            submitChange.Click += SubmitChange_Click;
            changeImage.Click += ChangeImage_Click;
            removeImage.Click += RemoveImage_Click;
        }

        private void RemoveImage_Click(object sender, EventArgs e) //Удаление изображения у элемента с помощью панели просмотра
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить изображение?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                imageMessage.Visible = true;
                classroomPicture.Visible = false;
                foreach (Floor f in mainList)
                {
                    if (f.Number == (int)floorNumber.Value)
                    {
                        foreach (Classroom c in f.classrooms)
                        {
                            if (c.Number == (int)classroomNumber.Value)
                                c.Image = "";
                        }
                    }
                }           
            }
        }

        private void ChangeImage_Click(object sender, EventArgs e) //Изменение изображения у элемента с помощью панели просмотра
        {
            openImage.Filter = "Файлы изображений|*.png;*.jpg;*.bmp;*.gif;";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                if (!classroomPicture.Visible)
                {
                    imageMessage.Visible = false;
                    classroomPicture.Visible = true;
                }
                foreach(Floor f in mainList)
                {
                    if(f.Number == (int)floorNumber.Value)
                    {
                        foreach(Classroom c in f.classrooms)
                        {
                            if (c.Number == (int)classroomNumber.Value)
                            {
                                c.Image = openImage.FileName;
                                classroomPicture.SizeMode = PictureBoxSizeMode.Zoom;
                                classroomPicture.Image = Image.FromFile(c.Image);
                            }
                        }
                    }
                }
            }
        }

        private void SubmitChange_Click(object sender, EventArgs e) //Подтверждение изменений на панели просмотра
        {
            if (classroomsBox.Visible)
            {
                floorNumber.Enabled = false;
                Floor floor = new Floor();
                int i = 0;
                bool flag = false;
                foreach(Floor f in mainList)
                {
                    if (i == bufIndex)
                    {
                        floor = f;
                        i = f.Number;
                    }
                    if (f.Number == (int)floorNumber.Value)
                        flag = true;
                    i++;
                }
                if (flag)
                {
                    mainList.RemoveAt(bufIndex);
                    foreach (Floor f in mainList)
                    {
                        if (f.Number == (int)floorNumber.Value)
                        {
                            foreach (Classroom c in floor.classrooms)
                            {
                                int index;
                                if (!SList<Classroom>.IsSimilarKey(c.Number, f.classrooms, out index))
                                    f.classrooms.Add(c);
                            }
                        }
                    }
                }
                else
                {
                    floor.Number = (int)floorNumber.Value;
                    floor.Path = "Classroom" + floor.Number + ".txt";
                    File.Delete(mainPath + "\\Classroom" + i + ".txt");
                    mainList.RemoveAt(bufIndex);
                    mainList.Insert(bufIndex, floor);
                }
            }
            else
            {
                classroomNumber.Enabled = false;
                ownerName.Enabled = false;
                square.Enabled = false;
                safety.Enabled = false;
                department.Enabled = false;
                capacity.Enabled = false;
                int i = 0;
                foreach (Floor f in mainList)
                {
                    if (f.Number == (int)floorNumber.Value)
                    {
                        bool flag = false;
                        foreach(Classroom c in f.classrooms)
                        {
                            if (c.Number == (int)classroomNumber.Value && f.classrooms.IndexOf(c) != bufIndex)
                                flag = true;
                        }
                        if (!flag)
                        {
                            Classroom classroom = new Classroom((int)classroomNumber.Value, ownerName.Text, (double)square.Value, safety.Checked, department.Text, (int)capacity.Value);
                            f.classrooms.RemoveAt(bufIndex);
                            f.classrooms.Insert(bufIndex, classroom);
                        }
                        else
                        {
                            MessageBox.Show("Аудитория с таким номером уже есть на данном этаже");
                            CancelChange_Click(sender, e);
                        }
                        break;
                    }
                    i++;
                }
            }
            changeData.Visible = true;
            removeData.Visible = true;
            submitChange.Visible = false;
            cancelChange.Visible = false;
            if (!classroomsBox.Visible)
            {
                changeImage.Visible = true;
                removeImage.Visible = true;
            }
        }

        private void CancelChange_Click(object sender, EventArgs e) //Отмена изменений на панели просмотра
        {
            classroomNumber.Enabled = false;
            ownerName.Enabled = false;
            square.Enabled = false;
            safety.Enabled = false;
            department.Enabled = false;
            capacity.Enabled = false;
            floorNumber.Enabled = false;
            if (watchPanel.Visible)
            {
                if (classroomsBox.Visible)
                {
                    int i = 0;
                    foreach (Floor f in mainList)
                    {
                        if (i == bufIndex)
                        {
                            floorNumber.Value = f.Number;
                            break;
                        }
                        i++;
                    }
                }
                else
                {
                    foreach (Floor f in mainList)
                    {
                        if (f.Number == (int)floorNumber.Value)
                        {
                            int i = 0;
                            foreach (Classroom c in f.classrooms)
                            {
                                if (i == bufIndex)
                                {
                                    classroomNumber.Value = c.Number;
                                    ownerName.Text = c.OwnerName;
                                    square.Value = (decimal)c.Square;
                                    safety.Checked = c.Safety;
                                    department.Text = c.Department;
                                    capacity.Value = c.Capacity;
                                    break;
                                }
                                i++;
                            }
                            break;
                        }
                    }
                }
            }
            changeData.Visible = true;
            removeData.Visible = true;
            submitChange.Visible = false;
            cancelChange.Visible = false;
            if (!classroomsBox.Visible)
            {
                changeImage.Visible = true;
                removeImage.Visible = true;
            }
            bufIndex = -1;
        }

        private void ChangeData_Click(object sender, EventArgs e) //Начать изменять элемент, выбранный на панели просмотра
        {
            if (classroomsBox.Visible)
            {
                SList<Floor>.IsSimilarKey((int)floorNumber.Value, mainList, out bufIndex);
                floorNumber.Enabled = true;
            }
            else
            {
                int floor = (int)floorNumber.Value;
                foreach(Floor f in mainList)
                {
                    if(f.Number == floor)
                    {
                        SList<Classroom>.IsSimilarKey((int)classroomNumber.Value, f.classrooms, out bufIndex);
                        classroomNumber.Enabled = true;
                        ownerName.Enabled = true;
                        square.Enabled = true;
                        safety.Enabled = true;
                        department.Enabled = true;
                        capacity.Enabled = true;
                        break;
                    }
                }
                
            }
            changeImage.Visible = true;
            changeData.Visible = false;
            removeData.Visible = false;
            submitChange.Visible = true;
            cancelChange.Visible = true;
            changeImage.Visible = false;
            removeImage.Visible = false;
        }

        private void RemoveAllButton_Click(object sender, EventArgs e) //Удаление всего списка
        {
            if (MessageBox.Show("Вы уверены, что хотите полностью удалить список? Отменить действие будет невозможно", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Я не шучу, вы точно этого хотите?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Предупреждаю последний раз. Назад пути не будет", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (Floor f in mainList)
                        {
                            File.Delete(mainPath + "\\" + f.Path);
                        }
                        File.Delete(mainPath + "\\floor.txt");
                        mainList.Clear();
                        GC.Collect();
                    }
                }
            }
        }

        private void RemoveData_Click(object sender, EventArgs e) //Удаление единичной записи
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить элемент списка? Отменить действие будет невозможно.", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (classroomsBox.Visible)
                {
                    int index;
                    if (SList<Floor>.IsSimilarKey((int)floorNumber.Value, mainList, out index))
                    {
                        mainList.RemoveAt(index);
                    }
                    File.Delete(mainPath + "\\Classroom" + (int)floorNumber.Value + ".txt");
                }
                else
                {
                    int index;
                    foreach (Floor f in mainList)
                    {
                        if (f.Number == (int)floorNumber.Value)
                            if (SList<Classroom>.IsSimilarKey((int)classroomNumber.Value, f.classrooms, out index))
                                f.classrooms.RemoveAt(index);
                    }
                }
                CloseWatchPanel_Click(sender, e);
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e) //Закрытие панели присмотра и обновления таблицы при переключении вкладок
        {
            if (floorclassroomTabControl.SelectedTab.Name != "floor")
            {         
                FillTabPage(floorclassroomTabControl.SelectedTab, GetFloorFromTabPageName(floorclassroomTabControl.SelectedTab.Name));
            }
            CloseWatchPanel_Click(sender, e);
        }

        private void FloorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Открытие подробной информации об этаже
        {
            if (e.RowIndex >= 0)
            {
                TabPage tabPage = new TabPage("Аудитории " + floorDataGridView.Rows[e.RowIndex].Cells[0].Value + " этажа");
                tabPage.Name = "classroom" + floorDataGridView.Rows[e.RowIndex].Cells[0].Value;
                foreach (TabPage tab in floorclassroomTabControl.TabPages)
                {
                    if (tabPage.Text == tab.Text)
                    {
                        return;
                    }
                }
                floorclassroomTabControl.TabPages.Add(tabPage);
                floorclassroomTabControl.SelectedIndex = floorclassroomTabControl.TabCount - 1;
                FillTabPage(floorclassroomTabControl.SelectedTab, (int)floorDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }     
        }

        private void CloseWatchPanel_Click(object sender, EventArgs e) //Закрытие панели просмотра
        {
            floorclassroomTabControl.Size = new Size(915, 733);
            watchPanel.Visible = false;
            if (floorclassroomTabControl.SelectedTab.Name != "floor")
            {
                FillTabPage(floorclassroomTabControl.SelectedTab, GetFloorFromTabPageName(floorclassroomTabControl.SelectedTab.Name));
            }
            CancelChange_Click(sender, e);
        }

        private void FloorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) //Открытие панели просмотра информации об этаже
        {
            if (e.RowIndex >= 0)
            {
                changeImage.Visible = false;
                removeImage.Visible = false;
                classroomPicture.Visible = false;
                imageMessage.Visible = false;
                classroomsBox.Visible = true;
                classroomsLabel.Visible = true;
                floorclassroomTabControl.Size = new Size(915, 414);
                watchPanel.Visible = true;
                classroomNumber.Visible = false;
                classroomLabel.Visible = false;
                ownerName.Visible = false;
                ownerLabel.Visible = false;
                square.Visible = false;
                squareLabel.Visible = false;
                safety.Visible = false;
                department.Visible = false;
                departmentLabel.Visible = false;
                capacity.Visible = false;
                capacityLabel.Visible = false;
                int i = 0;
                foreach (Floor floor in mainList)
                {
                    if (floor.Number == (int)floorDataGridView.Rows[e.RowIndex].Cells[0].Value)
                    {
                        floorNumber.Value = floor.Number;
                        classroomsBox.Text = floorDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        break;
                    }
                    i++;
                }
            }
        }

        private void Autosave_CheckedChanged(object sender, EventArgs e) //Изменение параметра автосохранения
        {
            autosaveInFile = autosave.Checked;
        }

        private void Add_Click(object sender, EventArgs e) //Открытие формы добавления элемента
        {
            Add addForm = new Add();
            addForm.Show();
            FillFloorDataGridView();
        }

        private void Source_Click(object sender, EventArgs e) //Открытие источника в виде папки
        {
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                if (autosave.Checked)
                {
                    autosave.Checked = false;
                    mainList.Clear();
                    autosave.Checked = true;
                }
                mainList.Clear();
                mainPath = openFolder.SelectedPath;
                addSeparator.Visible = true;
                saveSeparator.Visible = true;
                addButton.Visible = true;
                floorclassroomTabControl.Visible = true;
                message.Visible = false;
                saveButton.Visible = true;
                removeAllButton.Visible = true;
                FileWork.ReadFromFile();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) //Сохранение списка в файл
        {
            FileWork.SaveFloorInFile();
        }

        public void MainListChanged(object sender, ListEventArgs e) //Обновление главной таблицы (файлов при автосохранении)
        {
            foreach(Floor f in mainList)
            {
                f.classrooms.onListChange += Classrooms_onListChange;
            }
            if (autosave.Checked)
                FileWork.SaveFloorInFile();
            FillFloorDataGridView();
        }

        private void Classrooms_onListChange(object sender, ListEventArgs e) //Обновление главной таблицы при изменении списков аудиторий
        {
            if (autosave.Checked)
                FileWork.SaveFloorInFile();
            FillFloorDataGridView();
        }

        private void FillTabPage(TabPage tabPage, int floor) //Заполнение вкладок подробной информацией о этажах
        {
            tabPage.Controls.Clear();
            Button closeTab = new Button();
            closeTab.Text = "Закрыть";
            DataGridView classroomDataGridView = new DataGridView();
            classroomDataGridView.Name = "classroomDataGridView" + floor + "floor";
            classroomDataGridView.ReadOnly = true;
            if (watchPanel.Visible)
            {
                classroomDataGridView.Size = new Size(915, 350);
                closeTab.Location = new Point(810, 360);
            }
            else
            {
                classroomDataGridView.Size = new Size(915, 669);
                closeTab.Location = new Point(810, 679);
            }
            classroomDataGridView.AllowUserToAddRows = false;
            classroomDataGridView.AllowUserToDeleteRows = false;
            classroomDataGridView.Columns.Add("classroomNumberDGV", "Номер аудитории");
            classroomDataGridView.Columns[0].Width = 130;
            classroomDataGridView.Columns.Add("ownerNameDGV", "Закреплен за");
            classroomDataGridView.Columns[1].Width = 150;
            classroomDataGridView.Columns.Add("square", "Площадь");
            classroomDataGridView.Columns[2].Width = 100;
            classroomDataGridView.Columns.Add("safety", "Прошла проверку безопасности");
            classroomDataGridView.Columns[3].Width = 230;
            classroomDataGridView.Columns.Add("department", "Кафедра");
            classroomDataGridView.Columns[4].Width = 160;
            classroomDataGridView.Columns.Add("capacity", "Вместимость");
            classroomDataGridView.Columns[5].Width = 100;
            tabPage.Controls.Add(closeTab);
            tabPage.Controls.Add(classroomDataGridView);
            closeTab.Click += CloseTab_Click;
            classroomDataGridView.CellClick += ClassroomDataGridView_CellClick;
            foreach (Floor f in mainList)
            {
                if (f.Number == floor)
                {
                    int i = 0;
                    foreach (Classroom c in f.classrooms)
                    {
                        classroomDataGridView.Rows.Add();
                        classroomDataGridView.Rows[i].Cells[0].Value = c.Number;
                        classroomDataGridView.Rows[i].Cells[1].Value = c.OwnerName;
                        classroomDataGridView.Rows[i].Cells[2].Value = c.Square;
                        classroomDataGridView.Rows[i].Cells[3].Value = c.Safety;
                        classroomDataGridView.Rows[i].Cells[4].Value = c.Department;
                        classroomDataGridView.Rows[i].Cells[5].Value = c.Capacity;
                        i++;
                    }
                }
            }
        }

        private void ClassroomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) //Открытие панели просмотра информации об аудитории
        {
            if (e.RowIndex >= 0)
            {
                watchPanel.Visible = true;
                changeImage.Visible = true;
                removeImage.Visible = true;
                FillTabPage(floorclassroomTabControl.SelectedTab, GetFloorFromTabPageName(floorclassroomTabControl.SelectedTab.Name));
                classroomsLabel.Visible = false;
                classroomsBox.Visible = false;
                classroomLabel.Visible = true;
                classroomNumber.Visible = true;
                ownerLabel.Visible = true;
                ownerName.Visible = true;
                squareLabel.Visible = true;
                square.Visible = true;
                safety.Visible = true;
                departmentLabel.Visible = true;
                department.Visible = true;
                capacityLabel.Visible = true;
                capacity.Visible = true;
                classroomNumber.Value = Convert.ToDecimal((sender as DataGridView).Rows[e.RowIndex].Cells[0].Value);
                ownerName.Text = (sender as DataGridView).Rows[e.RowIndex].Cells[1].Value.ToString();
                square.Value = Convert.ToDecimal((sender as DataGridView).Rows[e.RowIndex].Cells[2].Value);
                safety.Checked = Convert.ToBoolean((sender as DataGridView).Rows[e.RowIndex].Cells[3].Value);
                department.Text = (sender as DataGridView).Rows[e.RowIndex].Cells[4].Value.ToString();
                capacity.Value = Convert.ToDecimal((sender as DataGridView).Rows[e.RowIndex].Cells[5].Value);
                foreach (Floor f in mainList)
                {
                    if (f.Number == (int)floorNumber.Value)
                    {
                        foreach (Classroom c in f.classrooms)
                        {
                            if (c.Number == (int)classroomNumber.Value)
                            {
                                if (!string.IsNullOrEmpty(c.Image)){
                                    try
                                    {
                                        classroomPicture.Visible = true;
                                        imageMessage.Visible = false;
                                        classroomPicture.SizeMode = PictureBoxSizeMode.Zoom;
                                        classroomPicture.Image = Image.FromFile(c.Image);
                                    }
                                    catch
                                    {
                                        classroomPicture.Visible = false;
                                        imageMessage.Visible = true;
                                    }
                                }
                                else
                                {
                                    classroomPicture.Visible = false;
                                    imageMessage.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CloseTab_Click(object sender, EventArgs e)  //Закрытие текущей вкладки
        {
            floorclassroomTabControl.TabPages.Remove(floorclassroomTabControl.SelectedTab);
        }

        private int GetFloorFromTabPageName(string name)  //Получение номера этажа по названию вкладки
        {
            string floor = "";
            for (int i = 9; i < floorclassroomTabControl.SelectedTab.Name.Length; i++)
            {
                floor += floorclassroomTabControl.SelectedTab.Name[i];
            }
            return Convert.ToInt32(floor);
        }
        private void FillFloorDataGridView() //Заполнение главной таблицы
        {
            floorDataGridView.Rows.Clear();
            int i = 0;
            foreach (Floor f in mainList)
            {
                floorDataGridView.Rows.Add();
                floorDataGridView.Rows[i].Cells[0].Value = f.Number;
                string classroomsDGV = "";
                foreach (Classroom c in f.classrooms)
                    classroomsDGV += c.Number + ", ";
                classroomsDGV = classroomsDGV.Trim(',', ' ');
                floorDataGridView.Rows[i].Cells[1].Value = classroomsDGV;
                i++;
            }
            if(floorclassroomTabControl.SelectedTab.Name != "floor")
            {
                FillTabPage(floorclassroomTabControl.SelectedTab, GetFloorFromTabPageName(floorclassroomTabControl.SelectedTab.Name));
            }
        }
    }
}