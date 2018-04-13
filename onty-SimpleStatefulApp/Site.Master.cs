using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace TrySimpleWebapp01
{
	public partial class SiteMaster : MasterPage
	{
		public string appVersion;
		public string appName;

		protected void Page_Load( object sender, EventArgs e )
		{
			GetProductVersion();
		}


		public void GetProductVersion()
		{
			Assembly a = Assembly.GetExecutingAssembly();
			AssemblyName an = a.GetName();

			this.appVersion = an.Version.ToString();
			this.appName    = an.Name;
		}

	}
}
