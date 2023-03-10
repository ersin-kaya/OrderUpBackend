using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Type : IEntity
	{
		public int TypeId { get; set; }
		public int AssetId { get; set; }
		public string TypeName { get; set; }
		public string TypeIcon { get; set; }
		public int Priority { get; set; }
		public bool Visible { get; set; }
	}
}

