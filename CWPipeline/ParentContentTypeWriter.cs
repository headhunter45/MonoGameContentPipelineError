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
    public class ParentContentTypeWriter: ContentTypeWriter<Parent>
    {
        protected override void Write(ContentWriter output, Parent value)
        {
            output.WriteObject<ChildBase>(value.child);
            output.WriteObject<List<ChildBase>>(value.children);
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return typeof(Parent).AssemblyQualifiedName;
        }
    }
}
