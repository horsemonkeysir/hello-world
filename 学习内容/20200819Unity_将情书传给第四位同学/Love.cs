using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Love : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int i = 1; i <= 4; i++)// “++”的意思：+1
        {
            Debug.Log("for情书传给第" + i + "位同学"); 
        }

        //方法一==================================

        int w = 1;
        while (w <= 4)
        {
            Debug.Log("while情书传给第" + w + "位同学");
            w++;
        }

        //方法二====================================

        int d = 1;
        do
        {
            Debug.Log("do while情书传给第" + d + "位同学");
            d++;
        }
        while (d <= 4);
        //方法三======================================





	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
