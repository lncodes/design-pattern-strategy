namespace Lncodes.DesignPattern.Bridge
{
    public sealed class DogCompanion : Companion
    {
        public override uint HearthPoint { get; protected set; }

        /// <inheritdoc cref="Companion.Pet"/>
        public override void Pet() =>
            HearthPoint++;

        /// <inheritdoc cref="Companion.TakeGift"/>
        public override void TakeGift() =>
            HearthPoint += 20;
    }
}
