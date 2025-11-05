using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioScript : MonoBehaviour
{
    [SerializeField] Block block;
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (block.state == Block.MoveStates.moving && !source.isPlaying)
        {
            source.Play();
        }
    }
}
