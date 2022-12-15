string[] arrayInput = new string[] { "...", "..", "....", ".", "....." };

            string[] newArray = 
                (from ELEMENT in arrayInput 
                 where ELEMENT.Length <= 3 select ELEMENT)
                .ToArray();
                