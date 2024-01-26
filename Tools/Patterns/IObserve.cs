using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools.Patterns
{
  public interface IObserve
  {
    ISubject Subject{ set; }
  }
}
