public struct SubscriptionBoxParamsAction
{
    public SubscriptionBoxAction subscriptionAction { get; set; }
    /// <summary>
    /// Идентификатор виртуальной ценности, которая приобретается по подписке. Параметр необходимо передавать, чтобы создать (create) подписку.
    /// </summary>
    public string item { get; set; }
    /// <summary>
    /// Идентификатор подписки.  Параметр необходимо передавать, чтобы возобновить (resume)  или отменить (cancel) подписку.
    /// </summary>
    public string subscription_id { get; set; }
    
}

public enum SubscriptionBoxAction
{
    create,
    resume,
    cancel
}