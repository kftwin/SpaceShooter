using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour
{

    #region Fields
    public float Speed;
    #endregion

    #region Properties
    #endregion

    #region Functions
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float amtToMove = Speed = Time.deltaTime;
        transform.Translate(Vector3.down * amtToMove, Space.World);

        if (transform.position.y < -12)
        {
            transform.position = new Vector3(transform.position.x, 13f, transform.position.z);
        }
    }
    #endregion

}

