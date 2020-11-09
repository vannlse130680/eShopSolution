using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.DTOs
{
    public class PagingRequestBase
    {
        //vị trí lấy trang la bao nhiêu
        public int PageIndex { get; set; }

        public int PageSize { get; set; }


    }
}
