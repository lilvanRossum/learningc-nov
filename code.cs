public class IntNode{
    private int value;
    private IntNode next;
    public IntNode(int value){
        this.value=value;
        this.next=null;
    }
    public IntNode(int value,IntNode next){
        this.value=value;
        this.next=next;
    }
    public int GetInfo(){return this.value;}
    public IntNode GetNext(){return this.next;}
    public void SetInfo(int x){this.value=x;}
    public void SetNext(IntNode next){this.next=next;}
    public override string  ToString(){return ""+this.value;}
}
public class program{
    public static IntNode CreateList()
        {
            int x;
            Console.WriteLine("Enter Number");
            x = int.Parse(Console.ReadLine()); 
            IntNode list = new IntNode(x);
            IntNode first = list;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter Number");
                x = int.Parse(Console.ReadLine());
                list.SetNext(new IntNode(x));
                list = list.GetNext();
            }
            return first;
        }


}