using System;
using System.Collections.ObjectModel;

namespace Meteor
{
	public class CollectionCollection : KeyedCollection<string, ICollection>
	{
		public CollectionCollection ()
		{
		}

		protected override string GetKeyForItem (ICollection item)
		{
			return item.Name;
		}
	}
}

