﻿namespace SIM.Pipelines.Processors
{
  using System;
  using System.Collections.Generic;
  using JetBrains.Annotations;

  #region

  #endregion

  public class ProcessorArgs : AbstractArgs
  {
    #region Fields

    private readonly Dictionary<string, object> _Arguments = new Dictionary<string, object>();   

    #endregion

    #region Events

    public event Action OnCompleted;

    #endregion

    #region Indexers

    [CanBeNull]
    public object this[string key]
    {
      get
      {
        return _Arguments[key];
      }

      set
      {
        _Arguments[key] = value;
      }
    }

    #endregion

    #region Public Methods

    public virtual void Dispose()
    {
    }

    public void FireOnCompleted()
    {
      if (OnCompleted != null)
      {
        OnCompleted();
      }
    }

    #endregion
  }
}