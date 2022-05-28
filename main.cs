using System;

class program
{
    public static void main(string args[])
    {
    	void showName(name){
    		console.writeLine("Witaj na pokładzie, " + name);
    	}
        void errorName(){
            console.writeLine("dlaczego nie chcesz się przedstawic ? Nie podoba ci się mój program ?");
        }
        console.writeLine("witaj w kursie git, jak masz na imię ?");
        string name = console.readLine();
        if(name.length != 0){
            showName(name);
        }
        else{
            errorName();
        }
    }
}
