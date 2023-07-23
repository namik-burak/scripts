using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWorld
: MonoBehaviour
{
    private int baþla= 25;
    private int bitir= 50;
    private int bölenbaþla= 4;
    private int bölenbitir= 20;


    void Start()
    {
      
        yaz(baþla,bitir);

        for (int i = bölenbaþla ; i <= bölenbitir; i++) 
        {
            böl(baþla,bitir,i);
        }

    }

    void yaz(int baþla, int bitir)
    {
        string sonuç = "";
        for (int i = baþla; i <= bitir; i++)
        {
            sonuç += i.ToString() + " ";
        }
        print("Sayýlarýmýz þunlardýr: " + sonuç);
    }

    void böl(int baþla, int bitir, int bölen)
    {
        string sonuç = "";
        for (int i = baþla; i <= bitir; i++)
        {
            if (i % bölen == 0)
            {
                sonuç += i.ToString() + " ";
            }
        }
        print(bölen + "'e bölünenler: " + sonuç);
    }
}
