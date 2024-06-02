int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);
long l1 = 6;
//sum = l1 + i1; error CS0266: Не удается неявно преобразовать тип "long" в "int" 
//Если в операции участвуют разные по размеру виды данных, то результат будет в виде
//который больше по размеру. 
long sum2 = l1 + i1;
Console.WriteLine(sum2);
double d1 = 6.7;
double sum3 = d1 + i1;
Console.WriteLine(sum3);

int product1 = i1 * i2;
long product2 = l1 * i2;
double product3 = d1 * i2;
Console.WriteLine(" "+product1+" "+product2+" "+product3);

double quotient= i1 / d1;
Console.WriteLine(quotient);
double homeworkresult = i1*i2/(l1+d1);
Console.WriteLine(homeworkresult); 

