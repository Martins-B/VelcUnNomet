using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler
{
    private float vietasZrot;
    private float velkamaObjeZrot;
    private float rotacijasStarpiba;
    private Vector2 vietasIzm;
    private Vector2 velkObjIzm;
    private float xIzmeruStarpiba;
    private float yIzmeruStarpiba;
    public Objekti objektuSkripts;

    public void OnDrop(PointerEventData notikums)
    {
        if(notikums.pointerDrag != null)
        {
            if((notikums.pointerDrag.tag.Equals(tag)))
            {
                vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                velkamaObjeZrot = GetComponent<RectTransform>().transform.eulerAngles.z;
                rotacijasStarpiba = Mathf.Abs(vietasZrot - velkamaObjeZrot);
                vietasIzm = notikums.pointerDrag.GetComponent<RectTransform>().localScale;
                velkObjIzm = GetComponent<RectTransform>().localScale;
                xIzmeruStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
                yIzmeruStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);
                
                if((rotacijasStarpiba <=9 || (rotacijasStarpiba>= 351 && rotacijasStarpiba <=360))&& (xIzmeruStarpiba <=0.15 && yIzmeruStarpiba <= 0.15))
                {
                    objektuSkripts.vaiIstajaVieta = true;

                    notikums.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    notikums.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    notikums.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;

                    switch(notikums.pointerDrag.tag)
                    {
                        case "Atkritumi":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[1]);
                        break;
                        case "Atrie":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
                        break;
                        case "Skola":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
                        break;
                        case "b2":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[4]);
                        break;
                        case "cements":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[5]);
                        break;
                        case "e46":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[6]);
                        break;
                        case "eskavators":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[7]);
                        break;
                        case "policija":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[8]);
                        break;
                        case "traktors1":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[9]);
                        break;
                        case "traktors2":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[10]);
                        break;
                        case "ugunsdzeseji":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[11]);
                        break;

                        default:
                            Debug.Log("Nedefinēts tags!");
                            break;      
                    }
                }
            }else{
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0]);
                
                 switch(notikums.pointerDrag.tag)
                    {
                        case "Atkritumi":
                            objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrKoord;
                        break;
                        case "Atrie":
                             objektuSkripts.atroMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atroKoord;
                        break;
                        case "Skola":
                             objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                        case "b2":
                             objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;
                        case "cements":
                             objektuSkripts.cementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.cementaKoord;
                        break;
                        case "e46":
                             objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;
                        case "eskavators":
                             objektuSkripts.eskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.eskavatorsKoord;
                        break;
                        case "policija":
                             objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.policijaKoord;
                        break;
                        case "traktors1":
                             objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors1Koord;
                        break;
                        case "traktors2":
                             objektuSkripts.traktors2.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors2Koord;
                        break;
                        case "ugunsdzeseji":
                             objektuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsdzesejiKoord;
                        break;

                        default:
                            Debug.Log("Nedefinēts tags!");
                            break;      
                    }
            }
        }
    }
}
