using KR.Main.Engine;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using KR.Main.Entities.Statements;
using KR.Main.GraphLayout;
using System.Collections.Generic;

using System.Windows.Forms;

namespace WorldVisualizer
{
    public partial class Form1 : Form
    {
        protected Fluent cm;
        protected World world;
        protected Fluent cc;
        protected Actor Fred;
        protected Actor Bill;
        protected Action refactor;
        protected Action debug;
        protected Action code;

        private readonly GraphLayout graphLayout = new GraphLayout();

        void DrawGraph()
        {
            graphLayout.Show(World.Instance.GetEdges(), World.Instance.GetInitialStates());
        }
        public Form1()
        {
            InitializeComponent();
            World w = CreateITWorld();
            DrawGraph();
        }

        private Fluent alive = new Fluent("alive"),
                       walking = new Fluent("walking"),
                       loaded = new Fluent("loaded");
        private Action shoot = new Action("SHOOT"),
                       entice = new Action("ENTICE"),
                       load = new Action("LOAD");

        protected World CreateITWorld()
        {
            var world = World.Instance;
            cm = new Fluent("cm");
            code = new Action("Code");
            refactor = new Action("Refactor");
            debug = new Action("Debug");
            cc = new Fluent("cc");
            Fred = new Actor("Fred");
            Bill = new Actor("Bill");
            world.SetActions(new List<Action>() { entice, shoot, load });
            world.SetActors(new List<Actor>() { Bill });
            world.SetFluents(new List<Fluent> { alive, walking, loaded });
            var domain = new Domain();

            var emptyList = new List<Actor>();
            domain.AddInitiallyClause(new Initially(new Conjunction(new Negation(loaded), alive)));
            domain.AddCausesClause(new Causes(load, true, emptyList, loaded));
            domain.AddCausesClause(new Causes(shoot, true, emptyList, new Negation(loaded)));
            domain.AddCausesClause(new Causes(entice, true, emptyList, walking));
            domain.AddTypicallyCausesClause(new TypicallyCauses(shoot, true, emptyList, new Negation(alive), loaded));
            domain.AddAlwaysClause(new Always(new Implication(walking, alive)));
            domain.AddPreservesClause(new Preserves(entice, true, emptyList, alive, null));

            world.SetDomain(domain);
            world.Build();
            return world;
        }
    }
}
