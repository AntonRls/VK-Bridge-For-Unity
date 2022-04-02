public struct VKWebAppShowNativeAdsStruct
{
    /// <summary>
    /// Формат рекламы
    /// </summary>
    public AdFormat ad_format { get; set; }
    /// <summary>
    /// Только для ad_format = reward. Использовать ли механизм показа interstitial рекламы в случае отсутствия rewarded video
    /// </summary>
    public bool? use_waterfall { get; set; }
}
public struct VKWebAppShowNativeAdsResultStruct
{
    /// <summary>
    /// Была ли показана реклама пользователю.
    /// </summary>
    public bool result { get; set; }
}
/// <summary>
/// Форматы рекламы для метода VKWebAppShowNativeAds
/// </summary>
public enum AdFormat
{
    interstitial,
    reward
}