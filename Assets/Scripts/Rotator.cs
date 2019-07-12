using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    void Update()
    {// 因为不用物理，我们不用FixedUpdate
         //这里deltaTime就是时间间隔，即，每一帧的坐标都是新的。
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
