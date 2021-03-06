using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AillieoUtils.Pathfinding.GraphCreator
{
    public class NavMeshEditorCtrl
    {
        public float selectDistance = 2f;

        public int polygonHover = -1;

        public int polygonSelected = -1;
        public int lineSelected = -1;
        public int pointSelected = -1;

        public int lineHover = -1;
        public int pointHover = -1;
        public bool selectingPoint;

        public Vector2 beginDragPosition;

        public void DeselectAll()
        {
            polygonHover = -1;
            polygonSelected = -1;

            pointHover = -1;
            pointSelected = -1;

            lineHover = -1;
            lineSelected = -1;

            selectingPoint = false;
        }

        public void CleanUp()
        {
            DeselectAll();
        }
    }
}
