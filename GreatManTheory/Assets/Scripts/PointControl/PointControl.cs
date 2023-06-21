using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PointControl : MonoBehaviour
{
    [SerializeField]
    PointDeterminer point_det;

    [SerializeField]
    Transform anchor;

    [SerializeField]
    float follow_strength;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // TODO(Simon): Determine whether this should happen in Update, FixedUpdate, or LateUpdate

        Vector3 point = point_det.GetPoint();

        Vector3 rel_point = point - anchor.position;

        // TODO(Simon): Determine whether this should stay Impulse or be changed to Force
        rb.AddForceAtPosition(rel_point * follow_strength, anchor.position, ForceMode2D.Impulse);
    }
}
