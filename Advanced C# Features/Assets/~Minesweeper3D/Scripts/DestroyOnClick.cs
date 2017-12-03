﻿using UnityEngine;

namespace Minesweeper3D
{
    public class DestroyOnClick : MonoBehaviour
    {
        // Update is called once per frame
        void Update ()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    BoxCollider bc = hit.collider as BoxCollider;

                    if (bc != null)
                    {
                        Destroy(bc.gameObject);
                    }
                }
            }
        }
    }
}

