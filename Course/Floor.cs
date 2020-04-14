namespace Course
{
    public class Floor
    {
        private int number; //Номер этажа
        private string path; //Путь к файлу, гре хранятся аудитории
        public SList<Classroom> classrooms; //Список аудиторий
        public Floor()
        {
            path = "Classroom" + number + ".txt";
            classrooms = new SList<Classroom>();
        }

        public Floor(int number)
        {
            this.number = number;
            path = "Classroom" + number + ".txt";
            classrooms = new SList<Classroom>();
        }
        public Floor(int number, string path)
        {
            this.number = number;
            this.path = path;
            classrooms = new SList<Classroom>();
        }
        public int Number { get => number; set => number = value; }
        public string Path { get => path; set => path = value; }
        public bool IsValid() //Проверка "валидности" данных об этаже
        {
            try
            {
                if (char.IsLetter(path[0]) && (path[path.Length - 4] == '.' && path[path.Length - 3] == 't' && path[path.Length - 2] == 'x' && path[path.Length - 1] == 't')) return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public override string ToString() => number + ";" + path;
    }

}
