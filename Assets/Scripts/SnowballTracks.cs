using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballTracks : MonoBehaviour
{
    private RenderTexture _splatmap;
    public Shader _drawShader;
    private Material _snowMaterial, _drawMaterial;
    public GameObject _terrain;
    public Transform _snowball;
    RaycastHit _groundHit;
    int _layerMask;

    [Range(1, 500)]
    public float _brushSize;
    [Range(0, 1)]
    public float _brushStrength;

    // Start is called before the first frame update
    void Start()
    {
        _layerMask = LayerMask.GetMask("Ground");
        _drawMaterial = new Material(_drawShader);

        _snowMaterial = _terrain.GetComponent<MeshRenderer>().material;
        
        _snowMaterial.SetTexture("_Splat", _splatmap = new RenderTexture(1024, 1024, 0, RenderTextureFormat.ARGBFloat));
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(_snowball.position, -Vector3.up, out _groundHit, 100f, _layerMask))
        {
            _drawMaterial.SetVector("_Coordinate", new Vector4(_groundHit.textureCoord.x, _groundHit.textureCoord.y, 0, 0));
            _drawMaterial.SetFloat("_Strength", _brushStrength);
            _drawMaterial.SetFloat("_Size", _brushSize);
            RenderTexture temp = RenderTexture.GetTemporary(_splatmap.width, _splatmap.height, 0, RenderTextureFormat.ARGBFloat);
            Graphics.Blit(_splatmap, temp);
            Graphics.Blit(temp, _splatmap, _drawMaterial);
            RenderTexture.ReleaseTemporary(temp);
        }
    }
}
