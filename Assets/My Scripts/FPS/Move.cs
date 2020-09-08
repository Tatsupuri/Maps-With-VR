using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(hor, 0, ver);
        Quaternion changeCoodinate = Quaternion.FromToRotation(Vector3.forward, Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up).normalized);
        //常にプレイヤーの前方がコントローラーの前方になるようにする。そのためにgameObjectの前方を地面に射影したベクトルまでの回転をして座標変換すればよい。

        transform.position += changeCoodinate * dir * Time.deltaTime * speed;
    }
}
