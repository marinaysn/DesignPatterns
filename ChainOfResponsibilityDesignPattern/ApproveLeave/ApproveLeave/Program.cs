// See https://aka.ms/new-console-template for more information
using ApproveLeave;
using System.IO;

Console.Title = "Chain of Responsibility Demo";

TeamLead tl = new TeamLead();
ProjectLead pl = new ProjectLead();
DeliveryManager dm = new DeliveryManager();
Director d = new Director();
tl.SetNextApprover(pl);
pl.SetNextApprover(dm);
dm.SetNextApprover(d);

tl.ApproveLeave(3);
tl.ApproveLeave(7);
tl.ApproveLeave(12);
tl.ApproveLeave(17);
tl.ApproveLeave(22);

Console.ReadLine();