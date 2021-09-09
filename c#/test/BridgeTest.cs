using Xunit;

namespace Lncodes.DesignPattern.Bridge.Test
{
    public sealed class BridgeTest
    {
        [Theory]
        [ClassData(typeof(BridgeTheoryData))]
        public void Companion_HearthPoint_ShouldEqual(Companion companion, uint expected)
        {
            var playerController = new PlayerController(companion);
            playerController.GiveGiftCompanion();
            playerController.PetCompanion();

            var actual = playerController.GetCompanionHearthPoint();

            Assert.Equal(expected, actual);
        }
    }
}
