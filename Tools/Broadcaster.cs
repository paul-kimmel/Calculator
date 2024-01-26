using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
  public static class Broadcaster
  {
    private static List<IListener> listeners = new List<IListener>();

    public static void Broadcast(string message)
    {
      foreach(IListener listener in listeners)
        listener.Listen(message);
    }

    public static void Broadcast(string mask, params object[] args)
    {
      Broadcast(string.Format(mask, args));
    }
    
    public static void AddListener(IListener listener)
    {
      if(listeners.Contains(listener) == false)
        listeners.Add(listener);
    }

    public static void RemoveListener(IListener listener)
    {
      if(listeners.Contains(listener))
        listeners.Remove(listener);
    }
  }
}