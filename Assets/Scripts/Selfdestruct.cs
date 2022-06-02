using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[AddComponentMenu("Playground/Gameplay/Timed Self-Destruct")]
public class Selfdestruct : MonoBehaviour
{

	// After this time, the object will be destroyed
	public float timeToDestruction;
	[SerializeField] private Text result;

	void Start()
	{
		Invoke("DestroyMe", timeToDestruction);
	}


	// This function will destroy this object :(
	void DestroyMe()
	{
		Destroy(gameObject);
		result.text = "Game Over!!!";
		// Bye bye!
	}
}
