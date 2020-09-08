using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerExample : EventTrigger
{

    private Color originalColor;

    private void Awake()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    public override void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("OnBeginDrag called.");
    }

    public override void OnCancel(BaseEventData data)
    {
        Debug.Log("OnCancel called.");
    }

    public override void OnDeselect(BaseEventData data)
    {
        Debug.Log("OnDeselect called.");
    }

    public override void OnDrag(PointerEventData data)
    {
        Debug.Log("OnDrag called.");
    }

    public override void OnDrop(PointerEventData data)
    {
        Debug.Log("OnDrop called.");
    }

    public override void OnEndDrag(PointerEventData data)
    {
        Debug.Log("OnEndDrag called.");
    }

    public override void OnInitializePotentialDrag(PointerEventData data)
    {
        Debug.Log("OnInitializePotentialDrag called.");
    }

    public override void OnMove(AxisEventData data)
    {
        Debug.Log("OnMove called.");
    }

    public override void OnPointerClick(PointerEventData data)
    {
        Debug.Log("OnPointerClick called.");
    }

    public override void OnPointerDown(PointerEventData data)
    {
        Debug.Log("OnPointerDown called.");
    }

    public override void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("OnPointerEnter called.");
        this.GetComponent<Renderer>().material.color = Color.red;
    }

    public override void OnPointerExit(PointerEventData data)
    {
        Debug.Log("OnPointerExit called.");
        this.GetComponent<Renderer>().material.color = originalColor;
    }

    public override void OnPointerUp(PointerEventData data)
    {
        Debug.Log("OnPointerUp called.");
    }

    public override void OnScroll(PointerEventData data)
    {
        Debug.Log("OnScroll called.");
    }

    public override void OnSelect(BaseEventData data)
    {
        Debug.Log("OnSelect called.");
    }

    public override void OnSubmit(BaseEventData data)
    {
        Debug.Log("OnSubmit called.");
    }

    public override void OnUpdateSelected(BaseEventData data)
    {
        Debug.Log("OnUpdateSelected called.");
    }
}