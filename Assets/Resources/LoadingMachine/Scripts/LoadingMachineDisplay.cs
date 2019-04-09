
using UnityEngine;
using UnityEngine.UI;

public class LoadingMachineDisplay : MonoBehaviour
{
    public Text LoadingText;
    public Animator WindowLoadingAnimator;
    public Animator FullScrennLoadingAnimator;
    public Animator LoadingBarAnimator;
    public Animator LoadingTextAnimator;
    public GameObject WindowLoadingObject;
    public GameObject FullScreenLoadingObject;
    public GameObject LoadingMachinePanel;

    public LoadingMachineManager LoadingMachineManager;

    private Vector3 openPosition = new Vector3(0,0,0);
    private Vector3 offPosition = new Vector3(8000,-8000,0);


    public void OpenWindowLoading(string inText)
    {
        LoadingText.text = inText;
        LoadingMachinePanel.transform.localPosition = openPosition;
        WindowLoadingObject.transform.localPosition = openPosition;

        WindowLoadingAnimator.Play("OpenWindowLoading");
    }

    public void OpenWindowAnimationFinish()
    {
        LoadingBarAnimator.Play("OpenLoadingBar");
        LoadingMachineManager.OpenLoadingFinish();
    }

    public void OffWindowLoading()
    {
        LoadingBarAnimator.Play("OpenLoadingBarIdle");
        WindowLoadingAnimator.Play("OffWindowLoading");
    }

    public void OffWindowLoadingAnimationFinish()
    {
        WindowLoadingObject.transform.localPosition = offPosition;
        LoadingMachinePanel.transform.localPosition = offPosition;
        LoadingMachineManager.OffLoadingFinish();
    }

    public void OpenFullScreenLoading()
    {
        LoadingMachinePanel.transform.localPosition = openPosition;
        FullScreenLoadingObject.transform.localPosition = openPosition;
        FullScrennLoadingAnimator.Play("OpenFullscreenLoading");
    }

    public void OpenNoEffectFullScreenLoading()
    {
        LoadingMachinePanel.transform.localPosition = openPosition;
        FullScreenLoadingObject.transform.localPosition = openPosition;
        FullScrennLoadingAnimator.Play("NoEffectOpenFullScreenLoading");
    }

    public void OpenFullScreenBlack()
    {
        LoadingMachinePanel.transform.localPosition = openPosition;
        FullScreenLoadingObject.transform.localPosition = openPosition;
        FullScrennLoadingAnimator.Play("OpenFullScreenBlack");
    }

    public void OpenFullScreenAnimationFinish()
    {
        LoadingTextAnimator.Play("OpenLoadingText");
        LoadingMachineManager.OpenLoadingFinish();
    }

    public void OpenFullScreenBlackFinish()
    {
        LoadingMachineManager.OpenLoadingFinish();
    }

    public void OffFullScreenLoading()
    {
        LoadingTextAnimator.Play("LoadingTextIdle");
        FullScrennLoadingAnimator.Play("OffFullscreenLoading");
    }

    public void OffFullScreenBlack()
    {
        FullScrennLoadingAnimator.Play("OffFullScreenBlack");
    }

    public void OffFullScreenLoadingAnimationFinish()
    {
        FullScreenLoadingObject.transform.localPosition = offPosition;
        LoadingMachinePanel.transform.localPosition = offPosition;
        LoadingMachineManager.OffLoadingFinish();
    }
}
