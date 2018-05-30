using System;
using System.Collections.Generic;
using System.Text;

namespace NEO.Core
{
    public class BaseModuleService:BaseService<BaseModule>
    {
		public BaseResponse Create(BaseModule entity)
		{
			BaseResponse response = new BaseResponse();

			return response;
		}

		public BaseResponse Modify(BaseModule entity)
		{
			BaseResponse response = new BaseResponse();

			return response;
		}

		public Pager<BaseModule> GetPage()
		{
		}
    }
}
