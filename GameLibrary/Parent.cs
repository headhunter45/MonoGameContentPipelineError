using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Parent
    {
        public Parent()
        {
            children = new List<ChildBase>();
        }

        public ChildBase child;
        public List<ChildBase> children;
    }

    public class ParentTypeReader: ContentTypeReader<Parent>
    {
        protected override Parent Read(ContentReader input, Parent instance)
        {
            Parent parent = new Parent();

            parent.child = input.ReadObject<ChildBase>();
            parent.children = input.ReadObject<List<ChildBase>>();

            return parent;
        }
    }
}
