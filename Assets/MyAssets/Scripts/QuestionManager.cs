using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class QuestionManager : MonoBehaviour
{
    private Dictionary<string, List<string>> questionsByCategory = new Dictionary<string, List<string>>();

    private void Start()
    {
        InitializeQuestions();
    }


    public void InitializeQuestions()
    {
        AddQuestion("������ά��", "��ƽʱ�������ڳ����������黹�ǵ͵�������������?�һ�������Ȥ��!");
        AddQuestion("������ά��", "�������ֽ��Ǽ��������?��������,�㿴����ͦ��͵�!��˵�Բ���?");
        AddQuestion("������ά��", "��ʵ��Ҳ�������Ӳ��ұ����Լ���ʱ��԰�? ����˵˵���־���ʱ������ôӦ�Ե�!");
        AddQuestion("������ά��", "�㵽���ﶼ�ܽ��������Ѱ�,�кö�� Bros �ǲ���?");
        AddQuestion("������ά��", "�㲻̫ϲ����������˵����,�����е㺦�����������,��˵����û�У�");
        AddQuestion("������ά��", "��ʶ�����Ѷ�����˵�ܴ̼��԰�?");


        AddQuestion("����ά��", "�������ֺ��ٽ��ǻ���ŵľ�ˮ�������˸���?");
        AddQuestion("����ά��", "�����Լ���ŭ��������˵���Ѱ�?�㿴�����Ǹ���������! ");
        AddQuestion("����ά��", "�㿴������̬�ܺõ�����, û�о����Ծ�ɥ��������? ");
        AddQuestion("����ά��", "��������ǲ������ÿ�ȥ��Ҳ�찡? �Ǹ�����������!");
        AddQuestion("����ά��", "����ҵĸо������ֳ���chill����,ѹ�������޹ذ�");
        AddQuestion("����ά��", "�е��˻ᾭ�����ĸ��ֿ��µ��»ᷢ��,����������ָо���?");


        AddQuestion("������ά��", "�µĶ����������������������԰�?��������!");
        AddQuestion("������ά��", "ȥ�µĵط�����������˵�϶������̼���! ð�ռ��Ը�˵�ľ�������");
        AddQuestion("������ά��", "��ʹ�۵㲻ͬ,��ҲԸ���������˵Ŀ����԰�?");
        AddQuestion("������ά��", "��϶����������Ժ�����˼�����?������̫�ḻ��!");
        AddQuestion("������ά��", "�����Ȥ���ÿ϶������㷺������? ");
        AddQuestion("������ά��", "���ӵ����������Ī����������԰�? ��ս������ʢ!");

        AddQuestion("������ά��", "�����������Ա��ƻ��ǱȽ��������α���ѽ? ����˵˵������˵Ŀ�����!");
        AddQuestion("������ά��", "�������˶�����˵��Ҫ��?����һ���������չ���Χ�˵���ůС̫����?");
        AddQuestion("������ά��", "�㿴��������һ�����ݴ�ȵ���,Ӧ�ò���Ϊ��С�¼ƽϱ��˰�? �ܺ����㴦���˼ʹ�ϵ�ķ�ʽ!");
        AddQuestion("������ά��", "���Ҳ��㲻̫ϲ��������ҫ��,����һ��ǫ��͵��ĸо�!�������ĶԲ�����?");
        AddQuestion("������ά��", "��Ӧ�ú�����ÿ����,�������������۱��˶԰�?������˵˵����˵ķ�ʽ!");
        AddQuestion("������ά��", "����ҵĸо��Ƿǳ����׽���������!����������ظ�֪���˵��뷨��?");

        AddQuestion("������ά��", "�ҿ������¿϶���ϸ�ĵ�,���Բ����������!���~");
        AddQuestion("������ά��", "��������һ��׷���������װ�!ǿ��֢�������˹���!�ҲµĶ���?");
        AddQuestion("������ά��", "�������Լ����,��һ�㶼���������ʳ��!��Ϊ�㳬���׵�!��˵�Ķ԰ɶ԰�?");
        AddQuestion("������ά��", "����ջ���Ҳ���Ժúù�ס�Լ��İ�!����������Э��!��˵�ǲ�����?");
        AddQuestion("������ά��", "�ҿ��㹤���������ﰡ!�϶����Լ�ֵ����һ�̵�!�ǲ��Ǿ�����ôǿ�����?");
        AddQuestion("������ά��", "��̫��������,һ���ǳ����мƻ��������!���ؼ��ɺ����ɶ԰ɶ԰�?����������!");

    }

    public void AddQuestion(string category, string question)
    {
        questionsByCategory.Add(category, new List<string>());
        questionsByCategory[category].Add(question);
    }

    public List<string> GetQuestionsByCategory(string category)
    {
        return questionsByCategory.ContainsKey(category) ? questionsByCategory[category] : new List<string>();
    }
    public List<string> GetAllQuestions()
    {
        return questionsByCategory.Values.SelectMany(x => x).ToList();
    }

    public string GetRandomQuestion()
    {
            var category = pickRandomCategory();
            var questions = GetQuestionsByCategory(category);
            return questions[UnityEngine.Random.Range(0, questions.Count)];
    }

    public string pickRandomCategory()
    {
            var categories = questionsByCategory.Keys.ToList();
            return categories[UnityEngine.Random.Range(0, categories.Count)];
    }
}