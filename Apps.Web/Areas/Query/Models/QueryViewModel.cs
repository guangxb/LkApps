using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Apps.Web.Areas.Query.Models
{
    public class QueryViewModel
    {
        [Display(Name ="用户编号")]
        public string UserId { get; set; }
        [Display(Name = "仓库")]
        public string WAREHOUSE { get; set; }
        [Display(Name = "编号")]
        public string ITEM { get; set; }
        [Display(Name = "描述")]
        public string ITEM_DESC { get; set; }
        [Display(Name = "所属公司")]
        public string COMPANY { get; set; }
        [Display(Name = "库存数量")]
        [Column(TypeName = "numeric")]
        public decimal ATTRIBUTE_NUM { get; set; }
        [Display(Name = "处理数量")]
        [Column(TypeName = "numeric")]
        public decimal ON_HAND_QTY { get; set; }
        /// <summary>
        /// 产品状态--合格
        /// </summary>
        public decimal IsQualified { get; set; }
        /// <summary>
        /// 产品状态--不合格
        /// </summary>
        public decimal IsNotQualified { get; set; }
        #region 商品保质期
        /// <summary>
        /// 保质期
        /// </summary>
        public decimal? DaysToExpire { get; set; }
        /// <summary>
        ///生产日期
        /// </summary>
        public DateTime? DateOfProduction { get; set; }
        /// <summary>
        /// 失效期
        /// </summary>
        public DateTime? DateOfExpiry { get; set; }
        #endregion

    }
}