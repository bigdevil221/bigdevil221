namespace demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, dynamic> arr = new()
            //{
            //    ["牛牛"] = 180
            //};
            //arr.Remove("牛牛");
            //Console.WriteLine(arr.ContainsKey("牛牛"));
            //Console.WriteLine(arr.Count);

            //arr.Add("图图", 120);
            //arr.Add("牛爷爷", 170);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in arr.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in arr.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //arr.TryAdd("图图", 120);
            //arr.TryAdd("小丽妈", false);

            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //List<int> newlist = [];
            //foreach (int i in ints)
            //{
            //    if (!newlist.Contains(i)) newlist.Add(i);
            //}
            //foreach (int item in newlist) Console.WriteLine(item); ;
            //***********************************************
            //Dictionary <int,dynamic> dic= new Dictionary<int,dynamic>();
            //foreach (int i in ints)
            //{
            //    dic[i] = "任意值";
            //}
            //List<int> newlist = dic.Keys.ToList();

            //foreach (var item in newlist) Console.WriteLine(item);
            //********************************************
            //List<int> ints = [1, 3, 4, 5, 6, 7, 8, 2,9];
            //for (int i = 0; i < ints.Count-1; i++) {
            //    for (int j = 0; j < ints.Count-1-i; j++) {
            //        if (ints[j] > ints[j+1])
            //        {
            //            int nul = ints[j];
            //            ints[j] = ints[j+1];
            //            ints[j + 1] = nul;
            //        }
            //    }

            //}
            //foreach (int item in ints) Console.WriteLine(item);
            //****************************************
            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"name", "机械键盘"},
                    {"price", 299.99},
                    {"code", "G001"},
                    {"stock", 120}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "无线鼠标"},
                    {"price", 89.50},
                    {"code", "G002"},
                    {"stock", 356}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "27寸显示器"},
                    {"price", 1299.00},
                    {"code", "G003"},
                    {"stock", 48}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电竞耳机"},
                    {"price", 199.00},
                    {"code", "G004"},
                    {"stock", 85}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电脑支架"},
                    {"price", 69.90},
                    {"code", "G005"},
                    {"stock", 210}
                }
            };
            Console.WriteLine("请输入排序类型price还是stock");
            string type1= Console.ReadLine();
            Console.WriteLine("请输入排序顺序(asc or dsc)");
            string type2 = Console.ReadLine();
            if (type1== "price")
            {
                if (type2== "asc")
                {
                    for (int i = 0; i < goodsList.Count - 1; i++)
                    {
                        for (int j = 0; j < goodsList.Count - 1 - i; j++)
                        {
                            if (goodsList[j]["price"] > goodsList[j + 1]["price"])
                            {
                                dynamic nul = goodsList[j];
                                goodsList[j] = goodsList[j + 1];
                                goodsList[j + 1] = nul;
                            }
                        }

                    }
                    foreach (var item in goodsList) Console.WriteLine($"{item["name"]}{item["price"]}");
                }
                else if(type2== "dsc")
                {
                    for (int i = 0; i < goodsList.Count - 1; i++)
                    {
                        for (int j = 0; j < goodsList.Count - 1 - i; j++)
                        {
                            if (goodsList[j]["price"] < goodsList[j + 1]["price"])
                            {
                                dynamic nul = goodsList[j];
                                goodsList[j] = goodsList[j + 1];
                                goodsList[j + 1] = nul;
                            }
                        }

                    }
                    foreach (var item in goodsList) Console.WriteLine($"{item["name"]}{item["price"]}");
                }
            }
            else if(type1 == "stock")
            {
                if (type2 == "asc")
                {
                    for (int i = 0; i < goodsList.Count - 1; i++)
                    {
                        for (int j = 0; j < goodsList.Count - 1 - i; j++)
                        {
                            if (goodsList[j]["stock"] > goodsList[j + 1]["stock"])
                            {
                                dynamic nul = goodsList[j];
                                goodsList[j] = goodsList[j + 1];
                                goodsList[j + 1] = nul;
                            }
                        }

                    }
                    foreach (var item in goodsList) Console.WriteLine($"{item["name"]}{item["stock"]}");
                }
                else if (type2 == "dsc")
                {
                    for (int i = 0; i < goodsList.Count - 1; i++)
                    {
                        for (int j = 0; j < goodsList.Count - 1 - i; j++)
                        {
                            if (goodsList[j]["stock"] < goodsList[j + 1]["stock"])
                            {
                                dynamic nul = goodsList[j];
                                goodsList[j] = goodsList[j + 1];
                                goodsList[j + 1] = nul;
                            }
                        }

                    }
                    foreach (var item in goodsList) Console.WriteLine($"{item["name"]}{item["stock"]}");
                }
            }



        }
    }
}
