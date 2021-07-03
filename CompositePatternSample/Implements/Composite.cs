using CompositePatternSample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSample.Implements
{
    /// <summary>
    /// 員工(樹枝)
    /// </summary>
    public class Composite : BaseEmployee
    {
        /// <summary>
        /// 下屬清單(也就是樹枝的子層)
        /// </summary>
        public List<BaseEmployee> Subordinates;

        public Composite(string name, Position position)
            : base(name, position)
        {
            Subordinates = new List<BaseEmployee>();
        }

        /// <summary>
        /// 新增
        /// </summary>
        public override void Add(BaseEmployee employee)
        {
            Subordinates.Add(employee);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        public override void Remove(BaseEmployee employee)
        {
            Subordinates.Add(employee);
        }
    }
}
