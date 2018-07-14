using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] points = { 30, 20, 50, 10, 80 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
            // 配列の要素を表示する
            Debug.Log(points[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }
}