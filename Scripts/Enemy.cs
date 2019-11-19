using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    #region Fields
    public float MinSpeed;
    public float MaxSpeed;

    private float currentSpeed;
    private float x, y, z;
    #endregion

    #region Properties
    #endregion

    #region Functions

    void Start()
    {
        SetPositionAndSpeed();
    }

    void Update()
    {
        float amtToMove = currentSpeed * Time.deltaTime;
        transform.Translate(Vector3.down * amtToMove);

        if (transform.position.y <= -6)
        {
            SetPositionAndSpeed();
            Player.Missed++;
        }


    }

    public void SetPositionAndSpeed()
    {
        currentSpeed = Random.RandomRange(MinSpeed, MaxSpeed);
        x = Random.RandomRange(-6f, 6f);
        y = 7.0f;
        z = 0.0f;

        transform.position = new Vector3(x, y, z);
    }

    #endregion

}

