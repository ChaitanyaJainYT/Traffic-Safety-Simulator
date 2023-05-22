using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VolvoCars.Behaviour
{
    public class SteeringWheelController : MonoBehaviour
    {
        [SerializeField] Transform steeringWheelTransform;
        [SerializeField] Data.SteeringWheelAngle steeringWheelAngle;
        private Quaternion originalRotation;
        public bool inverse = true;

        private void Awake()
        {
            originalRotation = steeringWheelTransform.localRotation;
        }

        void Update()
        {
            float inv = 1;
            if (inverse) inv = -1;
            steeringWheelTransform.localRotation = originalRotation * Quaternion.Euler(inv * -steeringWheelAngle.Value*Mathf.Rad2Deg, 0, 0);
        }
    }

}