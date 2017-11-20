using GameLibrary;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWPipeline
{
    public static class ChildSerializer
    {
        public static void WriteAbstractChild(ChildBase child, ContentWriter output)
        {
            if(child != null)
            {
                var childType = child.GetType();
                if(childType == typeof(Child1))
                {
                    output.WriteObject<Child1>(child as Child1);
                }
                else if (childType == typeof(Child2))
                {
                    output.WriteObject<Child2>(child as Child2);
                }
                else
                {
                    throw new ArgumentException(String.Format("This object inherits from ChildBase, but is not a subtype recognized by ChildSerializer. \"{0}\"", childType));
                }
            }
            else
            {
                throw new ArgumentException("child cannot be null.");
            }
        }
    }
}
