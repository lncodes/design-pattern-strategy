using Xunit;

namespace Lncodes.DesignPattern.Strategy.Test
{
    public sealed class StrategyTheoryData : TheoryData<Companion, uint>
    {
        public StrategyTheoryData()
        {
            Add(new DogCompanion(), 21);
            Add(new BearCompanion(), 13);
            Add(new CrocodileCompanion(), 7);
        }
    }
}