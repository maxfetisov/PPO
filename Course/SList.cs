using System.Collections;
using System.Collections.Generic;

namespace Course
{
    public class SList<T> : List<T>
    {
        public delegate void ListChangeHandler(object sender, ListEventArgs e);
        public event ListChangeHandler onListChange;
        public SList() : base() { }
        public new void Add(T value) //Добавление элемента в список
        {
            ListEventArgs e = new ListEventArgs(this.Count, this.Count + 1);
            base.Add(value);
            onListChange(this, e);
        }

        public static bool IsSimilarKey(int key, SList<Floor> floors, out int index) //Проверка на существование этажа со схожим номером в списке
        {
            foreach(Floor floor in floors)
            {
                if (floor.Number == key)
                {
                    index = floors.IndexOf(floor);
                    return true;
                }
            }
            index = -1;
            return false;
        }
        public static bool IsSimilarKey(int key, SList<Classroom> classrooms, out int index) //Проверка на существование аудитории со схожим номером в списке
        {
            foreach(Classroom classroom in classrooms)
            {
                if (classroom.Number == key)
                {
                    index = classrooms.IndexOf(classroom);
                    return true;
                }
            }
            index = -1;
            return false;
        }
        public new void Clear() //Очистка списка
        {
            ListEventArgs e = new ListEventArgs(this.Count, 0);
            base.Clear();
            onListChange(this, e);
        }
        public new void Insert(int index, T item) //Вставка элемента по индексу в список
        {
            ListEventArgs e = new ListEventArgs(this.Count, this.Count + 1);
            base.Insert(index, item);
            onListChange(this, e);
        }
        public new void Remove(T item) //Удаление элемента из списка
        {
            ListEventArgs e = new ListEventArgs(this.Count, this.Count - 1);
            base.Remove(item);
            onListChange(this, e);
        }
        public new void RemoveAt(int index) //Удаление эелемента по индексу из списка
        {
            ListEventArgs e = new ListEventArgs(this.Count, this.Count - 1);
            base.RemoveAt(index);
            onListChange(this, e);
        }
        public new string[] ToString()
        {
            string[] lines = new string[this.Count];
            IEnumerator enumerator = this.GetEnumerator();
            for (int i = 0; enumerator.MoveNext(); i++)
            {
                lines[i] = enumerator.Current.ToString();
            }
            return lines;
        }
    }

}
