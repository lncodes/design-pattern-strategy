namespace Lncodes.DesignPattern.Strategy
{
    public sealed class BearCompanion : Companion
    {
        public override uint HearthPoint { get; protected set; }

        /// <inheritdoc cref="Companion.Pet"/>
        public override void Pet() =>
            HearthPoint += 3;

        /// <inheritdoc cref="Companion.TakeGift"/>
        public override void TakeGift() =>
            HearthPoint += 10;
    }
}