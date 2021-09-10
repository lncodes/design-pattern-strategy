namespace Lncodes.DesignPattern.Strategy
{
    public abstract class Companion
    {
        public abstract uint HearthPoint { get; protected set; }

        /// <summary>
        /// Method to pet companion
        /// </summary>
        public abstract void Pet();

        /// <summary>
        /// Method to take gift from player
        /// </summary>
        public abstract void TakeGift();
    }
}