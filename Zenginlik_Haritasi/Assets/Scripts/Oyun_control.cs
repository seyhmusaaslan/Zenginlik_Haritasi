using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyun_control : MonoBehaviour
{
    public bool OyunAktif = true;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinSayisiText;
    public UnityEngine.UI.Button baslatButtonu;
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AltinArttir()
    {
        altinSayisi += 1;
        altinSayisiText.text = "" + altinSayisi;
    }
    public void OyunaBasla()
    {
        OyunAktif = true;
        baslatButtonu.gameObject.SetActive(false);


    }
}
