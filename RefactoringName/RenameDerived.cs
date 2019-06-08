using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringName
{
    public class RenameDerived : RenameBase, IRenameBase
    {
        public new void Method()
        { }
        public override void Method(int i)
        { }

    }
}
