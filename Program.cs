
          Console.WriteLine("Давай, пиши число, а я посмотрю куда его преобразовать");
        string Number = Console.ReadLine();



        bool changingType1 = sbyte.TryParse(Number, out _);
        if (changingType1)
        {
            Console.WriteLine($"Значение: {Number} , приведено к типу sbyte");
        }
        else
        {
            Console.WriteLine($"Для приведения числа: {Number}  к типу sbyte число не может быть больше:{sbyte.MaxValue} и меньше: {sbyte.MinValue}");
            //запускается при провале sbyte

            bool changingType2 = byte.TryParse(Number, out _);
            if (changingType2)
            {
                Console.WriteLine($"Значение: {Number} , приведено к типу byte");
            }
            else
            {
                Console.WriteLine($"Для приведения числа: {Number}  к типу byte число не может быть больше:{byte.MaxValue} и меньше: {byte.MinValue}");
                // запускается при провале byte

                bool changingType3 = short.TryParse(Number, out _);
                if (changingType3)
                {
                    Console.WriteLine($"Значение: {Number} , приведено к типу short");
                }
                else
                {
                    Console.WriteLine($"Для приведения числа: {Number}  к типу short число не может быть больше:{short.MaxValue} и меньше: {short.MinValue}");
                    // запускается при провале short

                    bool changingType4 = ushort.TryParse(Number, out _);
                    if (changingType4)
                    {
                        Console.WriteLine($"Значение: {Number} , приведено к типу ushort");
                    }
                    else
                    {
                        Console.WriteLine($"Для приведения числа: {Number}  к типу ushort число не может быть больше:{ushort.MaxValue} и меньше: {ushort.MinValue}");
                        //запускается при провале ushort
                        bool changingType5 = int.TryParse(Number, out _);
                        if (changingType5)
                        {
                            Console.WriteLine($"Значение: {Number} , приведено к типу int");
                        }
                        else
                        {
                            Console.WriteLine($"Для приведения числа: {Number}  к типу int число не может быть больше:{int.MaxValue} и меньше: {int.MinValue}");
                            //запускается при провале int
                            bool changingType6 = uint.TryParse(Number, out _);
                            if (changingType6)
                            {
                                Console.WriteLine($"Значение: {Number} , приведено к типу uint");
                            }
                            else
                            {
                                Console.WriteLine($"Для приведения числа: {Number}  к типу uint число не может быть больше:{uint.MaxValue} и меньше: {uint.MinValue}");
                                //запускается при провале uint
                                bool changingType7 = long.TryParse(Number, out _);
                                if (changingType7)
                                {
                                    Console.WriteLine($"Значение: {Number} , приведено к типу long");
                                }
                                else
                                {
                                    Console.WriteLine($"Для приведения числа: {Number}  к типу long число не может быть больше:{long.MaxValue} и меньше: {long.MinValue}");
                                    //запускается при провале long
                                    bool changingType8 = ulong.TryParse(Number, out _);
                                    if (changingType8)
                                    {
                                        Console.WriteLine($"Значение: {Number} , приведено к типу ulong");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Для приведения числа: {Number}  к типу ulong число не может быть больше:{ulong.MaxValue} и меньше: {ulong.MinValue}");
                                        Console.WriteLine("Братан, я не знаю в чем это хранить!!!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


    
