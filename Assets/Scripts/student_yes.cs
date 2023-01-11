using UnityEngine;

public class student_yes : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void Student_yes()
    {
        animator.SetTrigger("student_yes");
    }
}
