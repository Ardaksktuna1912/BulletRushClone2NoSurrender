using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenTouchController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Vector2 _TouchPosition ;
    public Vector2 Direction { get; private set; }
    public void OnPointerDown(PointerEventData eventData)
    {
        _TouchPosition = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Direction = Vector3.zero;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        var delta=eventData.position - _TouchPosition;
        Direction = delta.normalized;
        
    }


}
