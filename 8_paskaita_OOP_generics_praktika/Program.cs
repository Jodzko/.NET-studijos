using _8_paskaita_OOP_generics_praktika;

//var newVar = new TwoVariables<int, string>();
//newVar.ChangeT1(450);
//newVar.ChangeT2("Anything");
//newVar.ShowT1();
//newVar.ShowT2();



//var figure = new FourSideGeometricFigure("Square", 4, 5);
//figure.GetArea();
//var show = figure.ToString();
//Console.WriteLine(show);
//var figure1 = new Generator<string>();
//figure1.Show(show);



//var variable = new Type<int, string>(250, "Something");
//variable.GetType(variable.MyProperty);
//variable.GetType(variable.MyProperty2);

//var teams = new SportoLyga<string, string, string, string>();
//teams.AddBasketBallTeam(1, "Lithuania");
//teams.AddFootballTeams(2, "Russia");
//teams.AddVolleyballTeams(3, "Poland");
//teams.AddHandballTeams(4, "Africa");
//teams.AddBasketBallTeam(2, "Spain");
//teams.ShowTeamsBasketball();


var teams = new SportoList();
var footBallTeam = new FootBallTeam("Spain", 15);
var basketBallTeam = new BasketBallTeams("Lithuania", 10);
var basketBallTeam2 = new BasketBallTeams("Spain", 11);
var basketBallTeam3 = new BasketBallTeams("Latvia", 13);
teams.AddTeam(footBallTeam);
teams.AddTeam(basketBallTeam);
teams.AddTeam(basketBallTeam2);
teams.AddTeam(basketBallTeam3);
teams.ShowBaskteballTeams();
teams.ShowFootballTeams();


