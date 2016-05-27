using System;
using System.Text;

namespace KR.Main.Entities.Conditions
{
    public class Conjunction : ICondition
    {
        private readonly ICondition[] _components;
        
        public Conjunction(params ICondition[] cond)
        {
            if (cond.Length < 1)
                throw new ArgumentException();

            _components = cond;
        }

        public bool Check(State state)
        {
            foreach (var component in _components)
            {
                if (!component.Check(state))
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(_components[0].ToString());
            for (int i = 1; i < _components.Length; i++)
            {
                builder.Append(" ^ ");
                builder.Append(_components[i].ToString());
            }
            return builder.ToString();
        }
    }
}
