namespace KR.Main.Entities.Conditions
{
    interface ICondition
    {
        bool Check(State state);
    }
}
