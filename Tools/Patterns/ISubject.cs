using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools.Patterns
{
  public interface ISubject
  {
    event EventHandler ExpressionChanged;
    event EventHandler TextChanged;
    event EventHandler HistoryChanged;
    string CurrentText{ get; }
    string CurrentExpression{ get; }
  }
}
