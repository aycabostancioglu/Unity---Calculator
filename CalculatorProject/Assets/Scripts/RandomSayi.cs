using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;



public class RandomSayi : MonoBehaviour
{
    int sayi1;
    int sayi2;
    int islem;

    public TMP_Text islem1;
    public TMP_Text islem2;
    TMP_Text tahmin;
    public Text basari;

    public TMP_InputField InputField;

    int a, b;
    int toplam, cikar, carp, bol;

    public TMP_Text dortislem;
    string sonuc;

    System.Random rastgele = new System.Random();


    public void SayiUret()
    {
        sayi1 = rastgele.Next(0, 51);
        sayi2 = rastgele.Next(0, 51);
        islem = rastgele.Next(1, 5);

        islem1.text = sayi1.ToString();
        islem2.text = sayi2.ToString();

        a = Convert.ToInt32(islem1.text);
        b = Convert.ToInt32(islem2.text);

        if (islem == 1)
        {
            dortislem.text = "+";
            toplam = a + b;
            sonuc = toplam.ToString();
        }
        if (islem == 2)
        {
            dortislem.text = "-";
            cikar = a - b;
            sonuc = cikar.ToString();
        }
        if (islem == 3)
        {
            dortislem.text = "*";
            carp = a * b;
            sonuc = carp.ToString();
        }
        if (islem == 4)
        {
            dortislem.text = "/";
            bol = a / b;
            sonuc = bol.ToString();

        }





    }
    public void Yanitla()
    {
        if (sonuc == InputField.text)
        {

            basari.text = "TEBRÝKLER!";
            SayiUret();

        }
        else
        {
            basari.text = "Tekrar Deneyiniz!";
        }

    }

    void Start()
    {
        SayiUret();
    }
}
