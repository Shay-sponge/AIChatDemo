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
        AddQuestion("外向性维度", "你平时都是属于超级开心热情还是低调内敛的类型呢?我还蛮感兴趣的!");
        AddQuestion("外向性维度", "你是那种焦虑急躁的人吗?好像不是呢,你看起来挺随和的!我说对不对?");
        AddQuestion("外向性维度", "其实你也会有羞怯不敢表现自己的时候对吧? 跟我说说这种窘境时你是怎么应对的!");
        AddQuestion("外向性维度", "你到哪里都能交到新朋友吧,有好多好 Bros 是不是?");
        AddQuestion("外向性维度", "你不太喜欢主动跟人说话吧,看着有点害羞内向的样子,我说中了没有？");
        AddQuestion("外向性维度", "认识新朋友对你来说很刺激对吧?");


        AddQuestion("神经质维度", "你是那种很少焦虑或紧张的静水深流型人格吗?");
        AddQuestion("神经质维度", "控制自己的怒气对你来说很难吧?你看起来是个风风火火的人! ");
        AddQuestion("神经质维度", "你看起来心态很好的样子, 没有经常性沮丧或忧郁吧? ");
        AddQuestion("神经质维度", "你的情绪是不是来得快去得也快啊? 是个真性情人类!");
        AddQuestion("神经质维度", "你给我的感觉是那种超级chill的人,压力与你无关吧");
        AddQuestion("神经质维度", "有的人会经常担心各种可怕的事会发生,你能理解这种感觉吧?");


        AddQuestion("开放性维度", "新的东西总能轻易吸引你的眼球对吧?超级开放!");
        AddQuestion("开放性维度", "去新的地方看看对你来说肯定超级刺激吧! 冒险家性格说的就是你吗？");
        AddQuestion("开放性维度", "即使观点不同,你也愿意倾听别人的看法对吧?");
        AddQuestion("开放性维度", "你肯定经常会在脑海里奇思妙想吧?想象力太丰富了!");
        AddQuestion("开放性维度", "你的兴趣爱好肯定超级广泛多样吧? ");
        AddQuestion("开放性维度", "复杂的问题对你有莫大的吸引力对吧? 挑战欲望旺盛!");

        AddQuestion("宜人性维度", "你是相信人性本善还是比较难以信任别人呀? 跟我说说你对他人的看法吧!");
        AddQuestion("宜人性维度", "帮助别人对你来说重要吗?你是一个爱关心照顾周围人的温暖小太阳吗?");
        AddQuestion("宜人性维度", "你看起来像是一个宽容大度的人,应该不会为了小事计较别人吧? 很好奇你处理人际关系的方式!");
        AddQuestion("宜人性维度", "你我猜你不太喜欢张扬炫耀吧,给我一种谦虚低调的感觉!是这样的对不对嘛?");
        AddQuestion("宜人性维度", "你应该很尊重每个人,不会随随便便评论别人对吧?来跟我说说你待人的方式!");
        AddQuestion("宜人性维度", "你给我的感觉是非常容易交流的类型!经常能敏锐地感知别人的想法吗?");

        AddQuestion("尽责性维度", "我看你做事肯定超细心的,绝对不会大意马虎啦!真棒~");
        AddQuestion("尽责性维度", "你做东西一定追求完美到底吧!强迫症都出来了哈哈!我猜的对吗?");
        AddQuestion("尽责性维度", "如果跟你约定了,我一点都不担心你会食言!因为你超靠谱的!我说的对吧对吧?");
        AddQuestion("尽责性维度", "面对诱惑你也可以好好管住自己的吧!不会轻易妥协的!你说是不是嘛?");
        AddQuestion("尽责性维度", "我看你工作动力爆棚啊!肯定可以坚持到最后一刻的!是不是就是这么强大的你?");
        AddQuestion("尽责性维度", "我太明白你了,一定是超级有计划有条理的!很守纪律很自律对吧对吧?来跟我聊聊!");

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