namespace Lncodes.DesignPattern.Bridge
{
    public sealed class CrocodileCompanion : Companion
    {
        public override uint HearthPoint { get; protected set; }

        /// <inheritdoc cref="Companion.Pet"/>
        public override void Pet() =>
            HearthPoint += 2;

        /// <inheritdoc cref="Companion.TakeGift"/>
        public override void TakeGift() =>
            HearthPoint += 5;
    }
}
