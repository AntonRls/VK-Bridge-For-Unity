var plugin = {
    _VKWebAppInit: function()
    {
        initBridge();
    },
    _VKWebAppShowNativeAds: function(adFormat, waterfall)
    {
        showAd(Pointer_stringify(adFormat), waterfall);
    },
    _VKWebAppShowWallPostBox: function(text)
    {
        sendPost(Pointer_stringify(text));
    },
    _VKWebAppStorageSet: function(key, value)
    {
        storageSet(Pointer_stringify(key), Pointer_stringify(value));
    },
    _VKWebAppStorageGet: function(key)
    {
        storageGet(Pointer_stringify(key));
    },
    _VKWebAppShowLeaderBoardBox: function(value)
    {
        ShowLeaderBoardBox(Pointer_stringify(value));
    },
    getInfoUser: function(gameObject, method)
    {
        GetInfoUser(Pointer_stringify(gameObject),Pointer_stringify(method));
    },
    consoleLoge: function(value)
    {
        console.log(Pointer_stringify(value));
    },
    _VKWebAppShowInviteBox: function()
    {
        inviteFriend();
    },
    _VKWebAppShowSubscriptionBox: function(action, item, subscription_id)
    {
        ShowSubscriptionBox(Pointer_stringify(action), Pointer_stringify(item), Pointer_stringify(subscription_id));
    },
    _VKWebAppAccelerometerStart: function(refresh_rate)
    {
        AccelerometerStart(refresh_rate);
    },
    _VKWebAppAccelerometerStop: function()
    {
        AccelerometerStop();
    },
    _Send: function(name, Params)
    {
        CustomSend(Pointer_stringify(name), Pointer_stringify(Params));
    }
};

mergeInto(LibraryManager.library, plugin);
