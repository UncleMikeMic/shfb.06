using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LE_LevelEditor.Events;

public class fixedLocationPlacement : MonoBehaviour {

    public int limitX = 5;
    public int limitY = 5;
    public int limitZ = 5;

    void OnEnable()
    {
        LE_EventInterface.OnObjectDragged += OnObjectDragged;
    }

    void OnDisable()
    {
        LE_EventInterface.OnObjectDragged -= OnObjectDragged;
    }

    private void OnObjectDragged(object p_sender, LE_ObjectDragEvent p_args)
    {
        // in this example we will check if the cursor position (the place where the object will be placed)
        // is too far away from the center of the level (outside a square with side length 200)
        // you can replace this with the check that you need to perform
        // take a look at the other members of LE_ObjectDragEvent
        // for example the object prefab is also passed within the event args

        if (Mathf.Abs(p_args.CursorHitInfo.point.x) > limitX ||
            Mathf.Abs(p_args.CursorHitInfo.point.y) > limitY ||
            Mathf.Abs(p_args.CursorHitInfo.point.z) > limitZ)
        {
            // tell the level editor that this object cannot be placed at the current cursor position

            p_args.IsObjectPlaceable = false;
            // check if there is already a message that will be shown to the player
            // this can be the case if some other listener of this event has added a message
            // or if the instance count of this objects has reached its maximum

            if (p_args.Message.Length > 0)
            {
                // add a line break if the message is not empty

                p_args.Message += "\n";
            }
            // add your message here in this example the object is simply out of bounds

            p_args.Message += "Object is out of bounds!";
        }
    }
}
