using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // Fields
    public Objekti objektuSkripts;
    //public UzvarasNoteicejs uzvarasNoteicejaSkripts;
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;

    // Methods
     void Awake()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData notikums)
    {
        objektuSkripts.pedejaisVilktais = null;
        Debug.Log("Uzsākta vilkšana");
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
        //velkObjRectTransf.SetSiblingIndex(0x1d);
    }

    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek vilkšana");
        velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
        //velkObjRectTransf.position = new Vector3(Mathf.Clamp(velkObjRectTransf.position.x, 10f, 0x4f6f), Mathf.Clamp(velkObjRectTransf.position.y, 10f, 590f), velkObjRectTransf.position.z);
    }

    public void OnEndDrag(PointerEventData notikums)
    {
        objektuSkripts.pedejaisVilktais = notikums.pointerDrag;
        Debug.Log("Pēdējais vilktais objekts: " + objektuSkripts.pedejaisVilktais);
        Debug.Log("Beigta vilkšana!");
        kanvasGrupa.alpha = 1f;
        
        if (objektuSkripts.vaiIstajaVieta == false)
        {
            kanvasGrupa.blocksRaycasts = true;
        }
        else
        {
            objektuSkripts.pedejaisVilktais = null;
        }
        objektuSkripts.vaiIstajaVieta = false;
    }

    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Uzklikšķināts uz velkamā objekta");
        //objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0x11]);
    }
}