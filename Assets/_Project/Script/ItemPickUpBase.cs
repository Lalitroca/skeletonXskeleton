using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpBase : MonoBehaviour
{
    [SerializeField] protected int _boostAmount = 0;
    [SerializeField] protected float _destroyDelay = 1.3f;
    private AudioSource _audioPlayer;

    private void Awake()
    {
        Initialize();
    }
    private void Initialize()
    {
        _audioPlayer = GetComponent<AudioSource>();
    }
    public virtual void PickUpItem(GameObject owner)
    {
        if(_audioPlayer != null)
        {
            Debug.Log("Playing pickup audio");
            _audioPlayer.Play();
        }
        StartCoroutine(DestroyItself());
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherObject = other.gameObject;

        if(otherObject.GetComponent<PlayerInput>() != null)
        {
            PickUpItem(otherObject);
        }
    }
    private IEnumerator DestroyItself()
    {
        yield return new WaitForSeconds(_destroyDelay);
        gameObject.SetActive(false);
    }
}
