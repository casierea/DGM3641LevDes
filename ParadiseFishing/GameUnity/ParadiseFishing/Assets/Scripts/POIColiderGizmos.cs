using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POIColiderGizmos : MonoBehaviour
{
    #region -------------- Variables --------------

    private BoxCollider _collider;
    private Vector3 _boxSize;
    private GameObject _parentObj;
    private Transform _parentTransform;
    [SerializeField] private bool _showGizmos = true;
    #endregion

    #region -------------- Setup --------------

    private void Awake()
    {
        _parentTransform = GetComponentInParent<Transform>();
        _collider = GetComponent<BoxCollider>();
        _boxSize = _collider.bounds.size;
    }

    #endregion

    #region -------------- Work --------------

    private void OnDrawGizmos()
    {
        if (_showGizmos)
        {
            BoxCollider boxCollider = GetComponent<BoxCollider>();
            DrawBoxCollider(Color.white, boxCollider);
        }
    }
 
    private void DrawBoxCollider(Color gizmoColor, BoxCollider boxCollider, float alphaForInsides = 0.3f)
    {
        //Save the color in a temporary variable to not overwrite changes in the inspector (if the sent-in color is a serialized variable).
        var color = gizmoColor;
 
        //Change the gizmo matrix to the relative space of the boxCollider.
        //This makes offsets with rotation work
        //Source: https://forum.unity.com/threads/gizmo-rotation.4817/#post-3242447
        Gizmos.matrix = Matrix4x4.TRS(this.transform.TransformPoint(boxCollider.center), this.transform.rotation, this.transform.lossyScale);
 
        //Draws the edges of the BoxCollider
        //Center is Vector3.zero, since we've transformed the calculation space in the previous step.
        Gizmos.color = color;
        Gizmos.DrawWireCube(Vector3.zero, boxCollider.size);
 
        //Draws the sides/insides of the BoxCollider, with a tint to the original color.
        color.a *= alphaForInsides;
        Gizmos.color = color;
        Gizmos.DrawCube(Vector3.zero, boxCollider.size);
    }
    #endregion

    #region -------------- Methods --------------

    

    #endregion

    #region -------------- Visualize --------------

    

    #endregion

    #region -------------- Inspector --------------

    

    #endregion

}
