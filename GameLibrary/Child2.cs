using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Child2 : ChildBase
    {
        public string stringField = "Hello, World!";

        public override void AbstractMethod()
        {
        }
    }

    public class Child2TypeReader : ContentTypeReader<Child2>
    {
        protected override Child2 Read(ContentReader input, Child2 instance)
        {
            Child2 child = new Child2();

            child.stringField = input.ReadString();

            return child;
        }
    }
}
