using UnityEngine;
using UnityEngine.Playables; //PlayableDirector 클래스 활용을 위한 네임스페이스 선언
public class timeline_play : MonoBehaviour
{
    public PlayableDirector playableDirector; //PlayableDirector 클래스 변수 선언
 
    public void Play()
    {
        playableDirector.Play (); //playableDirector을 통한 타임라인 실행

        //Button의 부모 클래스에 해당하는 Panel을 비활성화 하기위한 코드
        gameObject.transform.parent.gameObject.SetActive(false); 
    }
}

