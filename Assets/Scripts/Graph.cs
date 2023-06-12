using UnityEngine;

public class Graph : MonoBehaviour
{
	[SerializeField] Transform pointPrefab;
	[SerializeField] int resolution;
	void Start()
	{
		float step = 2f / resolution;
		var pos = Vector3.zero;
		var scale = Vector3.one * step;
		for (int i = 0; i < resolution; i++)
		{
			Transform point = Instantiate(pointPrefab);
			pos.x = (i + 0.5f) * step - 1f;
			pos.y = Fun(pos.x);
			point.SetParent(transform, false);
			point.localScale = scale;
			point.localPosition = pos;
		}
	}

	float Fun(float value)
	{
		return Mathf.Pow(value, 3);
	}
}

