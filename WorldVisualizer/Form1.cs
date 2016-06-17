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
            world.SetActions(new List<Action>() { code, refactor, debug });
            world.SetActors(new List<Actor>() { Fred, Bill });
            world.SetFluents(new List<Fluent> { cc, cm });
            var domain = new Domain();
            domain.AddCausesClause(new Causes(code, false, new List<Actor>() { Bill }, new Negation(cc)));
            domain.AddInitiallyClause(new Initially(new Conjunction(cc, cm)));
            domain.AddReleasesClause(new Releases(code, false, new List<Actor>() { Bill }, cm, cm));
            domain.AddTypicallyCausesClause(new TypicallyCauses(code, false, new List<Actor>() { Fred }, cm, new Negation(cc)));
            domain.AddCausesClause(new Causes(refactor, false, new List<Actor>() { Fred }, cc));
            domain.AddCausesClause(new Causes(debug, true, null, cm));
            domain.AddImpossibleClause(new Impossible(code, false, new List<Actor>() { Fred }, new Negation(cm)));
            world.SetDomain(domain);
            world.Build();
            return world;
        }
    }
}
