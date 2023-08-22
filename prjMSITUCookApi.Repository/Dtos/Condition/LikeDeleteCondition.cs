﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMSITUCookApi.Repository.Dtos.Condition
{
    public class LikeDeleteCondition
    {
        /// <summary>
        /// 對該文章按讚的用戶
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 按讚的食譜Id
        /// </summary>
        public int RecipeId { get; set; }
    }
}
