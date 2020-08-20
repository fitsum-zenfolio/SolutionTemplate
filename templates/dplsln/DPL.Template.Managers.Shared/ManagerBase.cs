using DPL.Template.Accessors;
using DPL.Template.Common.Contracts;
using DPL.Template.Common.Shared;
using DPL.Template.Contracts.Client.SmokeTest;
using DPL.Template.Engines;
using DPL.Template.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DPL.Template.Managers.Shared
{
    public abstract class ManagerBase : ServiceContractBase
    {
        public EngineFactory EngineFactory { get; set; }
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        // protected I*Accessor *Accessor => AccessorFactory.CreateAccessor<I*Accessor>();

        // protected I*Engine *Engine=> EngineFactory.CreateEngine<I*Engine>();

        // protected I*Utility *Utility=> UtilityFactory.CreateUtility<I*Utility>();

        protected ManagerBase()
        {

        }

        public override string TestMe(string input)
        {
            List<IServiceContractBase> engines = new List<IServiceContractBase> { };

            List<string> engineResults = new List<string>();

            engines.ForEach(engine => engineResults.Add(engine.TestMe(input)));

            List<IServiceContractBase> accessors = new List<IServiceContractBase>
            {
                //I*Accessor
            };

            List<string> accessorResults = new List<string>();

            accessors.ForEach(accessor => accessorResults.Add(accessor.TestMe(input)));

            List<string> utilityResults = new List<string>();

            List<IServiceContractBase> utilities = new List<IServiceContractBase> { };

            utilities.ForEach(utility => utilityResults.Add(utility.TestMe(input)));

            var result = new SmokeTestResult
            {
                Engines = engineResults.ToArray(),
                Manager = base.TestMe(input),
                Accessors = accessorResults.ToArray(),
                Utilities = utilityResults.ToArray()
            };

            return JsonConvert.SerializeObject(result);
        }
    }
}
