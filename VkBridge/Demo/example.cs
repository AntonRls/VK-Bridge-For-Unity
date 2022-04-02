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
        //������������� vk bridge
        bridge.VKWebAppInit();
    }
    //������ ������������ �������������
    public void startAccelelometer()
    {
        bridge.VKWebAppAccelerometerStart(20, result);
    }
    //����������� ������������ �������������
    public void stopAccelelometer()
    {
        bridge.VKWebAppAccelerometerStop();
    }


    public void result(AccelerometerData data)
    {
        text.text = $"x: {data.x.ToString()} y:{data.y.ToString()} z:{data.z.ToString()}";
    }
}
