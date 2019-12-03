using System;
using System.Collections.Generic;

namespace Workflow
{
    public interface IActivity
    {
        void Execute(List<object> acts);
    }
}
