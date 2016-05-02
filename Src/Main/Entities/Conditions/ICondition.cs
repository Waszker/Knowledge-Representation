namespace KR.Main.Entities.Conditions
{
    public interface ICondition
    {
        bool Check(State state);
    }
}
