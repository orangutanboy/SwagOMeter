using Swagometer.Lib.Collections;
using Swagometer.Lib.Interfaces;
using System.Collections.Generic;

namespace Swagometer.Lib.Data
{
    public class SwagSource : ThingSource<SwagBase>, ISwagSource
    {
        public SwagSource(IDisplayErrorMessages displayErrorMessage) : base(displayErrorMessage, "Swag") { }

        protected override IList<SwagBase> LoadThings(string thingLocation)
        {
            return SwagCollection.Load(thingLocation);
        }

        protected override IThingCollection<SwagBase> GetCollection()
        {
            return SwagCollection.Create();
        }
    }
}
