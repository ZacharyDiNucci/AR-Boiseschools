using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerUI : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject ui;

    public void OnPointerClick(PointerEventData data) {
        ui.SetActive(!ui.activeSelf);
    }
}
