using System;

class program
{
    public static void main(string args[])
    {
        console.writeLine("witaj w kursie git, jak masz na imię ?");
        string name = console.readLine();
        if(name.length != 0){
            console.writeLine("Witaj na pokładzie, " + name);
        }
        else{
            console.writeLine("dlaczego nie chcesz się przedstawic ? Nie podoba ci się mój program ?");
        }
    }
}
