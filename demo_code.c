#import<stdio.h>
#import<conio.h>
void main()
{
    int num =0,i=0;
    int temp_num=0,reverse_num=0,temp=0;
    printf("Enter a number");
    scanf("%d",&num);


    temp=num;
        while(num)
        {
            temp_num = num%10;
            reverse_num= reverse_num*10+temp_num;
            num = num/10;

        }
    if(temp== reverse_num)
    {

        printf("No is palindrome");
    }



}
