using System;
using System.Text;
using System.Windows.Forms;

namespace Course
{
    class FileWork
    {
        public static void ReadFromFile() //Чтение из файла и заполнение списка с проверкой
        {
            if (System.IO.File.Exists(Main.mainPath + "\\floor.txt"))
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(Main.mainPath + "\\floor.txt", Encoding.Default);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(';');
                        Floor floor = new Floor(Convert.ToInt32(fields[0]), fields[1]);
                        int index;
                        if (floor.IsValid())
                        {
                            if (!SList<Floor>.IsSimilarKey(floor.Number, Main.mainList, out index))
                            {
                                Main.mainList.Add(floor);
                            }
                            else
                            {
                                Main.mainList.RemoveAt(index);
                                Main.mainList.Insert(index, floor);
                            }
                        }
                    }

                    foreach (Floor floor in Main.mainList)
                    {
                        lines = System.IO.File.ReadAllLines(Main.mainPath + "\\" + floor.Path, Encoding.Default);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            string[] fields = lines[i].Split(';');
                            Classroom classroom = new Classroom(Convert.ToInt32(fields[0]), fields[1], Convert.ToDouble(fields[2]), Convert.ToBoolean(fields[3]), fields[4], Convert.ToInt32(fields[5]), fields[6]);
                            foreach (Floor f in Main.mainList)
                            {
                                if (f.Number == floor.Number)
                                {
                                    int index;
                                    if (classroom.IsValid())
                                    {
                                        if (!SList<Classroom>.IsSimilarKey(classroom.Number, floor.classrooms, out index))
                                        {
                                            floor.classrooms.Add(classroom);
                                        }
                                        else
                                        {
                                            floor.classrooms.RemoveAt(index);
                                            floor.classrooms.Insert(index, classroom);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch  { }
            }
        }
        public static void SaveFloorInFile() //запись в файл
        {
            try
            {
                if (!System.IO.File.Exists(Main.mainPath + "\\floor.txt"))
                {
                    System.IO.File.Create(Main.mainPath + "\\floor.txt").Close();
                }
                System.IO.File.WriteAllLines(Main.mainPath + "\\floor.txt", Main.mainList.ToString(), Encoding.Default);
                foreach (Floor floor in Main.mainList)
                {
                    System.IO.File.WriteAllLines(Main.mainPath + "\\" + floor.Path, floor.classrooms.ToString(), Encoding.Default);
                }
            }
            catch
            {
                MessageBox.Show("Не получается");
            }
        }
    }
}