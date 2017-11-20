using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace GameLibrary
{
    public class Child1 : ChildBase
    {
        public int intField = 2;

        public override void AbstractMethod()
        {
        }
    }

    public class Child1TypeReader : ContentTypeReader<Child1>
    {
        protected override Child1 Read(ContentReader input, Child1 instance)
        {
            Child1 child = new Child1();

            child.intField = input.ReadInt32();

            return child;
        }
    }
}
