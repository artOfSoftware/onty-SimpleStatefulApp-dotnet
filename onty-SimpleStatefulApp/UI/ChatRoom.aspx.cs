using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TrySimpleWebapp01
{
	public partial class ChatRoom : System.Web.UI.Page
	{

		private static Utils.Conversation conv = new Utils.Conversation();

		protected void Page_Load( object sender, EventArgs e )
		{
			// if we already know user's name, then we should use it
			if ( Request.RequestType == "GET" && Session["username"] != null )
				textUserName.Text = Session["username"].ToString();

			GenerateConvTable();
		}

		protected void buttonUserSaysClick_Click( object sender, EventArgs e )
		{
			string name = textUserName.Text;
			string text = textUserSays.Text;

			// add new message to db
			conv.Add( name, text );

			// store user's name in the session or cookie
			Session["username"] = name;


			GenerateConvTable();
		}


		protected void buttonRefresh_Click( object sender, EventArgs e )
		{
			//Response.Redirect( "~/UI/ChatRoom.aspx", true );
			GenerateConvTable();
		}

		protected void buttonClear_Click( object sender, EventArgs e )
		{
			conv.Clear();
			//Response.Redirect( "~/UI/ChatRoom.aspx", true );
			GenerateConvTable();
		}


		public void GenerateConvTable()
		{
			tableConvHist.Rows.Clear();
			int count = 0;
			foreach ( var item in conv.GetAllItems() )
			{
				TableRow row = makeTableRow(
					"item #" + ( ++count ), item.label, item.text );
				int id = tableConvHist.Rows.Add( row );
			}
		}


		private TableRow makeTableRow( string label1, string label2, string text )
		{
			TableRow row = new TableRow();
			TableCell cell1 = new TableCell();
			TableCell cell2 = new TableCell();
			TableCell cell3 = new TableCell();
			
			cell1.Text = label1;
			cell2.Text = label2;
			cell3.Text = text;

			cell1.CssClass = "convCell";
			cell2.CssClass = "convCell";
			cell3.CssClass = "convCell";

			row.Cells.Add( cell1 );
			row.Cells.Add( cell2 );
			row.Cells.Add( cell3 );

			return row;
		}

	}
}
