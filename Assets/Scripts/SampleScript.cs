using System;
using UnityEngine;
using UnityEngine.UI;

public class SampleScript : MonoBehaviour
{
    public Text SwitchButtonText;
    public LoadingMachineManager LoadingMachineManager;
    private bool isNeedCallback=false;
    private delegate void testFunction();
   

    public void OnSwitchCallback()
    {
        isNeedCallback = !isNeedCallback;
        if(isNeedCallback)
            SwitchButtonText.text="CallBack:ON";
        else
            SwitchButtonText.text = "CallBack:OFF";
    }

    public void OnWindowLoadingOpen()
    {
        if(isNeedCallback)
        {
            testFunction callback = delegate()
            {
                Debug.Log("OPEN FINISH OK");
            };

            LoadingMachineManager.SetOpenFinishCallback(callback);
        }

        LoadingMachineManager.OpenWindowLoading("SAMPLE TEST");
    }

    public void OnFullScreenLoadingOpen()
    {
        if (isNeedCallback)
        {
            testFunction callback = delegate ()
            {
                Debug.Log("OPEN FINISH OK");
            };

            LoadingMachineManager.SetOpenFinishCallback(callback);
        }



        LoadingMachineManager.OpenFullScreenLoading();
    }

    public void OnLoadingOff()
    {
        if (isNeedCallback)
        {
            testFunction callback = delegate ()
            {
                Debug.Log("OFF FINISH OK");
            };

            LoadingMachineManager.SetOffFinishCallback(callback);
        }


        LoadingMachineManager.OffLoading();
    }

    public void OnNoEffectFullScreenLoadingOpen()
    {
        if (isNeedCallback)
        {
            testFunction callback = delegate ()
            {
                Debug.Log("OPEN FINISH OK");
            };

            LoadingMachineManager.SetOpenFinishCallback(callback);
        }



        LoadingMachineManager.OpenNoEffectFullScreenLoading();
    }


}
