using System;

namespace ShopDx3.SharedKernel
{
    public abstract class Entity
    {
        /// <summary>
        /// unique id for entity
        /// </summary>
        public Guid Id { get; set; }
    }
}
