using System;
using UnityEngine;

public class LoadingMachineManager : MonoBehaviour
{

    public LoadingMachineDisplay LoadingMachineDisplay;
    private int loadingType = 0;//0:window loading  1:fullScreen loading
    private bool isLoading = false;
    private bool isCanOffLoading = false;
    private bool isShowLog = true;
    private delegate void offLoadingCallback();
   
    private Delegate openFinishCallback;
    private Delegate offFinishCallback;

 
    public void SetOpenFinishCallback(Delegate inCallback)
    {
        if (openFinishCallback == null)
            openFinishCallback = inCallback;
    }

    public void SetOffFinishCallback(Delegate inCallback)
    {
        if (offFinishCallback == null)
            offFinishCallback = inCallback;
    }

    public void OpenWindowLoading(string inText)
    {
        if (isLoading)
        {
            if (isShowLog)
                Debug.Log("ALLREADY LOADING");
            return;
        }

        isLoading = true;
        loadingType = 0;
        LoadingMachineDisplay.OpenWindowLoading(inText);
    }

    public void OpenNoEffectFullScreenLoading()
    {
        if (isLoading)
        {
            if (isShowLog)
                Debug.Log("ALLREADY LOADING");
            return;
        }

        isLoading = true;
        loadingType = 1;
        LoadingMachineDisplay.OpenNoEffectFullScreenLoading();
    }

    public void OpenFullScreenLoading()
    {
        if (isLoading)
        {
            if (isShowLog)
                Debug.Log("ALLREADY LOADING");
            return;
        }

        isLoading = true;
        loadingType = 1;
        LoadingMachineDisplay.OpenFullScreenLoading();
    }

    public void OpenLoadingFinish()
    {
        isCanOffLoading = true;

        if(openFinishCallback!=null)
        {
            openFinishCallback.DynamicInvoke();
            openFinishCallback = null;
        }
    }

    public void OffLoading()
    {
        if (!isLoading || !isCanOffLoading)
        {
            if (isShowLog)
                Debug.Log("CAN NOT OFF LOADING");
            return;
        }

        switch(loadingType)
        {
            case 0:
                LoadingMachineDisplay.OffWindowLoading();
                break;
            case 1:
                LoadingMachineDisplay.OffFullScreenLoading();
                break;
            default:
                break; 
        }
    }

    public void OffLoadingFinish()
    {
        isLoading = false;
        isCanOffLoading = false;

        if (offFinishCallback != null)
        {
            offFinishCallback.DynamicInvoke();
            offFinishCallback = null;
        }
    }


}
