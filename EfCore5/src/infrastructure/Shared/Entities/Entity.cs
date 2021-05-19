using System;

namespace Shared.Entities
{
	public abstract class Entity
	{
		public Guid Id { get; set; }
		public Entity()
		{
			Id = Guid.NewGuid();
		}
	}
}