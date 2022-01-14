using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            


            // Создаем массивы для новеллы
            string[] message = new string[5]
           {"Привет!",
             "Как тебя зовут?",
             "Мое имя Андрей! А твое {0}. Будем знакомы!",
             "Хочешь сыграть в игру?",
             "Отлично! Давай начнем прямо сейчас!",

           };

            string[] messageTex = new string[3]
            {
                "Хорошенько подумай",
                "Я тебя не понимаю",
                "Выбери один из вариантов ответа"
            };

            string[,,] history = new string[3, 3, 3];
            history[0, 0, 0] = "Короче, {0}, я тебя спас и в благородство играть не буду: выполнишь для меня пару заданий – и мы в расчете.";
            history[0, 0, 1] = "Заодно посмотрим, как быстро у тебя башка после амнезии прояснится. А по твоей теме постараюсь разузнать.";
            history[0, 0, 2] = "Хрен его знает, на кой ляд тебе этот Стрелок сдался, но я в чужие дела не лезу, хочешь убить, значит есть за что…";
            history[0, 1, 0] = "Выбирай, как мы с тобой поступим: либо я тебе сейчас мозги буду полоскать, как я обычно новичкам это делаю, либо я буду с тобой как с опытным сталкером: получай задание, и вперёд!";
            history[0, 2, 0] = "Есть дело, {0}.Надо найти сталкера по кличке Шустрый. Он нёс мне важную информацию.Пропал он где - то в районе моста.";
            history[0, 2, 1] = "Его надо найти и забрать информацию, у живого или мёртвого — мне всё равно.Сходи к Волку из местного лагеря, расспроси его.Наверняка он знает, где тот может быть.";
            history[0, 2, 2] = "Короче тут надо тыкать 1, 2 или 3 для выбора варианта. Можно двигать сюжет";

            string[,] answerI = new string[3, 3];
            answerI[0, 0] = "1 - Да";
            answerI[0, 1] = "2 - Нет";
            answerI[0, 2] = "3 - Сарказм";
            answerI[1, 0] = "1 - Давай как с новичком.Ничего не помню.";
            answerI[1, 1] = "2 - Давай как с опытным.";
            answerI[2, 0] = "1 - Я отказываюсь";
            answerI[2, 1] = "2 - Продолжай";
            answerI[2, 2] = "3 - Сарказм";

            string[,] dvijenie = new string[4, 4];
            dvijenie[0, 0] = "1 - Пойти за флешкой";
            dvijenie[0, 1] = "2 - Пойти за артефактами";
            dvijenie[0, 2] = "3 - Пойти к волку";
            dvijenie[1, 0] = "Ты пошел за флешкой без оружия и тебя убили";
            dvijenie[1, 1] = "Ты пошел за артефактами и тебя убили";
            dvijenie[1, 2] = "Ты пошел к волку и начал с ним диалог";
            dvijenie[2, 0] = "Гуляя по зоне ты попал в бар";
            dvijenie[2, 1] = "В баре ты встретил бармена и начал с ним диалог";
            dvijenie[2, 2] = "Здарова. Зачем пришел?";
            dvijenie[3, 0] = "Гуляя по зоне ты нашел кучу денег";
            dvijenie[3, 1] = "Идя по зоне с гордой походкой и полным кошельком ты встретил бандитов";
            dvijenie[3, 2] = "Кошелек или жизнь!";




            string[,] volk = new string[3, 7];

            volk[0, 0] = "Привет. Зачем пришёл?";
            volk[0, 1] = "Неподалёку на его группу бандиты напали, и Шустрого увели с собой, он только и успел, что SOS скинуть.";
            volk[0, 2] = "Поможешь с бандюками разобраться?";
            volk[0, 3] = "Значит, таки слабо... Ну и вали к чёртовой бабушке!";
            volk[0, 4] = "Уважаю! Вот тебе оружие и припасы, координаты парней я тебе скинул. Насчёт тебя сейчас предупрежу.";
            volk[2, 5] = "Получен предмет: ПМм";
            volk[2, 6] = "Получен предмет: Патроны 9 x 18мм";


            volk[1, 0] = "1 - Я попробую.";
            volk[1, 1] = "2 - Не слабо. Но не пойду.";


            string[,] variant = new string[3, 3];
            variant[0, 0] = "1 - Давай я в одиночку";
            variant[0, 1] = "2 - Давай вместе";
            variant[1, 0] = "1 - Отправиться к Сидоровичу и отдать ему флешку";
            variant[1, 1] = "2 - Пойти путешествовать по зоне";

            string[,] sidorovich = new string[3, 3];
            sidorovich[0, 0] = "Ты пришел к сидоровичу и начал с ним диалог";
            sidorovich[0, 1] = "Здарова {0}. Выполнил задание?";

            string name;
            int otvet;
            bool no = true;

            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            /* Ввод имени пользователя */
            name = Console.ReadLine();
            Console.WriteLine(message[2], name);

            Console.WriteLine(message[3]);
            // Работает до тех пор пока пользователь не нажмет 1
            do
            {
                Console.WriteLine(answerI[0, 0]);
                if (no) Console.WriteLine(answerI[0, 1]);

                otvet = Convert.ToInt32(Console.ReadLine());
                if (otvet == 1)
                {
                    Console.WriteLine(message[4]);
                }
                else if (otvet == 2 && no)
                {
                    Console.WriteLine(messageTex[0]);
                    no = false;
                }
                else
                {
                    Console.WriteLine(messageTex[1]);
                }
            } while (otvet != 1);
            // Цикл для начала истории
            for (int i = 0; i < 3; i++) Console.WriteLine(history[0, 0, i], name);

            Console.WriteLine();

            Console.WriteLine(history[0, 1, 0]);
            Console.WriteLine();


            do
            {
                Console.WriteLine(answerI[1, 0]);
                Console.WriteLine(answerI[1, 1]);

                otvet = Convert.ToInt32(Console.ReadLine());

                if (otvet == 1)
                {
                    Console.WriteLine(history[0, 2, 2]);
                    for (int i = 0; i < 2; i++) Console.WriteLine(history[0, 2, i], name);
                }
                else if (otvet == 2)
                {
                    for (int i = 0; i < 2; i++) Console.WriteLine(history[0, 2, i], name);
                }
                else
                {
                    Console.WriteLine(messageTex[2]);
                }
            } while (otvet != 1 && otvet != 2);

            // Варианты ответов 
            for (int i = 0; i < 3; i++) Console.WriteLine(answerI[2, i]);
            // Ввод ответа и его проверка и движение по сюжету
            Console.WriteLine();
            otvet = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (otvet)
                {
                    case 1:
                        Console.WriteLine("Сидорович достал свой дробовик и на этом все");
                        System.Environment.Exit(0);
                        break;
                    case 2:
                        Console.WriteLine("Да всё пока. Принесёшь мне флешку, и будем считать, что частично за своё спасение ты расплатился.");
                        break;
                    case 3:
                        Console.WriteLine("Ты че быкуешь иди за флешкой {0}", name);
                        break;
                    default:
                        Console.WriteLine(messageTex[2]);
                        throw new Exception("2");
                }
            }
            catch (Exception e) { };

            for (int i = 0; i < 3; i++) Console.WriteLine(dvijenie[0, i]);
            otvet = Convert.ToInt32(Console.ReadLine());
            // Проверка ответа пользователя 
            try
            {
                switch (otvet)
                {
                    case 1:
                        Console.WriteLine(dvijenie[1, 0]);
                        System.Environment.Exit(0);
                        break;
                    case 2:
                        Console.WriteLine(dvijenie[1, 1]);
                        Environment.Exit(0);
                        break;
                    case 3:
                        Console.WriteLine(dvijenie[1, 2]);
                        break;
                    default:
                        Console.WriteLine(messageTex[2]);
                        throw new Exception("3");
                }
            }
            catch (Exception e) { };
            // Цикл для диалога с волком 
            for (int i = 0; i < 3; i++) Console.WriteLine(volk[0, i]);

            Console.WriteLine();
            // Цикл для диалога с волком 
            for (int i = 0; i < 2; i++) Console.WriteLine(volk[1, i]);
            // Ответ на диалог с волком 
            otvet = Convert.ToInt32(Console.ReadLine());
            // Проверка ответа и движение по сюжету
            try
            {
                switch (otvet)
                {
                    case 1:
                        Console.WriteLine(volk[0, 4]);
                        for (int i = 5; i < 7; i++) Console.WriteLine(volk[0, i]);
                        break;
                    case 2:
                        Console.WriteLine(volk[0, 3]);
                        Console.WriteLine("Ты отправился на поиски приключений");
                        Console.ReadKey();
                        Console.WriteLine("Путешествуя по зоне ты попал на ЧАЭС");
                        Console.ReadKey();
                        Console.WriteLine("Ты встретил исполнителя желания");
                        Console.ReadKey();
                        Console.WriteLine("Так как ты очень быстро прошел игру он одарил тебя бессмертием");
                        System.Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine(messageTex[2]);
                        throw new Exception("1");


                }
            }
            catch (Exception e) { };
            
            Console.WriteLine("Ты отправился на помощь к своим");
            Console.WriteLine("Здарова. Про тебя волк говорил?");
            Console.WriteLine();
            Console.WriteLine("1 - Да");
            Console.WriteLine("2 - Нет");
            Convert.ToInt32(Console.ReadLine());


            if (otvet == 1)
            {
                Console.WriteLine("Отлично. Там бандитов много. Как будем действовать?");
            }
            else if (otvet == 2)

            {
                Console.WriteLine("Хорошая шутка. Там бандитов много. Как будем действовать?");
            }

            for (int i = 0; i < 2; i++) Console.WriteLine(variant[0, i]);
            Convert.ToInt32(Console.ReadLine());
            
            try
            {
                switch (otvet)
                {
                    case 1:
                        Console.WriteLine("Ты отправился в одиночку");
                        break;
                    case 2:
                        Console.WriteLine("Вы отправили вместе");
                        break;
                    default:
                        Console.WriteLine(messageTex[2]);
                        throw new Exception();
                }

            }
            catch (Exception e) { };

            Console.WriteLine("Зачистка прошла успешно");
            Console.WriteLine("Ты нашел Шустрого и забрал у него флешку");

            for (int i = 0; i < 3; i++) Console.WriteLine(variant[1, i]);
            Console.WriteLine();

            otvet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            // Проверка ввода через switch
            switch (otvet)
            {
                case 1:
                    Console.WriteLine(sidorovich[0, 0]);
                    Console.WriteLine(sidorovich[0, 1], name);
                    Console.WriteLine("{0} - Да выполнил");
                    Console.WriteLine();
                    Console.WriteLine("Отлично! Отправляйся к бармену у него для тебя есть задание");
                    Console.WriteLine();
                    Console.WriteLine("Ты отправился к бармену");
                    for (int i = 1; i < 3; i++) Console.WriteLine(dvijenie[2, i]);
                    Console.WriteLine();
                    Console.WriteLine("{0} - Сидорович сказал у тебя есть для меня задание", name);
                    Console.WriteLine("Да он прав. Отправляйся к бандитам и забери у них документы");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("Ты отправился к бандитам и тебя убили так как у тебя не было оружия");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                    
                case 2:
                    Console.WriteLine(dvijenie[2, 0]);
                    Console.ReadKey();
                    Console.WriteLine(dvijenie[2, 1]);
                    Console.ReadKey();
                    Console.WriteLine(dvijenie[2, 2]);
                    Console.WriteLine("1 - Случайно зашел");
                    Console.WriteLine("2 - Задание есть?");
                    Console.WriteLine();
                    
                    
                    otvet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (otvet) //Продвижение по сюжету с помощью switch
                    {
                        case 1:
                            Console.WriteLine(dvijenie[3, 0]);
                            Console.ReadKey();
                            Console.WriteLine(dvijenie[3, 1]);
                            Console.WriteLine();
                            Console.WriteLine(dvijenie[3, 2]);
                            Console.WriteLine("1 - Заберите деньги только не убивайте!!!");
                            Console.WriteLine("2 - Нет");
                            Console.WriteLine(answerI[2, 2]);
                            Console.WriteLine();
                            otvet = Convert.ToInt32(Console.ReadLine());
                            // Продвижение по сюжету с помощью switch при условии ранее введенного case 1
                            switch (otvet)
                            {
                                case 1:
                                    Console.WriteLine("Ты отдал деньги и пошел к сидоровичу");
                                    for (int i = 0; i < 3; i++) Console.WriteLine(sidorovich[0, i]);
                                    Console.WriteLine("{0} - Да", name);
                                    Console.WriteLine();
                                    Console.WriteLine("Отлично! Отправляйся к бармену у него для тебя есть задание");
                                    Console.WriteLine();
                                    Console.WriteLine("Ты отправился к бармену");
                                    for (int i = 1; i < 3; i++) Console.WriteLine(dvijenie[2, i]);
                                    Console.WriteLine();
                                    Console.WriteLine("{0} Сидорович сказал у тебя есть для меня задание", name);
                                    Console.WriteLine("Да он прав. Отправляйся к бандитам и забери у них документы");
                                    Console.WriteLine();
                                    Console.WriteLine("Ты отправился к бандитам и тебя убили так как у тебя не было оружия");
                                    Environment.Exit(0);

                                    break;
                                case 2:
                                    Console.WriteLine("Тебя убили");
                                    Environment.Exit(0);
                                    break;
                                case 3:
                                    Console.WriteLine("Ты достал пистолет который тебе дал волк и убил бандитов");
                                    Console.ReadKey();
                                    Console.WriteLine("Идя по зоне ты наткнулся на исполнителя желаний");
                                    Console.ReadKey();
                                    Console.WriteLine("Он наградил тебя богатством");
                                    Environment.Exit(0);

                                    break;
                                default:
                                    Console.WriteLine(messageTex);
                                    break;

                            }
                            break;
                        case 2:
                            Console.WriteLine("Отправляйся к бандитам и забери у них документы");
                            Console.ReadKey();
                            Console.WriteLine("Ты отправился к бандитам но не дошел так как попал в радиацию и умер");
                            Environment.Exit(0);
                            break;


                            break;
                        default:
                            Console.WriteLine(messageTex[2]);
                            break;

                    }
                    break;
                    

            }




        }

    }

}