using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VkBridgeHandler : MonoBehaviour
{
    private VkBridgeController controller;
    private void Start()
    {
        controller = this.GetComponent<VkBridgeController>();
    }
    public void ShowAdsResult(string result)
    {
        var res = new VKWebAppShowNativeAdsResultStruct();
        if(result == "good")
        {
            res.result = true;
        }
        else
        {
            res.result = false;
        }
        controller._actionResultAdsShow.Invoke(res);
    }
    public void StorageGetResult(string result)
    {
        controller._actionStorageGet.Invoke(result);
    }
    public void SubscriptionBoxResult(string res)
    {
        if(res != "error")
        {
            controller._actionSubscriptionBox.Invoke(bool.Parse(res));
        }
        else
        {
            controller._actionSubscriptionBox.Invoke(false);
        }
    }
    public void AccelerometerChanged(string source)
    {
        AccelerometerData data = new AccelerometerData();
        if(source != "error")
        {
            string[] cords = source.Split(' ');
            data.x = float.Parse(cords[0]);
            data.y = float.Parse(cords[1]);
            data.z = float.Parse(cords[2]);
        }
        else
        {
            data.x = 0;
            data.y = 0;
            data.z = 0;
        }
        controller._actionAccelerometerChange.Invoke(data);
    }
    public void SendResult(string JSON)
    {
        controller._actionCustomSend.Invoke(JSON);
    }
}
