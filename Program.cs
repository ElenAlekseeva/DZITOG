string[] arrayInput = new string[] { "...", "..", "....", ".", "....." };

            string[] newArray = 
                (from ELEMENT in arrayInput 
                 where ELEMENT.Length <= 3 select ELEMENT)
                .ToArray();
                        for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("["+ i+ "]"+newArray[i]);
            }
            Console.ReadKey();
