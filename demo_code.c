#import<stdio.h>
#import<conio.h>
void main()
{

char s[10] ;
char rev_string[10];
int i=0,j=0;
printf("Enter a string\n");
scanf("%s",s);
printf("\n");
int len = printf("%s",s);
printf("len is %d",len);
for(i=len-1;i>=0;i--)
{
    rev_string[j]=s[i];
    j++;
}
rev_string[j]='\0';
printf("\n reverse string is %s",rev_string);
if(strcmp(s,rev_string)==0)
{
    printf("\nString is Palindrome");
}
else
{

    printf("\nString is not  a Palindrome");
}
}
