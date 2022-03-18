using System;

public class AWSBroker : Singleton<AWSBroker>
{
    public static event Action<ResourceSO> AWS_OnCreateResourceEvent;
    public static void Call_AWS_OnCreateResourceEvent(ResourceSO resource)
    {
        AWS_OnCreateResourceEvent?.Invoke(resource);
    }
}
