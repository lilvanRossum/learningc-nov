// namespace Program
// {
//     class pro1
//     {
//         public static int itsum(int n, int count)
//         {
//             if (n == 0)
//             {

//                 return count;
//             }
//             return (1 + itsum(n / 10, count));
//
//         }
//         public static void Main(string[] args)
//         {
//             System.Console.WriteLine(itsum(66666666, 0));

//         }
//     }
// }
//ex2
// namespace Program{
//     class pro1{
//         public static int itsum(int n,int cunt,int counter){
//             if(n==0){

//                 return counter;
//             }if(n%10==cunt%10){
//                 return (1+itsum(n/10,cunt,counter));
//             }else{
//                 return itsum(n/10,cunt,counter);
//             }


//         }
//         public static void Main(string[] args){
//             System.Console.WriteLine(itsum(1898,1939,0));

//         }
//     }
// }
//ex3
// namespace Program{
//     class pro1{
//         public static int itsum(int n,int counter){
//             if(n==0){

//                 return counter;
//             }return (n%10+itsum(n/10,counter));


//         }
//         public static void Main(string[] args){
//             System.Console.WriteLine(itsum(55555,0));

//         }
//     }
// }
//binary
// namespace Program{
//     class pro1{
//         public static string binary(int n){
//             if(n==1){
//                 return "1";
//             }
//             if(n%2!=0){
//                 return binary(n/2)+"1";
//             }else{
//                 return binary(n/2)+"0";
//             }



//         }
//         public static void Main(string[] args){
//             System.Console.WriteLine(binary(138));

//         }
//     }
// }
//ex5
// namespace Program{
//     class pro1{
//         public static void NumPrefix(int n){
//             if(n==0){return;}

//             System.Console.Write(""+n);
//             System.Console.WriteLine();
//             NumPrefix(n/10);



//         }
//         public static void Main(string[] args){
//             NumPrefix(29807);

//         }
//     }
// }
//ex6
// using System.Runtime.InteropServices;
// using System.Text.Json.Serialization.Metadata;

// namespace Program{
//     class pro1{
//         public static  bool stat=false;
//         public static void pyremid(int n,int con){
//             if(n==-3){return;}
//             if(n==0){
//                 for(int i=n;i>=1;i--){
//                     System.Console.Write("*");
//                 }System.Console.WriteLine();pyremid(n-1,con);
//             }
//             if(n==)
//             for(int i=0;i<n;i++){
//                 Console.Write("*");
//             }
//             System.Console.WriteLine();
//             pyremid(n-1,con);
//             if(stat==true){
//                 n=con;
//             }
//         }
//         public static void Main(string[] args){
//             pyremid(3,3);

//         }
//     }
// }
class recursion{
    public static int numlow(string abc){
        if(abc.Length==0){
            return 0;
        }string ab = abc.Remove(abc.Length - 1, 1);
        if (abc[(abc.Length-1)]>=97&&abc[(abc.Length-1)]<=122){
            
            return 1+numlow(ab);
        }
        return numlow(ab);        
    }
    public static bool Polyndrome(int[] arr)
    {
            return Polyndrome(arr, 0);
    }
    public static bool Polyndrome(int[] arr, int k)
    {
        if (arr.Length / 2 != k)
        {
            if (arr[k] == arr[arr.Length-k-1])
            {
                return Polyndrome(arr, k+1);
            }
                return false;
        }
            return true;
    }
    public static string funcstr(string abc){
        if(abc.Length==0){
            return "";
        }char val=abc[(abc.Length-1)];
        string ab=abc.Remove(abc.Length-1,1);
        if(abc.Length%3==0){
            return funcstr(ab)+val+"*";
        }
        return ""+funcstr(ab)+val;

    }
    public static string opposite(string abc){
        if(abc.Length==0){
            return "";
        }char val=abc[0];
        string ab=abc.Remove(0,1);
        return ""+opposite(ab)+val;
    }
    public static int sumofdigits(int num){
        if(num<10){return num;}
        return num%10+sumofdigits(num/10);
    }
    public static void Main(string[] args){
        int[] arr={5,7,2,15,15,2,7,5};
        System.Console.WriteLine(Polyndrome(arr));
    }
}