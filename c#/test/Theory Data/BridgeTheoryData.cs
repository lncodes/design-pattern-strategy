using Xunit;

namespace Lncodes.DesignPattern.Bridge.Test
{
    public sealed class BridgeTheoryData : TheoryData<Companion, uint>
    {
        public BridgeTheoryData()
        {
            Add(new DogCompanion(), 21);
            Add(new BearCompanion(), 13);
            Add(new CrocodileCompanion(), 7);
        }
    }
}
