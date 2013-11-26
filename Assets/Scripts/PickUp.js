private var pickObj: Transform = null;
private var hit: RaycastHit;
private var dist: float;
private var newPos: Vector3;
public var grabDistance: float = 10.0;
public var projForce: float = 1.0;

function Update()
{

    if (Input.GetMouseButton(1))
    { 
        var ray = Camera.main.ScreenPointToRay(Vector3(Screen.currentResolution.width/2, Screen.currentResolution.width/2, 0));
        
        if (!pickObj)
        { 
        	//pickObj.rigidbody.isKinematic = true;
            if (Physics.Raycast(ray, hit, grabDistance) && hit.transform.tag == "Moveable")
            {
                if (hit.rigidbody) hit.rigidbody.velocity = Vector3.zero;
                pickObj = hit.transform;
                dist = Vector3.Distance(pickObj.position, Camera.main.transform.position);
            }
        }
        else 
        { 
            pickObj.rigidbody.useGravity = false;
            pickObj.collider.isTrigger  = true;
            newPos = ray.GetPoint(dist); 
            pickObj.position = newPos;
            pickObj.rigidbody.useGravity = true;
            pickObj.collider.isTrigger = false;
            //pickObj.rigidbody.isKinematic = false;
            if(Input.GetMouseButton(0))
            {
            	//pickObj.rigidbody.isKinematic = true;
            	pickObj.rigidbody.AddForce(transform.forward * (projForce / 8));
            	pickObj = null;
            	
            }
        }    
    }
    else 
    { 
        pickObj = null;
    }
}