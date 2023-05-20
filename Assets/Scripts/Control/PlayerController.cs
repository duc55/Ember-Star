using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJam.Input;

namespace GameJam.Control
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField, Range(0f, 100f)] private float maxSpeed = 5f;
        [SerializeField, Range(0f, 100f)] private float maxAcceleration = 10f;

        [field: SerializeField] public InputReader InputReader { get; private set; }

        private Vector3 velocity;

        
        private void Update()
        {
            Vector3 desiredVelocity = new Vector3(InputReader.MovementDirection.x, 0.0f, InputReader.MovementDirection.y) * maxSpeed;
            float maxSpeedChange = maxAcceleration * Time.deltaTime;

            velocity.x = Mathf.MoveTowards(velocity.x, desiredVelocity.x, maxSpeedChange);
            velocity.z = Mathf.MoveTowards(velocity.z, desiredVelocity.z, maxSpeedChange);

            Vector3 displacement = velocity * Time.deltaTime;

            transform.localPosition += displacement;
        }
    }
}
