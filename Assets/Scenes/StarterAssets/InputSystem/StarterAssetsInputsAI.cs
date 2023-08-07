using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputsAI : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

		// added by myself
		[SerializeField]
		public Transform redcube;
		public Transform bluecube;
		public int isReached = 0;

#if ENABLE_INPUT_SYSTEM
		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if (cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}
#endif


        public void MoveInput(Vector2 newMoveDirection)
        {
            move = newMoveDirection;
        }


        ////The latest workable code 9/6/2566
        //public void MoveInput(Vector2 newMoveDirection)
        //{

        //	StartCoroutine(MyCoroutine(newMoveDirection));
        //	//move = new Vector2(redcube.localPosition.x - transform.localPosition.x, redcube.localPosition.z - transform.localPosition.z);
        //	//Debug.Log(redcube.localPosition.x);
        //	//Debug.Log(redcube.localPosition.z);
        //	//while (isReached == 0)
        //	//{
        //	//	if ((redcube.localPosition.x - transform.localPosition.x) <= 20f && (redcube.localPosition.z - transform.localPosition.z) <= 20f)
        //	//	{
        //	//		isReached = 1;

        //	//	}
        //	//}
        //	//Debug.Log(isReached);
        //	//move = new Vector2(bluecube.localPosition.x - transform.localPosition.x, bluecube.localPosition.z - transform.localPosition.z);
        //	//Debug.Log(bluecube.localPosition.x);
        //	//Debug.Log(bluecube.localPosition.z);




        //}


        ////The latest workable code 9/6/2566
        //IEnumerator MyCoroutine(Vector2 newMoveDirection)
        //      {
        //	//List<float> lx = new List<float>() { 80.5f, 74f, 40f};
        //	//List<float> lz = new List<float>() { 17f, 26f, 15f };

        //	//List<float> lx = new List<float>() { 60.1f, 60.1f, 26.5f, 26.5f};
        //	//List<float> lz = new List<float>() { 29.8f, 15.5f, 15.5f, 5.9f};

        //	//List<float> lx = new List<float>() { 59f, 59f, 62.98f, 62.98f, 80.6f, 83.99f, 94.21f};
        //	//List<float> lz = new List<float>() { 35.63f, 28.11f, 28.11f, 24.12f, 24.12f, 20.98f,20.98f};

        //	//List<float> lx = new List<float>() { 59.7f, 64.03f, 64.03f, 59.94f, 58.79f, 58.79f};
        //	//List<float> lz = new List<float>() { 36.01f, 36.01f, 30.59f, 30.59f, 31.95f, 35.13f};

        //	//Underdamped 
        //	//List<float> lx = new List<float>() { 63f, 67.58f, 71.32f, 76.23f, 80.92f, 86.3f, 81.48f, 88.11f, 93.35f };
        //	//List<float> lz = new List<float>() { 23.25f, 24.53f, 23.28f, 24.72f, 23.72f, 23.72f, 20.15f, 20.15f, 20.15f};

        //	//Underdamped sampled
        //	List<float> lx = new List<float>() { 63f, 76.23f, 81.48f, 88.11f, 93.35f };
        //	List<float> lz = new List<float>() { 23.25f, 24.72f, 20.15f, 20.15f, 20.15f };

        //	List<Vector2> destination = new List<Vector2>();
        //          for (int i = 0; i < lx.Count; i++)

        //          {
        //              destination.Add(new Vector2(lx[i], lz[i]));
        //		yield return null;
        //          }

        //	yield return null;
        //	Debug.Log(destination[0]);
        //	Debug.Log(destination[1]);

        //	int j = 0;
        //	while (j <= destination.Count)
        //	{
        //		while (Vector2.Distance(destination[j], new Vector2 (transform.localPosition.x,transform.localPosition.z)) > 0.1f)
        //		{
        //			move = new Vector2(destination[j].x - transform.localPosition.x, destination[j].y - transform.localPosition.z);
        //			//Debug.Log(redcube.localPosition.x);
        //			//Debug.Log(redcube.localPosition.z);
        //			//Debug.Log(Vector2.Distance(transform.localPosition, redcube.localPosition));

        //			Debug.Log(transform.localPosition);
        //			Debug.Log(destination[j]);
        //			Debug.Log(Vector2.Distance(destination[j], new Vector2(transform.localPosition.x, transform.localPosition.z)));
        //			yield return null;

        //		}
        //		j = j + 1;
        //		Debug.Log(j);
        //		yield return null;
        //	}
        //	Debug.Log("reached the target");
        //	//move = new Vector2(bluecube.localPosition.x - transform.localPosition.x, bluecube.localPosition.z - transform.localPosition.z);
        //	//yield return null;
        //}







        public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}