﻿namespace SIM.Tool.Base.Wizards
{
  using System;

  #region

  #endregion

  public class WizardPipeline
  {
    #region Fields

    public Type Args { get; }
    public string CancelButtonText { get; }

    public readonly FinishActionHive[] _FinishActionHives;

    public readonly FinishAction[] _FinishActions;

    public string FinishText { get; }

    public string StartButtonText { get; }

    public readonly StepInfo[] _StepInfos;

    public string Title { get; }

    private string name { get; }

    #endregion

    #region Constructors

    public WizardPipeline(string name, string title, StepInfo[] stepInfos, Type args, string startButtonText, string cancelButtonText, string finishText, FinishAction[] finishActions, FinishActionHive[] finishActionHives)
    {
      this.name = name;
      Title = title;
      FinishText = finishText;
      StartButtonText = startButtonText;
      CancelButtonText = cancelButtonText;
      Args = args;
      _StepInfos = stepInfos;
      _FinishActions = finishActions;
      _FinishActionHives = finishActionHives;
    }

    #endregion

    #region Properties

    public string Name
    {
      get
      {
        return name;
      }
    }

    #endregion
  }
}