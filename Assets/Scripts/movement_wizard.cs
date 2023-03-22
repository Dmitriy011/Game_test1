using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class movement_wizard : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed_moving = 20f;
    private bool flag_down = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); //получаем ссылку на Rigidbody из объекта
    }


    void Update()
    {
        Vector3 dir = new Vector3(0f, 0f, 0f);

        if (rigidbody.position.y > 0f && flag_down == true)
        {
            dir = new Vector3(0f, -1f, -1f);
        }
        else 
        {
            dir = new Vector3(0f, 1f, 1f);
            flag_down = false;

            if (rigidbody.position.y > 13f)
            {
                flag_down = true;
            }
        }

        rigidbody.position += (dir.normalized) * Time.deltaTime * speed_moving;
    }
}
