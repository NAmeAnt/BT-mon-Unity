using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    // Update is called once per frame
        void Update()
{
    // Lưu giá trị y hiện tại của gameObject
    //float currentY = gameObject.transform.position.y;

    // Di chuyển sang phải
    if (Input.GetKey(KeyCode.RightArrow))
    {
        gameObject.transform.position += new Vector3(0.005f, 0, 0); // Di chuyển sang phải
    }

    // Di chuyển sang trái
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        gameObject.transform.position -= new Vector3(0.005f, 0, 0); // Di chuyển sang trái
    }

}

}
