using System;
using DPL.Template.Accessors;
using DPL.Template.Common.Contracts;
using DPL.Template.Common.Shared;
using DPL.Template.Engines;
using DPL.Template.Managers.Shared;
using DPL.Template.Utilities;

namespace DPL.Template.Managers
{
    public class ManagerFactory : FactoryBase
    {
        public ManagerFactory(AmbientContext context) : base(context)
        {
            //AddType<IAdminFulfillmentManager>(typeof(OrderManager));
        }

        public T CreateManager<T>() where T : class
        {
            T result = CreateManager<T>(null, null, null);
            return result;
        }

        public T CreateManager<T>(
            EngineFactory engineFactory, AccessorFactory accessorFactory, UtilityFactory utilityFactory) where T : class
        {
            if (Context == null)
            {
                throw new InvalidOperationException("Context cannot be null");
            }

            utilityFactory ??= new UtilityFactory(Context);
            accessorFactory ??= new AccessorFactory(Context, utilityFactory);
            engineFactory ??= new EngineFactory(Context, accessorFactory, utilityFactory);

            T result = GetInstanceForType<T>();

            if (result is ManagerBase)
            {
                (result as ManagerBase).Context = Context;
                (result as ManagerBase).EngineFactory = engineFactory;
                (result as ManagerBase).AccessorFactory = accessorFactory;
                (result as ManagerBase).UtilityFactory = utilityFactory;
            }
            else
            {
                // mocking of the manager factory is not supported so every result should implement ManagerBase
                throw new InvalidOperationException($"{typeof(T).Name} does not implement ManagerBase");
            }

            return result;
        }
    }
}
