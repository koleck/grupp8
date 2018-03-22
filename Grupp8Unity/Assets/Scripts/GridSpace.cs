using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GridSpace : MonoBehaviour {
	public Button button;
	public Text buttonText;
	public string playerSide;
	public void SetSpace ()
	{
		buttonText.text = playerSide;
		button.interactable = false;
	}
}