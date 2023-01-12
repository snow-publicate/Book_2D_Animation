using UnityEngine;
using UnityEngine.Playables;
public class timeline_play : MonoBehaviour
{
    public PlayableDirector playableDirector;
 
    public void Play()
    {
        playableDirector.Play ();
        gameObject.transform.parent.gameObject.SetActive(false); 
    }
}

