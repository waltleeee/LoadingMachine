
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    public LoadingMachineManager LoadingMachineManager;
   
    public void OnWindowLoadingOpen()
    {
        LoadingMachineManager.OpenWindowLoading("SAMPLE TEST");
    }

    public void OnFullScreenLoadingOpen()
    {
        LoadingMachineManager.OpenFullScreenLoading();
    }

    public void OnLoadingOff()
    {
        LoadingMachineManager.OffLoading();
    }


}
