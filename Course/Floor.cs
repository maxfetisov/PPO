﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
    public class Floor
    {
        private int number;
        private string path;
        public SList<Classroom> classrooms;
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
        public string Path { get => path; }
        public bool IsValid()
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
