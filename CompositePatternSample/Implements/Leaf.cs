using CompositePatternSample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSample.Implements
{
    /// <summary>
    /// 最底層員工(樹葉)
    /// </summary>
    public class Leaf : BaseEmployee
    {
        public Leaf(string name, Position position) 
            : base(name, position)
        {
        }

        /// <summary>
        /// 最底層無法新增
        /// </summary>
        public override void Add(BaseEmployee employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 最底層無法刪除
        /// </summary>
        public override void Remove(BaseEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
