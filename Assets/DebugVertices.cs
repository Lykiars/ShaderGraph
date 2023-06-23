﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DebugVertices : MonoBehaviour {

	Mesh mesh;
	Vector3[] vertices;

	void OnDrawGizmos()
	{
		if (vertices == null)
		{
			mesh = GetComponent<MeshFilter>().sharedMesh;
			vertices = mesh.vertices;
		}
		foreach (Vector3 v in vertices)
		{
			string vert = "v: " + v.ToString();
		    string worldVert = "wv: " + (transform.position + v).ToString();
			UnityEditor.Handles.Label(transform.position + v, vert + worldVert);
		}
	}
}
