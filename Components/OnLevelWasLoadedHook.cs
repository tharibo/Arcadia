using UnityEngine;
using clojure.lang;

public class OnLevelWasLoadedHook : ArcadiaBehaviour   
{
  public void OnLevelWasLoaded(System.Int32 a)
  {
      var _go = gameObject;
      foreach (var fn in fns)
        fn.invoke(_go, a);
  }
}