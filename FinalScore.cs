using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int finalScore;
    // Start is called before the first frame update
    private void Start()
    {
        //finalScore =0;
        GetComponent<UnityEngine.UI.Text>().text = finalScore.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = finalScore.ToString();
    }
}
