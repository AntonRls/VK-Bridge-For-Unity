using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class example : MonoBehaviour
{
    //VkBridge 
    public VkBridgeController bridge;
    public Text text;
    void Start()
    {
        //Инициализация vk bridge
        bridge.VKWebAppInit();
    }
    //запуск отслеживания акселерометра
    public void startAccelelometer()
    {
        bridge.VKWebAppAccelerometerStart(20, result);
    }
    //прекращение отслеживания акселерометра
    public void stopAccelelometer()
    {
        bridge.VKWebAppAccelerometerStop();
    }


    public void result(AccelerometerData data)
    {
        text.text = $"x: {data.x.ToString()} y:{data.y.ToString()} z:{data.z.ToString()}";
    }
}
