using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    public GameObject backPanel;
    public GameObject homePanel;

    public void CancelButton()
    {
        backPanel.SetActive(false);
        homePanel.SetActive(false);
    }

    public void HomeButton()
    {
        homePanel.SetActive(true);
    }

    public void BackButton()
    {
        backPanel.SetActive(true);
    }

    public void ExitButton()
    {
        backPanel.SetActive(false);
        homePanel.SetActive(false);
    }
}
