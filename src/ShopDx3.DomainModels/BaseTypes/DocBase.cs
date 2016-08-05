using System;

namespace ShopDx3.DomainModels.BaseTypes
{
    public abstract class DocBase
    {
        protected DocBase()
        {

        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
