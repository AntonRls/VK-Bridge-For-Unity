using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class example : MonoBehaviour
{
    //VkBridge 
    public VkBridgeController bridge;
    public Text text;
    public InputField textView;
    void Start()
    {

        //Инициализация vk bridge
        bridge.VKWebAppInit();
    }
    public void SendCustom()
    {
        bridge.Send("VKWebAppJoinGroup", new Dictionary<string, string> { { "group_id", "1" } }, ResultCustomSend);
    }
    public void ResultCustomSend(string json)
    {
        textView.text = json;
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
