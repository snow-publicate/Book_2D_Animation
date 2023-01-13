using UnityEngine;

public class student_yes : MonoBehaviour
{
    [SerializeField] //유니티 에디터에서의 접근 허용
    private Animator animator; //Animator 클래스 변수 선언

    public void Student_yes() 
    {
        animator.SetTrigger("student_yes"); //animator의 student_yes 트리거 작동
    }
}

