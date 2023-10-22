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
        ChangeImage0();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeImage0()
    {
        UnityEngine.Sprite sprite = Resources.Load<UnityEngine.Sprite>("CandyBucket00.png");
        Debug.Log(sprite);
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
    }

    public void ChangeImage1()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("Assets/Sprites/CandyBucket01");
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
