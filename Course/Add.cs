using System;
using System.Drawing;
using System.Windows.Forms;

namespace Course
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            submit.Click += Submit_Click;
            openImage.Filter = "Файлы изображений|*.png;*.jpg;*.bmp;*.gif;";
            addPicture.Click += AddPicture_Click;
        }

        private void AddPicture_Click(object sender, EventArgs e) //Добавление изображения к форме добавления элемента
        {
            if(openImage.ShowDialog() == DialogResult.OK)
            {
                classroomPicture.Image = Image.FromFile(openImage.FileName);
                classroomPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Submit_Click(object sender, EventArgs e) //Подтверждение создания элемента + проверка на его "валидность"
        {
            int index;
            Floor floor = new Floor((int)floorNumber.Value);
            Classroom classroom;
            if (openImage.FileName != "")
            {
                classroom = new Classroom((int)classroomNumber.Value, ownerName.Text, (double)square.Value, safety.Checked, department.Text, (int)capacity.Value, openImage.FileName);
            }
            else
            {
                classroom = new Classroom((int)classroomNumber.Value, ownerName.Text, (double)square.Value, safety.Checked, department.Text, (int)capacity.Value);
            }
            if (SList<Floor>.IsSimilarKey((int)floorNumber.Value, Main.mainList, out index))
            {
                foreach (Floor f in Main.mainList)
                    if (f.Number == floor.Number)
                    {
                        if (classroom.IsValid())
                        {
                            if (!SList<Classroom>.IsSimilarKey(classroom.Number, f.classrooms, out index))
                            {
                                f.classrooms.Add(classroom);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Аудитория с таким номером уже существует");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный формат заполнения");
                        }
                        break;
                    }

            }
            else
            {
                if (floor.IsValid())
                {
                    if (classroom.IsValid())
                    {
                        Main.mainList.Add(floor);
                        foreach (Floor f in Main.mainList)
                        {
                            if (f.Number == floor.Number)
                            {
                                f.classrooms.Add(classroom);
                                this.Close();
                                break;
                            }
                        } 
                    }
                }
                else
                    MessageBox.Show("Неверный формат заполнения");
            }
        }
    }
}