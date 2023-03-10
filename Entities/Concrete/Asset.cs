using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Asset : IEntity
	{
		public int AssetId { get; set; }
		public string AssetName { get; set; }
		public string AssetIcon { get; set; }
	}
}

