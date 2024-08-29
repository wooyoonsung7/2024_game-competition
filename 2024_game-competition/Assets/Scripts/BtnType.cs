using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnType : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public ButtonType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }
    bool isSound;
    public void OnBtnClick()

    {
        switch (currentType)
        {
            case ButtonType.New:
                break;
            case ButtonType.Continue:
                break;
            case ButtonType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;
            case ButtonType.Sound:
                if(isSound)
                {
                    isSound = !isSound;
                }
                else
                {
                    isSound = !isSound;
                }
                isSound = !isSound;
                break;
            case ButtonType.Back:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                break;
            case ButtonType.Quit:
                Application.Quit();
                break;
        }
    }
    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
