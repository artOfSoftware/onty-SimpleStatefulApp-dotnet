using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onTy.SimpleStatefulApp.Utils
{
	public class Conversation
	{

		private List<Item> conv;


		public Conversation()
		{
			conv = new List<Item>();
		}

		public void Add( string label, string text )
		{
			conv.Add( new Item(label,text) );
		}

		public void Clear()
		{
			this.conv.Clear();
		}

		public int Count
		{
			get
			{
				return this.conv.Count();
			}
		}

		public IEnumerable<Item> GetAllItems()
		{
			return conv.ToList();
		}



		public class Item
		{
			public string label { get; set; }
			public string text { get; set; }

			public Item( string l, string t )
			{
				this.label = l;
				this.text = t;
			}
		}

	}
}