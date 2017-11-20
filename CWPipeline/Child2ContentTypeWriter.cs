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
    public class Child2ContentTypeWriter : ContentTypeWriter<Child2>
    {
        protected override void Write(ContentWriter output, Child2 value)
        {
            output.Write(value.stringField);
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return typeof(Child2).AssemblyQualifiedName;
        }

    }
}
