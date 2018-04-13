using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;

namespace onTy.SimpleStatefulApp.Utils
{
	public class ConversationDS : DataContext
	{

		public ConversationDS( string ds )
			: base( ds )
		{
		}




	}
}