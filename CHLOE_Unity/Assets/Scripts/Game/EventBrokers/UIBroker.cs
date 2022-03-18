using System;

public class UIBroker : Singleton<UIBroker>
{
    #region Button Events
    public static event Action Button_Selected;
    public static void Call_Button_Selected()
    {
        Button_Selected?.Invoke();
    }
    #endregion
}
