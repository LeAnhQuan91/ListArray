internal class Program
{
    private static void Main(string[] args)
    {
        List<int> mylists = new List<int>();
        for(int i=0;i<10;i++)
        {
mylists.Add(i);
        }
        Console.WriteLine(mylists.Count);
        foreach(var item in mylists)
{
    Console.Write(item+",");
}
Console.WriteLine("");
mylists.RemoveAt(5);
foreach(var item in mylists)
{
    Console.Write(item+",");
}

        }
}
//Count số phần tử bao gồm trong list
//Add thêm phần từ trong list
//RemoveAt(index);
//Clear: xoá toàn bộ