double ladoa = 5;
double ladob = 10;
double ladoc = 15;
double angulod = 20;
double altura = 30;
double perimetro = Application253E05.Trapecio.Perimetro(ladoa, ladob, ladoc);
double area = Application253E05.Trapecio.Area(angulod, ladob, ladoc);
double volumen = Application253E05.Trapecio.Volumen(area, altura);

Console.WriteLine($"El perímetro del trapecio  es dos veces el ladoa + ladob + ladoc {2*ladoa}+{ladob}+{ladoc}cm el perimetro es de {perimetro}cm");
Console.WriteLine($"El área del trapecio es angulod * ladob + ladoc/2 {angulod} *{ladob} + {ladoc}/2 el area es de {area}cm2");
Console.WriteLine($"El volumen un Trapecio con un área de {area}cm2 y {altura}cm de altura es {volumen}cm3");