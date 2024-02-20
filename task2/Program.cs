int x = -3;
int y = 2;
if (x > 0 && y > 0){
    Console.Write("1");
}else if (x < 0 && y > 0){
    Console.Write("2");
}else if (x < 0 && y < 0){
    Console.Write("3");
}else if (x > 0 && y < 0){
    Console.Write("4");
}else{
    Console.Write("х и у не могут быть равны 0, введите другие координаты");
}
