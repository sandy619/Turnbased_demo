using UnityEngine;

/// <summary>This component will destroy the GameObject it is attached to (in Start()).</summary>
public class DeleteOnStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Component.Destroy(this.gameObject);
	}
}
