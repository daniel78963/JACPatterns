using ConsoleBuilder;

IComputerBuilder builder = new StandardComputerBuilder();
ComputerDirector director = new ComputerDirector(builder);

director.BuildComputer();
Computer computer = builder.GetComputer();
computer.DisplayInfo();