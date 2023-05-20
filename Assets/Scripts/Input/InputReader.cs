using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam.Input
{
    public class InputReader : MonoBehaviour
    {
        public Vector2 MovementDirection { get; private set; }

        private void Update()
        {
            MovementDirection = new Vector2(
                UnityEngine.Input.GetAxis("Horizontal"),
                UnityEngine.Input.GetAxis("Vertical")
            );

            MovementDirection = Vector2.ClampMagnitude(MovementDirection, 1f);
        }
    }
}
