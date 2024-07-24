using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickBanana : MonoBehaviour
{
    public int count=0;
    public Text text;
    // Start is called before the first frame update
    public void AddBanana(){
        count++;
        text.text=count.ToString();
    }
}
