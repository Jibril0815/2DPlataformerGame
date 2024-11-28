using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonsManager : MonoBehaviour
{
    public List<GameObject> Buttons;

    [Header("Animation")]
    public float Duration = .2f;
    public float Delay = .05f;

    public void OnEnable()
    {
        HideAllButtons();
        ShowButtons();
    }

    private void HideAllButtons()
    {
        foreach (var b in Buttons)
        {
            b.transform.localScale = Vector3.zero;
            b.SetActive(false);
        }
    }

    private void ShowButtons()
    {
        for (int i = 0; i < Buttons.Count; i++)
        {
            var b = Buttons[i];

            b.SetActive(true);
            b.transform.DOScale(1, Duration).SetDelay(1*Delay);
        }
    }



}
