using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace Tools
{
  public static class MetaDumper
  {

    public static void StatementTrace(IEnumerable list)
    {
      StackTrace trace = new StackTrace();
      StackFrame frame = trace.GetFrame(2);

      string content = GetArrayValues(list, "{0}, {1}");
      StatementTrace(frame, content);
    }

    public static void StatementTrace(string mask, params object[] args)
    {
      StatementTrace(new StackTrace().GetFrame(2), string.Format(mask, args));
    }

    public static void StatementTrace(string content)
    {
      StatementTrace(new StackTrace().GetFrame(2), content);
    }

    public static void StatementTrace(ValueType content)
    {
      StatementTrace(new StackTrace().GetFrame(2), content.ToString());
    }

    private static void StatementTrace(StackFrame frame, string content)
    {
      string mask = "File: {0}, Method: {1}, Line: {2}, Data: {3}";

      string filename = frame.GetFileName();
      string method = frame.GetMethod().Name;
      int line = frame.GetFileLineNumber();

      Trace.WriteLine(string.Format(mask, filename, method, line, content));
    }

  
    public static void CallTrace(IEnumerable list)
    {
      Trace.Write(string.Format("{0}(", new StackTrace().GetFrame(2).GetMethod().Name));

      Trace.Write(String.Format("{0}", GetArrayValues(list, "{0}, {1}")));
      
      Trace.Write(")\r\n");
    }

    public static void CallTrace(string content)
    {
      Trace.WriteLine(string.Format("{0}({1})", new StackTrace().GetFrame(2).GetMethod().Name, content));
    }

    public static void CallTrace(ValueType content)
    {
      Trace.WriteLine(string.Format("{0}({1})", new StackTrace().GetFrame(2).GetMethod().Name, content));
    }

    private static string GetState(this IEnumerable list)
    {
      StringBuilder builder = new StringBuilder();
      foreach(object o in list)
        builder.Append(o.GetState());

      return builder.ToString();
    }


    private static string GetState(this object o)
    {
      StringBuilder builder = new StringBuilder();

      PropertyInfo[] infos = o.GetType().GetProperties();
      foreach (PropertyInfo info in infos)
      {
        object value = info.GetValue(o, null);
        if (value != null && value.GetType().IsArray)
          value = GetArrayValues((Array)value, "{0:x}, {1:x}");

        builder.AppendFormat(string.Format("{0}: {1},", info.Name, value ?? "unk"));
      }
      return builder.ToString();

    }

    public static void Dump(this IEnumerable list, TextWriter writer)
    {
      writer.Write(list.GetState());
    }

    
    public static void Dump(this object o, TextWriter writer)
    {
      writer.Write(o.GetState());
    }

    public static string GetArrayValues(IEnumerable value, string mask)
    {
      if (value == null) return "empty";

      try
      {
        return (string)(from object v in value
                      select v.ToString()).Aggregate((s, t) => string.Format(mask, s, t));
      }
      catch
      {
        return"empty";
      }

    }
  }
}
