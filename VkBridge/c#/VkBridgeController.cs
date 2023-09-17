using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class VkBridgeController : MonoBehaviour
{
    /// <summary>
    /// Инициализировать VK Bridge.
    /// </summary>
    [DllImport("__Internal")] public static extern void _VKWebAppInit();
    /// <summary>
    ///  показывает полноэкранную рекламу пользователю.
    /// </summary>
    [DllImport("__Internal")] public static extern void _VKWebAppShowNativeAds(string adFormat, bool waterfall);
  


    [DllImport("__Internal")]
    public static extern void _VKWebAppShowWallPostBox(string text);

    [DllImport("__Internal")]
    public static extern void _VKWebAppStorageSet(string key, string value);
    [DllImport("__Internal")]
    public static extern void _VKWebAppStorageGet(string key);
    [DllImport("__Internal")]
    public static extern void _VKWebAppShowLeaderBoardBox(string value);

    [DllImport("__Internal")]
    public static extern void _VKWebAppShowInviteBox();
    [DllImport("__Internal")]
    public static extern void _VKWebAppShowSubscriptionBox(string action, string item, string subscription_id);
    [DllImport("__Internal")]
    public static extern void _VKWebAppAccelerometerStart(int refresh_rate);
    [DllImport("__Internal")]
    public static extern void _VKWebAppAccelerometerStop();

    [DllImport("__Internal")]
    public static extern void getInfoUser(string gameObject, string method);


    [DllImport("__Internal")]
    public static extern void consoleLoge(string value);
    [DllImport("__Internal")]
    public static extern void _Send(string name, string Params);




    /// <summary>
    /// Инициализировать VK Bridge.
    /// </summary>
    public void VKWebAppInit()
    {
#if !UNITY_EDITOR
        _VKWebAppInit();
#endif
    }

    //ads--

    /// <summary>
    /// Показывает полноэкранную рекламу пользователю.
    /// </summary>
    /// <param name="paramsAd">Параметры. См. https://dev.vk.com/bridge/VKWebAppShowNativeAds </param>
    /// <param name="action">Метод, в который будет передан результат просмотра рекламы </param>
    public void VKWebAppShowNativeAds(VKWebAppShowNativeAdsStruct paramsAd, UnityAction<VKWebAppShowNativeAdsResultStruct> actionResult)
    {
#if !UNITY_EDITOR
        _actionResultAdsShow = actionResult;
        if (paramsAd.use_waterfall != null)
        {
            _VKWebAppShowNativeAds(Enum.GetName(typeof(AdFormat), paramsAd.ad_format), bool.Parse(paramsAd.use_waterfall.ToString()));
        }
        else
        {
            _VKWebAppShowNativeAds(Enum.GetName(typeof(AdFormat), paramsAd.ad_format), false);
        }
#endif
    }
    public UnityAction<VKWebAppShowNativeAdsResultStruct> _actionResultAdsShow;
    //----

    //-- Общие события

    /// <summary>
    /// Создаёт пост на стене пользователя
    /// </summary>
    /// <param name="text">Текст поста</param>
    public void VKWebAppShowWallPostBox(string text)
    {
#if !UNITY_EDITOR
        _VKWebAppShowWallPostBox(text);
#endif
    }

    //--

    //-- Секция Storage

    /// <summary>
    /// Задаёт значение переменной, название которой передано в параметре key.  Срок жизни ключа — 1 год.
    /// </summary>
    /// <param name="key">Ключ</param>
    /// <param name="value">Значение</param>
    public void VKWebAppStorageSet(string key, string value)
    {
#if !UNITY_EDITOR
        _VKWebAppStorageSet(key, value);
#endif
    }
    /// <summary>
    /// Возвращает значение переменной, заданной методом VKWebAppStorageSet. 
    /// </summary>
    /// <param name="key">Ключ</param>
    /// <param name="action">Метод, в который будет передано значение переменной</param>
    public void VKWebAppStorageGet(string key, UnityAction<string> action)
    {
#if !UNITY_EDITOR
        // TODO : Вместо стринга сделать отдельную структуру, в которой будет отслеживаться ошибка
        _actionStorageGet = action;
        _VKWebAppStorageGet(key);
#endif
    }
    public UnityAction<string> _actionStorageGet;

    //---
    //-- Данные датчиков

    /// <summary>
    /// позволяет приложению получать данные акселерометра, установленного в мобильном устройстве.
    /// </summary>
    /// <param name="refresh_rate">Период обновления данных акселерометра в миллисекундах. Минимальное значение — 20 мс, максимальное — 1000 мс, значение по умолчанию — 1000 мс.</param>
    /// <param name="action">Метод, в который будет передаваться параметры акселерометра</param>
    public void VKWebAppAccelerometerStart(int refresh_rate, UnityAction<AccelerometerData> action)
    {
#if !UNITY_EDITOR
        _actionAccelerometerChange = action;
        _VKWebAppAccelerometerStart(refresh_rate);
#endif
    }
    public UnityAction<AccelerometerData> _actionAccelerometerChange;

    /// <summary>
    /// прекращает отслеживание данных акселерометра.
    /// </summary>
    public void VKWebAppAccelerometerStop()
    {
#if !UNITY_EDITOR
        _VKWebAppAccelerometerStop();
#endif
    }

    //--
    //-- Игры

    /// <summary>
    /// Открывает окно с таблицей результатов.
    /// </summary>
    /// <param name="value">Результат пользователя</param>
    public void VKWebAppShowLeaderBoardBox(int value)
    {
#if !UNITY_EDITOR
        _VKWebAppShowLeaderBoardBox(value.ToString());
#endif
    }
    /// <summary>
    /// Открывает окно приглашения друзей в игру.
    /// </summary>
    public void VKWebAppShowInviteBox()
    {
#if !UNITY_EDITOR
        _VKWebAppShowInviteBox();
#endif
    }
    /// <summary>
    /// позволяет показать диалоговое окно подписки. Подписка — это регулярные списания голосов со счёта пользователя на счёт игры.
    /// </summary>
    /// <param name="action">Метод, в который будет передан результат (true/false)</param>
    /// <param name="actionSubscript">Параметры. См. https://dev.vk.com/bridge/VKWebAppShowSubscriptionBox </param>
    public void VKWebAppShowSubscriptionBox(SubscriptionBoxParamsAction actionSubscript, UnityAction<bool> action)
    {
#if !UNITY_EDITOR
        _actionSubscriptionBox = action;
        if (actionSubscript.subscription_id != null)
        {
            _VKWebAppShowSubscriptionBox(Enum.GetName(typeof(SubscriptionBoxAction), actionSubscript.subscriptionAction), null, actionSubscript.subscription_id);
        }
        else
        {
            _VKWebAppShowSubscriptionBox(Enum.GetName(typeof(SubscriptionBoxAction), actionSubscript.subscriptionAction), actionSubscript.item, null);
        }
#endif
    }
    public UnityAction<bool> _actionSubscriptionBox;
    //--

    /// <summary>
    /// Вызвать метод VK Bridge
    /// </summary>
    /// <param name="Name">Название метода</param>
    /// <param name="Params">Параметры. Укажите null, если их нет</param>
    /// <param name="Action">Метод, в который будет передан JSON, возвращаемый VK</param>
    public void Send(string Name, Dictionary<string, string> Params, UnityAction<string> Action)
    {
#if !UNITY_EDITOR
        _actionCustomSend = Action;
        if (Params != null)
        {
            ParamsStruct paramsStruct = new ParamsStruct();
            paramsStruct.Key = new string[Params.Count];
            paramsStruct.Body = new string[Params.Count];

            int Count = 0;
            foreach (KeyValuePair<string, string> Param in Params)
            {
                paramsStruct.Key[Count] = Param.Key;
                paramsStruct.Body[Count] = Param.Value;
                Count++;
            }
            _Send(Name, JsonUtility.ToJson(paramsStruct));
        }
        else
        {
            _Send(Name, "none");
        }
#endif
    }
    public UnityAction<string> _actionCustomSend;
}
