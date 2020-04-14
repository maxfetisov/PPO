using System.Collections;
using System.Collections.Generic;

namespace Course
{
    public class SList<T> : List<T>
    {
        public delegate void ListChangeHandler(object sender, ListEventArgs e);
        public event ListChangeHandler onListChange;
        public SList() : base() { }
        public new void Add(T value)
        {
            ListEventArgs e = new ListEventArgs(this.Count, this.Count + 1);
            base.Add(value);
            onListChange(this, e);
        }

        public static bool IsSimilarKey(int key, SList<Floor> floors, out int index)
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
        public static bool IsSimilarKey(int key, SList<Classroom> classrooms, out int index)
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
        public new void Clear()
        {
            ListEventArgs e = new ListEventArgs(this.Count, 0);
            base.Clear();
            onListChange(this, e);
        }
        public bool EqualsList(T value)
        {
            IEnumerator enumerator = this.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (value.ToString() == enumerator.Current.ToString()) return true;
            }
            return false;
        }
        public new void Insert(int index, T item)
        {
            ListEventArgs e = new ListEventArgs(this.Count, this.Count + 1);
            base.Insert(index, item);
            onListChange(this, e);
        }
        public new void Remove(T item)
        {
            ListEventArgs e = new ListEventArgs(this.Count, this.Count - 1);
            base.Remove(item);
            onListChange(this, e);
        }
        public new void RemoveAt(int index)
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
