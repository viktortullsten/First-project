using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introduktion : MonoBehaviour
{
    public float Angle; 
    public float triangleBase;
    public float number;
    public string sentence1;
    public string sentence2;
    public string sentence3;
    
    public int testint = 5;
    //int= heltal
    public float testfloat = 2.0f;
    //float= decimalvärden 
    public bool testbool = true;
    //bool= på eller av
    public char testchar = 'A';
    //char= tecken 
    public string teststring = "hej";
    //public string= flera tecken 
    // hej 
    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
    }
    void TestFunktion()
    {
        Debug.Log("hej");
    }
    void Uppgift1()
    {
        Debug.Log(
            string.Format(
                "svaret på  (963 * 421) - (175463 / 87) är {0}"
                , (963 * 421) - (175463 / 87)));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Uppgift2()
    {
        Debug.Log(sentence1);
        Debug.Log(sentence2);
        Debug.Log(sentence3);
    }
    void Uppgift3()
    {
        // behöver förstå!
        Debug.Log(string.Format(
            "Talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} blir {2}", number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
    }
    void Uppgift4()
    { Debug.Log(string.Format(
         "Triangelns area är {0} * {1} / {2} = {3}cm2", triangleBase, 8, 2, (triangleBase * 8 / 2) ));}
    
void Uppgift5()
    { Debug.Log(string.Format(
        "Antal tårtbitar är {0}/{1} = {2} bitar", 360,Angle, (360 / Angle )));}

    void Uppgift6()
    {


    }
}
        