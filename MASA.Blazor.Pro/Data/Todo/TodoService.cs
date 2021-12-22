﻿namespace MASA.Blazor.Pro.Data;

public class TodoService
{
    public static List<TodoData> List = new()
    {
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "汉皇重色思倾国，御宇多年求不得。", Assignee = "紫萱", Avatar = 0, DueDate = new DateOnly(2021, 9, 15), Tag = new List<string> { "Low", }, Description = "1、最灵繁的人也看不见自己的背脊。——非洲" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "杨家有女初长成，养在深闺人未识。", Assignee = "若芹", Avatar = 2, DueDate = new DateOnly(2021, 9, 16), Tag = new List<string> { "Low" }, Description = "2、最困难的事情就是认识自己。——希腊" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "天生丽质难自弃，一朝选在君王侧。", Assignee = "思菱", Avatar = 1, DueDate = new DateOnly(2021, 9, 17), Tag = new List<string> { "Low" }, Description = "3、有勇气承担命运这才是英雄好汉。——黑塞" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "回眸一笑百媚生，六宫粉黛无颜色。", Assignee = "向秋", Avatar = 3, DueDate = new DateOnly(2021, 9, 18), Tag = new List<string> { "Low" }, Description = "4、与肝胆人共事，无字句处读书。——周恩来" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = true, IsDeleted = false, Title = "春寒赐浴华清池，温泉水滑洗凝脂。", Assignee = "雨珍", Avatar = 4, DueDate = new DateOnly(2021, 9, 19), Tag = new List<string> { "Low" }, Description = "5、阅读使人充实，会谈使人敏捷，写作使人精确。——培根" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "侍儿扶起娇无力，始是新承恩泽时。", Assignee = "海瑶", Avatar = 1, DueDate = new DateOnly(2021, 9, 20), Tag = new List<string> { "High" }, Description = "6、最大的骄傲于最大的自卑都表示心灵的最软弱无力。——斯宾诺莎" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = true, IsDeleted = false, Title = "云鬓花颜金步摇，芙蓉帐暖度春宵。", Assignee = "乐萱", Avatar = 2, DueDate = new DateOnly(2021, 9, 21), Tag = new List<string> { "High" }, Description = "7、自知之明是最难得的知识。——西班牙" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "春宵苦短日高起，从此君王不早朝。", Assignee = "紫萱", Avatar = 1, DueDate = new DateOnly(2021, 9, 22), Tag = new List<string> { "High" }, Description = "8、勇气通往天堂，怯懦通往地狱。——塞内加" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "承欢侍宴无闲暇，春从春游夜专夜。", Assignee = "若芹", Avatar = 3, DueDate = new DateOnly(2021, 9, 23), Tag = new List<string> { "High" }, Description = "9、有时候读书是一种巧妙地避开思考的方法。——赫尔普斯" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "后宫佳丽三千人，三千宠爱在一身。", Assignee = "思菱", Avatar = 1, DueDate = new DateOnly(2021, 9, 24), Tag = new List<string> { "High" }, Description = "10、阅读一切好书如同和过去最杰出的人谈话。——笛卡儿" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "金屋妆成娇侍夜，玉楼宴罢醉和春。", Assignee = "向秋", Avatar = 4, DueDate = new DateOnly(2021, 9, 25), Tag = new List<string> { "High" }, Description = "11、越是没有本领的就越加自命不凡。——邓拓" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "姊妹弟兄皆列土，可怜光彩生门户。", Assignee = "雨珍", Avatar = 0, DueDate = new DateOnly(2021, 9, 26), Tag = new List<string> { "High" }, Description = "12、越是无能的人，越喜欢挑剔别人的错儿。——爱尔兰" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "遂令天下父母心，不重生男重生女。", Assignee = "海瑶", Avatar = 0, DueDate = new DateOnly(2021, 9, 27), Tag = new List<string> { "Medium" }, Description = "13、知人者智，自知者明。胜人者有力，自胜者强。——老子" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "骊宫高处入青云，仙乐风飘处处闻。", Assignee = "乐萱", Avatar = 4, DueDate = new DateOnly(2021, 9, 28), Tag = new List<string> { "Medium" }, Description = "14、意志坚强的人能把世界放在手中像泥块一样任意揉捏。——歌德" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "缓歌慢舞凝丝竹，尽日君王看不足。", Assignee = "紫萱", Avatar = 1, DueDate = new DateOnly(2021, 9, 29), Tag = new List<string> { "Medium" }, Description = "15、最具挑战性的挑战莫过于提升自我。——迈克尔·F·斯特利" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "渔阳鼙鼓动地来，惊破霓裳羽衣曲。", Assignee = "若芹", Avatar = 4, DueDate = new DateOnly(2021, 9, 30), Tag = new List<string> { "Medium" }, Description = "16、业余生活要有意义，不要越轨。——华盛顿" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "九重城阙烟尘生，千乘万骑西南行。", Assignee = "思菱", Avatar = 4, DueDate = new DateOnly(2021, 10, 1), Tag = new List<string> { "Medium" }, Description = "17、一个人即使已登上顶峰，也仍要自强不息。——罗素·贝克" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "翠华摇摇行复止，西出都门百余里。", Assignee = "向秋", Avatar = 4, DueDate = new DateOnly(2021, 10, 2), Tag = new List<string> { "Medium" }, Description = "18、最大的挑战和突破在于用人，而用人最大的突破在于信任人。——马云" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "六军不发无奈何，宛转蛾眉马前死。", Assignee = "雨珍", Avatar = 0, DueDate = new DateOnly(2021, 10, 3), Tag = new List<string> { "Medium" }, Description = "19、自己活着，就是为了使别人过得更美好。——雷锋" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "花钿委地无人收，翠翘金雀玉搔头。", Assignee = "海瑶", Avatar = 0, DueDate = new DateOnly(2021, 10, 4), Tag = new List<string> { "Team" }, Description = "20、要掌握书，莫被书掌握；要为生而读，莫为读而生。——布尔沃" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "君王掩面救不得，回看血泪相和流。", Assignee = "乐萱", Avatar = 3, DueDate = new DateOnly(2021, 10, 5), Tag = new List<string> { "Team" }, Description = "21、要知道对好事的称颂过于夸大，也会招来人们的反感轻蔑和嫉妒。——培根" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "黄埃散漫风萧索，云栈萦纡登剑阁。", Assignee = "紫萱", Avatar = 4, DueDate = new DateOnly(2021, 10, 6), Tag = new List<string> { "Team" }, Description = "22、业精于勤，荒于嬉；行成于思，毁于随。——韩愈" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = true, IsDeleted = false, Title = "峨嵋山下少人行，旌旗无光日色薄。", Assignee = "若芹", Avatar = 4, DueDate = new DateOnly(2021, 10, 7), Tag = new List<string> { "Team" }, Description = "23、一切节省，归根到底都归结为时间的节省。——马克思" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "蜀江水碧蜀山青，圣主朝朝暮暮情。", Assignee = "思菱", Avatar = 4, DueDate = new DateOnly(2021, 10, 8), Tag = new List<string> { "Team" }, Description = "24、意志命运往往背道而驰，决心到最后会全部推倒。——莎士比亚" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "行宫见月伤心色，夜雨闻铃肠断声。", Assignee = "向秋", Avatar = 1, DueDate = new DateOnly(2021, 10, 9), Tag = new List<string> { "Team" }, Description = "25、学习是劳动，是充满思想的劳动。——乌申斯基" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = false, IsDeleted = true, Title = "天旋地转回龙驭，到此踌躇不能去。", Assignee = "雨珍", Avatar = 1, DueDate = new DateOnly(2021, 10, 10), Tag = new List<string> { "Team" }, Description = "26、要使整个人生都过得舒适、愉快，这是不可能的，因为人类必须具备一种能应付逆境的态度。——卢梭" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "马嵬坡下泥土中，不见玉颜空死处。", Assignee = "海瑶", Avatar = 2, DueDate = new DateOnly(2021, 10, 11), Tag = new List<string> { "Team" }, Description = "27、只有把抱怨环境的心情，化为上进的力量，才是成功的保证。——罗曼·罗兰" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = true, IsDeleted = true, Title = "君臣相顾尽沾衣，东望都门信马归。", Assignee = "乐萱", Avatar = 2, DueDate = new DateOnly(2021, 10, 12), Tag = new List<string> { "Low" }, Description = "28、知之者不如好之者，好之者不如乐之者。——孔子" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "归来池苑皆依旧，太液芙蓉未央柳。", Assignee = "紫萱", Avatar = 1, DueDate = new DateOnly(2021, 10, 13), Tag = new List<string> { "Low" }, Description = "29、勇猛、大胆和坚定的决心能够抵得上武器的精良。——达·芬奇" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "芙蓉如面柳如眉，对此如何不泪垂。", Assignee = "若芹", Avatar = 1, DueDate = new DateOnly(2021, 10, 14), Tag = new List<string> { "Low" }, Description = "30、意志是一个强壮的盲人，倚靠在明眼的跛子肩上。——叔本华" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "春风桃李花开夜，秋雨梧桐叶落时。", Assignee = "思菱", Avatar = 1, DueDate = new DateOnly(2021, 10, 15), Tag = new List<string> { "Low" }, Description = "31、只有永远躺在泥坑里的人，才不会再掉进坑里。——黑格尔" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = true, IsDeleted = true, Title = "西宫南苑多秋草，落叶满阶红不扫。", Assignee = "向秋", Avatar = 3, DueDate = new DateOnly(2021, 10, 16), Tag = new List<string> { "Low" }, Description = "32、希望的灯一旦熄灭，生活刹那间变成了一片黑暗。——普列姆昌德" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "梨园弟子白发新，椒房阿监青娥老。", Assignee = "雨珍", Avatar = 3, DueDate = new DateOnly(2021, 10, 17), Tag = new List<string> { "Low" }, Description = "33、希望是人生的乳母。——科策布" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = true, IsDeleted = false, Title = "夕殿萤飞思悄然，孤灯挑尽未成眠。", Assignee = "海瑶", Avatar = 1, DueDate = new DateOnly(2021, 10, 18), Tag = new List<string> { "Low" }, Description = "34、形成天才的决定因素应该是勤奋。——郭沫若" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "迟迟钟鼓初长夜，耿耿星河欲曙天。", Assignee = "乐萱", Avatar = 1, DueDate = new DateOnly(2021, 10, 19), Tag = new List<string> { "High" }, Description = "35、学到很多东西的诀窍，就是一下子不要学很多。——洛克" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = false, IsDeleted = true, Title = "鸳鸯瓦冷霜华重，翡翠衾寒谁与共。", Assignee = "紫萱", Avatar = 1, DueDate = new DateOnly(2021, 10, 20), Tag = new List<string> { "High" }, Description = "36、自己的鞋子，自己知道紧在哪里。——西班牙" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "悠悠生死别经年，魂魄不曾来入梦。", Assignee = "若芹", Avatar = 2, DueDate = new DateOnly(2021, 10, 21), Tag = new List<string> { "High" }, Description = "37、我们唯一不会改正的缺点是软弱。——拉罗什福科" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = true, Title = "临邛道士鸿都客，能以精诚致魂魄。", Assignee = "思菱", Avatar = 0, DueDate = new DateOnly(2021, 10, 22), Tag = new List<string> { "High" }, Description = "38、我这个人走得很慢，但是我从不后退。——亚伯拉罕·林肯" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "为感君王辗转思，遂教方士殷勤觅。", Assignee = "向秋", Avatar = 1, DueDate = new DateOnly(2021, 10, 23), Tag = new List<string> { "High" }, Description = "39、勿问成功的秘诀为何，且尽全力做你应该做的事吧。——美华纳" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "排空驭气奔如电，升天入地求之遍。", Assignee = "雨珍", Avatar = 4, DueDate = new DateOnly(2021, 10, 24), Tag = new List<string> { "High" }, Description = "40、学而不思则罔，思而不学则殆。——孔子" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = true, IsDeleted = true, Title = "上穷碧落下黄泉，两处茫茫皆不见。", Assignee = "海瑶", Avatar = 1, DueDate = new DateOnly(2021, 10, 25), Tag = new List<string> { "High" }, Description = "41、学问是异常珍贵的东西，从任何源泉吸收都不可耻。——阿卜·日·法拉兹" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "忽闻海上有仙山，山在虚无缥渺间。", Assignee = "乐萱", Avatar = 3, DueDate = new DateOnly(2021, 10, 26), Tag = new List<string> { "High" }, Description = "42、只有在人群中间，才能认识自己。——德国" },
        new TodoData { IsChecked = false, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "楼阁玲珑五云起，其中绰约多仙子。", Assignee = "紫萱", Avatar = 1, DueDate = new DateOnly(2021, 10, 27), Tag = new List<string> { "High" }, Description = "43、重复别人所说的话，只需要教育；而要挑战别人所说的话，则需要头脑。——玛丽·佩蒂博恩·普尔" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = true, Title = "中有一人字太真，雪肤花貌参差是。", Assignee = "若芹", Avatar = 1, DueDate = new DateOnly(2021, 10, 28), Tag = new List<string> { "High" }, Description = "44、卓越的人一大优点是：在不利与艰难的遭遇里百折不饶。——贝多芬" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "金阙西厢叩玉扃，转教小玉报双成。", Assignee = "思菱", Avatar = 2, DueDate = new DateOnly(2021, 10, 29), Tag = new List<string> { "High" }, Description = "45、自己的饭量自己知道。——苏联" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "闻道汉家天子使，九华帐里梦魂惊。", Assignee = "向秋", Avatar = 2, DueDate = new DateOnly(2021, 10, 30), Tag = new List<string> { "High" }, Description = "46、我们若已接受最坏的，就再没有什么损失。——卡耐基" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "揽衣推枕起徘徊，珠箔银屏迤逦开。", Assignee = "雨珍", Avatar = 2, DueDate = new DateOnly(2021, 11, 1), Tag = new List<string> { "High" }, Description = "47、书到用时方恨少、事非经过不知难。——陆游" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "云鬓半偏新睡觉，花冠不整下堂来。", Assignee = "海瑶", Avatar = 1, DueDate = new DateOnly(2021, 11, 2), Tag = new List<string> { "Update" }, Description = "48、书籍把我们引入最美好的社会，使我们认识各个时代的伟大智者。——史美尔斯" },
        new TodoData { IsChecked = false, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "风吹仙袂飘飖举，犹似霓裳羽衣舞。", Assignee = "乐萱", Avatar = 1, DueDate = new DateOnly(2021, 11, 3), Tag = new List<string> { "Update" }, Description = "49、熟读唐诗三百首，不会作诗也会吟。——孙洙" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = true, IsDeleted = false, Title = "玉容寂寞泪阑干，梨花一枝春带雨。", Assignee = "紫萱", Avatar = 4, DueDate = new DateOnly(2021, 11, 4), Tag = new List<string> { "Update" }, Description = "50、谁和我一样用功，谁就会和我一样成功。——莫扎特" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = true, IsDeleted = false, Title = "含情凝睇谢君王，一别音容两渺茫。", Assignee = "若芹", Avatar = 4, DueDate = new DateOnly(2021, 11, 5), Tag = new List<string> { "Update" }, Description = "51、天下之事常成于困约，而败于奢靡。——陆游" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "昭阳殿里恩爱绝，蓬莱宫中日月长。", Assignee = "思菱", Avatar = 4, DueDate = new DateOnly(2021, 11, 6), Tag = new List<string> { "Update" }, Description = "52、生命不等于是呼吸，生命是活动。——卢梭" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = false, IsDeleted = false, Title = "回头下望人寰处，不见长安见尘雾。", Assignee = "向秋", Avatar = 1, DueDate = new DateOnly(2021, 11, 7), Tag = new List<string> { "Update" }, Description = "53、伟大的事业，需要决心，能力，组织和责任感。　——易卜生" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "惟将旧物表深情，钿合金钗寄将去。", Assignee = "雨珍", Avatar = 1, DueDate = new DateOnly(2021, 11, 8), Tag = new List<string> { "Update" }, Description = "54、唯书籍不朽。——乔特" },
        new TodoData { IsChecked = true, IsImportant = true, IsCompleted = true, IsDeleted = false, Title = "钗留一股合一扇，钗擘黄金合分钿。", Assignee = "海瑶", Avatar = 3, DueDate = new DateOnly(2021, 11, 9), Tag = new List<string> { "Update" }, Description = "55、为中华之崛起而读书。——周恩来" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "但令心似金钿坚，天上人间会相见。", Assignee = "乐萱", Avatar = 3, DueDate = new DateOnly(2021, 11, 10), Tag = new List<string> { "Update" }, Description = "56、书不仅是生活，而且是现在、过去和未来文化生活的源泉。——库法耶夫" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "临别殷勤重寄词，词中有誓两心知。", Assignee = "紫萱", Avatar = 1, DueDate = new DateOnly(2021, 11, 11), Tag = new List<string> { "Update" }, Description = "57、生命不可能有两次，但许多人连一次也不善于度过。——吕凯特" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "七月七日长生殿，夜半无人私语时。", Assignee = "若芹", Avatar = 1, DueDate = new DateOnly(2021, 11, 12), Tag = new List<string> { "Update" }, Description = "58、问渠哪得清如许，为有源头活水来。——朱熹" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = false, IsDeleted = false, Title = "在天愿作比翼鸟，在地愿为连理枝。", Assignee = "思菱", Avatar = 1, DueDate = new DateOnly(2021, 11, 13), Tag = new List<string> { "Update" }, Description = "59、我的努力求学没有得到别的好处，只不过是愈来愈发觉自己的无知。——笛卡儿" },
        new TodoData { IsChecked = true, IsImportant = false, IsCompleted = true, IsDeleted = false, Title = "天长地久有时尽，此恨绵绵无绝期。", Assignee = "向秋", Avatar = 1, DueDate = new DateOnly(2021, 11, 14), Tag = new List<string> { "Update" }, Description = "60、生活的道路一旦选定，就要勇敢地走到底，决不回头。——左拉" },
    };
}
