using CompositePatternSample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSample.Implements
{
    /// <summary>
    /// 員工基底類
    /// </summary>
    public abstract class BaseEmployee
    {
        public string Name;

        public Position Position;

        public BaseEmployee(string name, Position position)
        {
            Name = name;
            Position = position;
        }

        public abstract void Add(BaseEmployee employee);

        public abstract void Remove(BaseEmployee employee);
    }
}
