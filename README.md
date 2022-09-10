# VK-Bridge-For-Unity
Неофициальный SDK VK Bridge для Unity

## Использование
Для того, чтобы обращаться к методам VK Bridge вам необходимо перенести префаб объект **VkBridge** на сцену, его можно найти по пути: **VkBridge/Prefab** в проекте.<br>
Далее в скрипте, из которого будут вызываться методы VK Bridge, вы должны указать переменную с типом ```VkBridgeController```:<br>
```
public VkBridgeController bridge;
```
После объявления переменной, в инспекторе, на объекте где у вас висит скрипт с объявленной переменой, у вас появится соответсвенное поле, в него вы должны перетащить объект **VkBridge**, который переносили на сцену.<br>
Так-же в настройках билда, в **Resolution and Presentation -> WebGl Template**, необходимо выбрать **Responsive**. Это специальный шаблон, в котором содержится вспомогательный код для работы библиотеки.<br><br>
Теперь вы можете обращаться к методам VK Bridge! Например, выполним метод <a href="https://dev.vk.com/bridge/VKWebAppInit">инициализации VK Bridge</a>:<br>
```
bridge.VKWebAppInit();
```
<a href="https://github.com/AntonRls/VK-Bridge-For-Unity/blob/main/Examples.md">Примеры использования SDK</a>
## Доступные методы
Библиотека всё ещё дорабатывется, на данный момент в ней доступны следующие методы:<br>
<ul>
  <li>VKWebAppInit
  <li>VKWebAppShowNativeAds
  <li>VKWebAppShowWallPostBox
  <li>VKWebAppStorageSet
  <li>VKWebAppStorageGet
  <li>VKWebAppShowLeaderBoardBox
  <li>VKWebAppShowInviteBox
  <li>VKWebAppShowSubscriptionBox
  <li>VKWebAppAccelerometerStart
  <li>VKWebAppAccelerometerStop
</ul>
<br>
Ещё реализован метод Send, аналог метода bridge.send в VK Bridge. Через него вы можете вызвать абсолютно любое событие VK Bridge. Подробнее смотрите в примерах
