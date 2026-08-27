using System.Text.RegularExpressions;
using System.Text.Json;

namespace demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //传递的情报是一段看不懂的数字，明文是报纸或其他文章的一段，从文章中根据情报上的数字，找到对应的字，组合在一起形成真正的情报。
            //密码转文字
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "7-16-30-38-49-52-63-70";
            //string[] resalt = salt.Split("-");
            //string result = "";
            //for (int i = 0; i < resalt.Length; i++) {
            //        int index= int.Parse(resalt[i]);
            //        result += text[index];
            //}
            //Console.WriteLine(result);
            //文字转密码
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //string result = "";
            //for (int i = 0; i < salt.Length; i++) { 

            //    int index=text.IndexOf(salt[i]);
            //    result += (index.ToString()+" ");
            //}
            ////string realresult = string.Join("-", result); 误区！！！！！！！！！！！仅用于将数组或列表！！！！！！！！！！！！！！
            //Console.WriteLine(result);

            //生成密码 奇数+1 偶数-1
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //string result = "";
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    int index = text.IndexOf(salt[i]);
            //    if (index % 2 == 0)
            //    {
            //        index--;
            //        result += (index.ToString() + " ");
            //    }
            //    else
            //    {
            //        index++;
            //        result +=( index.ToString()+" ");
            //    }
            //}
            ////string realresult = string.Join("-", result); 误区！！！！！！！！！！！仅用于将数组或列表！！！！！！！！！！！！！！
            //Console.WriteLine(result);
            // 7-16-30-38-49-52-63-70 => 8-15-29-37-50-51-64-69 奇数+1 偶数-1
            //改为按原密码 7-16-30-38-49-52-63-70输出的密文 偶数-1 奇数+1
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "8-15-29-37-50-51-64-69";
            //string[] resalt = salt.Split("-");
            //string result = "";
            //for (int i = 0; i < resalt.Length; i++)
            //{
            //    int index = int.Parse(resalt[i]);
            //    index+=index % 2 == 0 ? -1 : 1;
            //    result += text[index];
            //}
            //Console.WriteLine(result);

            //数字转汉字 
            //int money = 140000056;
            //string str = money.ToString();
            //// 创建汉字数组
            //string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            //// 创建单位数组
            //string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            //string result = "";//存储结果
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    //获取单位下标，由于获得的是字符索引，需要转换为字符串，再转换为数字整型
            //    int index1 = int.Parse(str[i].ToString());
            //    int index2 = str.Length - 1 - i;
            //    if (index1 != 0 || units[index2] == "萬")
            //    {
            //        result = arr[index1] + units[index2] + result;
            //    }
            //    else result = arr[index1] + result;
            //}
            ////排除几种特殊情况
            ////零万 => 万   零零万=>万 零零零万=>万
            ////多个零都换成一个零
            //result = Regex.Replace(result, @"零+萬", "萬");
            //result = Regex.Replace(result, @"零+", "零");
            ////Substring：截取字符串 把最后一个零截掉
            //if (result.EndsWith("零")) result = result.Substring(0, result.Length - 1);
            //Console.WriteLine(result);


            //JSON序列化
            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                }
            };
            //var option = new JsonSerializerOptions()
            //{
            //    WriteIndented = true,//美化序列

            //};
            //string json = JsonSerializer.Serialize(singerList, option);
            //Console.WriteLine(json);

            //var result1 = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(result);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item["singerName"]);
            //}

            int[,] tables = new int[3, 3]
            {
                { 1,10,3},
                { 2,20,3},
                { 3,30,3},
            };;
            
            Console.WriteLine(tables.GetLength(0));//行
            Console.WriteLine(tables.GetLength(1));//列
            for (int i = 0; i < tables.GetLength(0); i++)
            {
                for (int j = 0; j < tables.GetLength(1); j++)
                {
                    Console.Write(tables[i,j]+" ");
                }
                Console.WriteLine();
            }



        }
    }
}
