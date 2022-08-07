using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Jelly : MonoBehaviour
    {
        public float Force;

        private void OnTriggerStay(Collider other)
        {
            other.attachedRigidbody.AddRelativeForce(0,Force,0);
        }
    }
}