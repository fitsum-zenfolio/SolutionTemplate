﻿using DPL.Template.Accessors.Shared;
using DPL.Template.Common.Contracts;
using DPL.Template.Common.Shared;
using DPL.Template.Utilities;

namespace DPL.Template.Accessors
{
    public class AccessorFactory : FactoryBase
    {
        private UtilityFactory _utilityFactory;

        public AccessorFactory(AmbientContext context, UtilityFactory utilityFactory) : base(context)
        {
            // NOTE: this is here to ensure the factories from the Manager are propogated down to the other factories 
            _utilityFactory = utilityFactory ?? new UtilityFactory(Context);

            //AddType<IShippingRulesAccessor>(typeof(ShippingRulesAccessor));
        }

        public T CreateAccessor<T>() where T : class
        {
            return CreateAccessor<T>(null);
        }
        public T CreateAccessor<T>(UtilityFactory utilityFactory) where T : class
        {
            _utilityFactory = utilityFactory ?? _utilityFactory;

            T result = base.GetInstanceForType<T>();

            // Configure the context if the result is not a mock
            if (result is AccessorBase)
            {
                (result as AccessorBase).Context = Context;
                (result as AccessorBase).UtilityFactory = _utilityFactory;
            }

            return result;
        }
    }
}
