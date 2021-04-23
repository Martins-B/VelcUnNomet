using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzvarasNoteicejs : MonoBehaviour
{
    
    public GameObject uzvarasLogs;
    [HideInInspector]
    public int pareiziNomestoSkaits=0;
    private bool spelePabeigta;
    

    public void pareiziNomestie()
    {
        pareiziNomestoSkaits++;
    }


    private void Update()
    {
        if ((pareiziNomestoSkaits == 11) && !spelePabeigta)
        {
            spelePabeigta = true;
            uzvarasLogs.SetActive(true);
            uzvarasLogs.GetComponent<RectTransform>().SetSiblingIndex(0x1d);
        }
    }
}

