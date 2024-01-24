using System.ComponentModel.Design;

Console.WriteLine("nguoi thu nhat");

Console.WriteLine("nhap ngay sinh");
int D1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap thang sinh");
int M1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap nam sinh");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("nguoi thu hai");

Console.WriteLine("nhap ngay sinh");
int D2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap thang sinh");
int M2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap nam sinh");
int Y2= Convert.ToInt32(Console.ReadLine());

int diffm = M1 - M2 + (Y1 - Y2) * 12;
int diffd = D1 - D2;

if (diffm < 0) 
{
    Console.WriteLine("Nguoi 1 lon hon nguoi 2");
}
else if (diffm > 0)
{
    Console.WriteLine("nguoi 2 be hon nguoi 1");
}
else if (diffd > 0)
{
    Console.WriteLine("nguoi 1 be hon nguoi 2");
}
else if (diffd < 0)
{
    Console.WriteLine("nguoi 1 lon hon nguoi 2");
}
else
{
    Console.WriteLine("2 nguoi bang tuoi nhau");
}