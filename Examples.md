## Вызываем рекламу с вознаграждением и получаем результат просмотра

```
   public VkBridgeController bridge;
    public void ShowAdsReward()
    {
        bridge.VKWebAppShowNativeAds(new VKWebAppShowNativeAdsStruct
        {
            ad_format = AdFormat.reward
        }, AdsResult);
        
    }
    public void AdsResult(VKWebAppShowNativeAdsResultStruct result)
    {
        //в этот метод получим результат просмотра рекламы
        var adsIsShow = result.result;
    }
```
## Работа с секцией Storage
```
public VkBridgeController bridge;
    public const string KEY_RESULTS = "score";
    public void SaveResults(string results)
    {
        //сохраняем 
        bridge.VKWebAppStorageSet(KEY_RESULTS, results);
    }
    public void GetResults()
    {
        //получаем сохранёные данные
        bridge.VKWebAppStorageGet(KEY_RESULTS, ResultStorageGet);
    }
    public void ResultStorageGet(string value)
    {
        //в этот метод получим сохранённые данные
    }
 ```
 ## Показываем диалоговое окно подписки
 ```
   public VkBridgeController bridge;
    public void SubscriptionBox()
    {
        bridge.VKWebAppShowSubscriptionBox(new SubscriptionBoxParamsAction
        {
            item = "Монета",
            subscriptionAction = SubscriptionBoxAction.create,
            subscription_id = "1"
        }, (bool isSubscribed) =>
            {
                if (isSubscribed)
                {
                    //подписался
                }
                else
                {
                    //закрыл окно
                }
            }
        );
    }
 ```
