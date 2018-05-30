using System;
using System.Collections.Generic;
using System.Text;

namespace NEO.Core
{
    public class MemberService:BaseService<Member>
    {
		public BaseResponse Create(Member entity)
		{
			BaseResponse response = new BaseResponse();

			return response;
		}

		public BaseResponse Modify(Member entity)
		{
			BaseResponse response = new BaseResponse();

			return response;
		}

		public Pager<Member> GetPage()
		{
		}
    }
}
