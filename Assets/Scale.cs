using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour {
    public GameObject targetGo;
    public Slider scaleSlider;

    public void Changed () {
        float scale = scaleSlider.value;
        targetGo.transform.localScale = new Vector3(scale, scale, scale);
	}
}
