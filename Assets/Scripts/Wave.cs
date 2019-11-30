using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : Wave.cs

* 작성자 : 김민선 (김택원, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 강물의 파도를 구현한다.

*/


public class Wave : MonoBehaviour
{
    public float Scale = 0.1f;
    public float Speed = 1.0f;
    public float NoiseStrength = 1f;
    public float NoiseWalk = 1f;
    private Vector3[] _baseHeight;
    private Mesh _mesh;
    public MeshCollider MC;

    private void Start()
    {
        //the variable MC (MeshCollider) is dragger on the varable via the editor
        _mesh = GetComponent<MeshFilter>().mesh;
    }
    void Update()
    {
        if (_baseHeight == null)
            _baseHeight = _mesh.vertices;

        Vector3[] vertices = new Vector3[_baseHeight.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 vertex = _baseHeight[i];
            vertex.y += Mathf.Sin(Time.time * Speed + _baseHeight[i].x + _baseHeight[i].y + _baseHeight[i].z) * Scale;
            vertex.y += Mathf.PerlinNoise(_baseHeight[i].x + NoiseWalk, _baseHeight[i].y + Mathf.Sin(Time.time * 0.1f)) * NoiseStrength;
            vertices[i] = vertex;
        }
        _mesh.vertices = vertices;
        _mesh.RecalculateNormals();

        MC.sharedMesh = _mesh;
    }
}