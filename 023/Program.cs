﻿// 23.Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y : ¬ -! 
// отрицание  ⋁ -||или ⋀ -&& и (перемножение)
//!(X || Y)==!X && !Y

System.Console.WriteLine("X Y !(X | Y)==!X & !Y");
System.Console.WriteLine($"0 0 {Convert.ToInt32(!(false || false)),5}{Convert.ToInt32(!false && !false),9}");
System.Console.WriteLine($"0 1 {Convert.ToInt32(!(false || true)),5}{Convert.ToInt32(!false && !true),9}");
System.Console.WriteLine($"1 0 {Convert.ToInt32(!(true || false)),5}{Convert.ToInt32(!true && !false),9}");
System.Console.WriteLine($"1 1 {Convert.ToInt32(!(true || true)),5}{Convert.ToInt32(!true && !true),9}");