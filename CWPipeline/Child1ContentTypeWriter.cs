using GameLibrary;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace CWPipeline
{
    [ContentTypeWriter]
    public class Child1ContentTypeWriter: ContentTypeWriter<Child1>
    {
        protected override void Write(ContentWriter output, Child1 value)
        {
            output.Write(value.intField);
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return typeof(Child1).AssemblyQualifiedName;
        }
    }
}
