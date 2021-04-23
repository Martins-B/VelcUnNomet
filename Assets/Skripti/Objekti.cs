using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //GameObject kas uzglaba visus velkamos objektus
    public GameObject atkritumuMasina;
    public GameObject atroMasina;
    public GameObject autobuss;
    public GameObject b2;
    public GameObject cementaMasina;
    public GameObject e46;
    public GameObject eskavators;
    public GameObject policija;
    public GameObject traktors1;
    public GameObject traktors2;
    public GameObject ugunsdzeseji;
    /*Uzgalaba velkamo objektu sakotneja pozicija
    kooardinatas (lai zinatu kur aizmest objektu ja tas nolikts nepareizaja vieta*/
    //Objekti paliek Public taču paslepj no Inspect loga

    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 cementaKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 eskavatorsKoord;
    [HideInInspector]
    public Vector2 policijaKoord;
    [HideInInspector]
    public Vector2 traktors1Koord;
    [HideInInspector]
    public Vector2 traktors2Koord;
    [HideInInspector]
    public Vector2 ugunsdzesejiKoord;
    //uzglaba ainas esošo kanvu
    public Canvas kanva;
    //uzglaba skanas avotu kurāatskaņot audio failus
    public AudioSource skanasAvots;
    //masivs kas uzglaba visas skanas
    public AudioClip[] skanaKoAtskanot;
    //uzgalab objektus kurš ir pedejais pievientoais
    [HideInInspector]
    public bool vaiIstajaVieta = false;
    [HideInInspector]
    public GameObject pedejaisVilktais = null;
    //mainigais atbild par to vai obejkts ir nolikts pareizi vai nepareizi

    //funkcija nostrada tiklidz nospiesta play pogu
    private void Awake()
    {
        atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        b2Koord =  b2.GetComponent<RectTransform>().localPosition;
        cementaKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        eskavatorsKoord = eskavators.GetComponent<RectTransform>().localPosition;
        policijaKoord = policija.GetComponent<RectTransform>().localPosition;
        traktors1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        traktors2Koord = traktors2.GetComponent<RectTransform>().localPosition;
        ugunsdzesejiKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
    }    
}
