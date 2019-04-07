
using UnityEngine;

public class LoadingMachineManager : MonoBehaviour
{

    public LoadingMachineDisplay LoadingMachineDisplay;
    private int loadingType = 0;//0:window loading  1:fullScreen loading
    private bool isLoading = false;
    private bool isCanOffLoading = false;
    private bool isShowLog = true;

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
    }

    public void OffLoading()
    {
        if (!isLoading || !isCanOffLoading)
        {
            if (isShowLog)
                Debug.Log("CAN OFF LOADING");
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
    }


}
