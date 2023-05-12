//se creează o instanță a clasei RealLogger cu fișierul de jurnalizare "logfile.txt".
//Apoi, se apelează metoda LogThis() de două ori pe instanța realLogger, prima dată cu mesajul
//"the message 1" și nivelul de logare 2, iar a doua oară cu mesajul "the message 2" și nivelul de logare 5.
//Ambele mesaje se scriu în fișierul "logfile.txt", deoarece nu există restricții privind nivelul
//de logare pentru instanța realLogger.
RealLogger realLogger = new RealLogger("logfile.txt");
realLogger.LogThis("the message 1", 2);
realLogger.LogThis("the message 2", 5);

Console.WriteLine("\nUsing proxy logger\n");
ProxyLogger proxyLogger = new ProxyLogger("logfile.txt");
proxyLogger.LogThis("the message 3", 2);
proxyLogger.LogThis("the message 4", 4);
proxyLogger.LogThis("the message 5", 5);
proxyLogger.LogThis("the message 6", 6);

Console.ReadKey();