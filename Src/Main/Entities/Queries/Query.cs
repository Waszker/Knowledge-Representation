using KR.Main.Engine;

namespace KR.Main.Entities
{
    abstract class Query
    {
        public abstract bool Evaluate(World world);
    }
}
