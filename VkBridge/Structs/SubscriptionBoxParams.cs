public struct SubscriptionBoxParamsAction
{
    public SubscriptionBoxAction subscriptionAction { get; set; }
    /// <summary>
    /// ������������� ����������� ��������, ������� ������������� �� ��������. �������� ���������� ����������, ����� ������� (create) ��������.
    /// </summary>
    public string item { get; set; }
    /// <summary>
    /// ������������� ��������.  �������� ���������� ����������, ����� ����������� (resume)  ��� �������� (cancel) ��������.
    /// </summary>
    public string subscription_id { get; set; }
    
}

public enum SubscriptionBoxAction
{
    create,
    resume,
    cancel
}