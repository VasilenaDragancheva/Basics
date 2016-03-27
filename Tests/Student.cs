using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Student : IDisposable
    {
        public Student(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
