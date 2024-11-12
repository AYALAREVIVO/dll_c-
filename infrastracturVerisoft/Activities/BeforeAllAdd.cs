using infrastracturVerisoft.Interface;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastracturVerisoft.Activities
{
    public class BeforeAllAdd : System.Activities.CodeActivity
    {

        [RequiredArgument]
        public  InArgument<IBeforeAll> beforeAll { get; set; }

        protected override void Execute(CodeActivityContext contex)
        {
            FrameworkManager.GetInstance().AddBeforeAll(beforeAll.Get(contex));
        }
    }
}
