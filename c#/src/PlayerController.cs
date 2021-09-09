namespace Lncodes.DesignPattern.Bridge
{
    public sealed class PlayerController
    {
        private readonly Companion _companion = default;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="companion"></param>
        public PlayerController(Companion companion) =>
            _companion = companion;

        /// <summary>
        /// Method to pet the companion
        /// </summary>
        public void PetCompanion() =>
            _companion.Pet();

        /// <summary>
        /// Method to give gift to the companion
        /// </summary>
        public void GiveGiftCompanion() =>
            _companion.TakeGift();

        /// <summary>
        /// Method to get companion hearth point
        /// </summary>
        public uint GetCompanionHearthPoint() =>
            _companion.HearthPoint;
    }
}