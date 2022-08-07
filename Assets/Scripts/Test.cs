using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Test : MonoBehaviour
    {
        public string keyLog;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                keyLog = "";
                keyLog += "d";
            }

            if (Input.GetKey(KeyCode.Space))
            {
                keyLog += "p";
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                keyLog += "u";
            }

            Debug.Log(keyLog);
        }
    }
}