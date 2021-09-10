using Xunit;

namespace Lncodes.DesignPattern.Strategy.Test
{
    public sealed class StrategyTest
    {
        [Theory]
        [ClassData(typeof(StrategyTheoryData))]
        public void Companion_HearthPoint_ShouldEqual(Companion companion, uint expected)
        {
            var playerController = new PlayerController();
            playerController.SetCompanion(companion);
            playerController.GiveGiftCompanion();
            playerController.PetCompanion();

            var actual = playerController.GetCompanionHearthPoint();

            Assert.Equal(expected, actual);
        }
    }
}
