using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;
namespace UIPATHRPA
{
    public class HellowUser: CodeActivity
    {
        [Category("Input")]
        public InArgument<string> Name { get; set; }

        [Category("Out")]
        public OutArgument<string> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {

            string name = Name.Get(context);

            string result = " Hello " + name;
            Result.Set(context, result);
        }

    }
}
