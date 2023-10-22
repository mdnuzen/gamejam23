using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.UI;

public class CandyUI : MonoBehaviour
{
    // Start is called before the first frame update
    public CandyInventory candyInventory;
    private int gameInt;

    void Start()
    {
        gameInt = candyInventory.NumberOfCandies;
    }

    // Update is called once per frame
    void Update()
    {
        gameInt = candyInventory.NumberOfCandies;
        if (gameInt == 0)
        {
            ChangeImage0();
        }
        else if (gameInt <= 2)
        {
            ChangeImage1();
        }
        else if (gameInt <= 5)
        {
            ChangeImage2();
        }
        else if (gameInt <= 7)
        {
            ChangeImage3();
        }
        else if (gameInt <= 10)
        {
            ChangeImage4();
        }
    }

    public void ChangeImage0()
    {
        UnityEngine.Sprite sprite = Resources.Load<UnityEngine.Sprite>("CandyBucket00");
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
    }

    public void ChangeImage1()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("CandyBucket01");
    }

    public void ChangeImage2()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("CandyBucket02");
    }

    public void ChangeImage3()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("CandyBucket03");
    }

    public void ChangeImage4()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("CandyBucket04");
    }

}
