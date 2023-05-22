using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryOnController : MonoBehaviour
{
    [SerializeField] private  GameObject _hatObject;
    [SerializeField] private  GameObject _glassesObject;

    [SerializeField] private  GameObject _mustacheObject;

    // Start is called before the first frame update
    void Start()
    {
        _hatObject.SetActive(true);
        _glassesObject.SetActive(true);
    }

    public void ToggleHat() {
        _hatObject.SetActive(!_hatObject.activeSelf);
    }

    public void ToggleGlasses() {
        _glassesObject.SetActive(!_glassesObject.activeSelf);
    }
    public void ToggleMustache() {
        _mustacheObject.SetActive(!_mustacheObject.activeSelf);
    }
}
