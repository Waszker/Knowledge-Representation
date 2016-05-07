using KR.Main.Engine;

namespace KR.Main.Entities
{
    public abstract class Query
    {
        public abstract bool Evaluate(World world);
    }
}
