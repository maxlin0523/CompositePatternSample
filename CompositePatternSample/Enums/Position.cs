using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSample.Enums
{
    /// <summary>
    /// 職位
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Position
    {
        /// <summary>
        /// 產品經理
        /// </summary>
        ProductManager,
        /// <summary>
        /// 前端開發主管
        /// </summary>
        HeadFrontend,
        /// <summary>
        /// 後端開發主管
        /// </summary>
        HeadBackend,
        /// <summary>
        /// 資料庫管理主管
        /// </summary>
        HeadDatabase,
        /// <summary>
        /// 前端開發工程師
        /// </summary>
        FrontendRD,
        /// <summary>
        /// 後端開發工程師
        /// </summary>
        BackendRD,
        /// <summary>
        /// 資料庫管理師
        /// </summary>
        DBA,
        /// <summary>
        /// 實習生
        /// </summary>
        Intern,
    }
}
