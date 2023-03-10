using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Status : IEntity
	{
		public int StatusId { get; set; }
		public int AssetId { get; set; }
		public string StatusName { get; set; }
		public string StatusIcon { get; set; }
		public int Priority { get; set; }
		public bool Visible { get; set; }
	}
}

