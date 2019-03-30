namespace Working_with_Nullable
{
    public abstract class SpecialDefence
    {
        public static SpecialDefence Null { get; } = new NullDefence();

        public abstract int CalculateDamageReduction(int totalDamage);

        public class NullDefence : SpecialDefence
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // no operation /  "do nothing" behavior
            }
        }
    }
}
