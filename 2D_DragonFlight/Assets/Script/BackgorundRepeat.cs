using UnityEngine;

public class BackgorundRepeat : MonoBehaviour
{
    //��ũ�� �� �ӵ��� ����� ����
    public float scrollSpeed = 0.6f;
    //������ ���͸��� �����͸� �޾ƿ� ��ü�� ����
    private Material thisMaterial;
    void Start()
    {
        //���� ��ü�� Comonent���� ������ Renderer��� ������Ʈ�� material����
        //�޾ƿ�
        thisMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //���Ӱ� �������� Offset ��ü�� ����
        Vector2 newoffset = thisMaterial.mainTextureOffset;
        //Y�̺п� ���� y���� �ӵ��� ������ �������ؼ� ������
        newoffset.Set(0, newoffset.y + (scrollSpeed * Time.deltaTime));
        //���������� offset���� �������ݴϴ�.
        thisMaterial.mainTextureOffset = newoffset;
    }
}
