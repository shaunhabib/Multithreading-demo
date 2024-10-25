
//=====>Multi-tasking<=====
//Executing multiple task/application simultaneously
//Every task/application is executed in a process which is created by operating system
//Each application is executed in each process
//If we end the task then the process is killed/vanished
//Process uses thread to execute application code
//Every application has a single thread by default to execute a program and that single thread is known as Main thread
//Every application follows single threaded model

//=====>Multi-threading<=====
//Executing multiple task in parallel
//Used for better performance
//Use only when each task has no dependency on each other


#region Single thread execution demo
//Method1();
//Console.WriteLine("===========");
//Method2(false);
//Console.WriteLine("===========");
//Method3();
#endregion

#region Single thread execution demo 2
//Method1();
//Console.WriteLine("===========");
//Method2(true);
//Console.WriteLine("===========");
//Method3();
#endregion


#region Basic thread demo
//=>Use to get current running thread
//=>Main thread has no name. It is anonymous. It's automaticcaly created when a program executes

//Thread t = Thread.CurrentThread;
//Console.WriteLine($"Thread name: {t.Name}, and Id: {t.ManagedThreadId}");

//t.Name = "Main Thread";
//Console.WriteLine($"Thread name: {t.Name}, and Id: {t.ManagedThreadId}");
#endregion

#region Multi threading demo 1
//Thread t1 = new Thread(Method1);
//Thread t2 = new Thread(() => Method2(false));
//Thread t3 = new Thread(Method3);

//t1.Start();
//t2.Start();
//t3.Start();
#endregion

#region Multi threading demo 2
//Thread t1 = new Thread(MethodT1);
//Thread t2 = new Thread(() => MethodT2(false));
//Thread t3 = new Thread(MethodT3);

//t1.Start();
//t2.Start();
//t3.Start();
#endregion


//=======Thread=========
//Threads are lightweight processes
//A thread defines as the execution path of a program
//Each thread defines a unique flow of control
//Threads are executed simultaneously
//Threads are executed by operating system using time-sharing. Means some times for thread 1 some times for thread 2 etc

Console.ReadLine();


void Method1()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"Method1 = {i}");
    }
}

void Method2(bool takeSleep)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"Method2 = {i}");

        if(takeSleep && i == 5)
        {
            Console.WriteLine("Thread is sleeping for 10 seconds");
            Thread.Sleep(10000);
        }
    }
}

void Method3()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"Method3 = {i}");
    }
}

void MethodT1()
{
    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine($"MethodT1 = {i}");
    }
}

void MethodT2(bool takeSleep)
{
    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine($"MethodT2 == {i}");

        if (takeSleep && i == 5)
        {
            Console.WriteLine("Thread is sleeping for 10 seconds");
            Thread.Sleep(10000);
        }
    }
}

void MethodT3()
{
    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine($"MethodT3 === {i}");
    }
}
