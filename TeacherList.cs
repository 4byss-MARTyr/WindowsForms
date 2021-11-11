using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class TeacherList
    {
        private List<Teacher> _teacherList = new List<Teacher>();
        public List<Teacher> Teachers
        {
            get
            {
                return _teacherList;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherList.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (_teacherList.Contains(teacher))
            {
                _teacherList.Remove(teacher);
            }
        }

    }
}