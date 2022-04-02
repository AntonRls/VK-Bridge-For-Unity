public struct VKWebAppShowNativeAdsStruct
{
    /// <summary>
    /// ������ �������
    /// </summary>
    public AdFormat ad_format { get; set; }
    /// <summary>
    /// ������ ��� ad_format = reward. ������������ �� �������� ������ interstitial ������� � ������ ���������� rewarded video
    /// </summary>
    public bool? use_waterfall { get; set; }
}
public struct VKWebAppShowNativeAdsResultStruct
{
    /// <summary>
    /// ���� �� �������� ������� ������������.
    /// </summary>
    public bool result { get; set; }
}
/// <summary>
/// ������� ������� ��� ������ VKWebAppShowNativeAds
/// </summary>
public enum AdFormat
{
    interstitial,
    reward
}