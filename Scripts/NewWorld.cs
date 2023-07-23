using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWorld
: MonoBehaviour
{
    private int ba�la= 25;
    private int bitir= 50;
    private int b�lenba�la= 4;
    private int b�lenbitir= 20;


    void Start()
    {
      
        yaz(ba�la,bitir);

        for (int i = b�lenba�la ; i <= b�lenbitir; i++) 
        {
            b�l(ba�la,bitir,i);
        }

    }

    void yaz(int ba�la, int bitir)
    {
        string sonu� = "";
        for (int i = ba�la; i <= bitir; i++)
        {
            sonu� += i.ToString() + " ";
        }
        print("Say�lar�m�z �unlard�r: " + sonu�);
    }

    void b�l(int ba�la, int bitir, int b�len)
    {
        string sonu� = "";
        for (int i = ba�la; i <= bitir; i++)
        {
            if (i % b�len == 0)
            {
                sonu� += i.ToString() + " ";
            }
        }
        print(b�len + "'e b�l�nenler: " + sonu�);
    }
}
