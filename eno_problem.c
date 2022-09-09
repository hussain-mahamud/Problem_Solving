#include<stdio.h>
int main(){
    int arr[]={10,100,1};
    int number=0,decrement=1,reminder=0,length=0,i=0,count=-1,temp=0,j=0;
    length=sizeof(arr)/sizeof(int)-1;
    for(i=0;i<=length;i++){
        number=number*10*arr[i]+arr[i];
    }
    number=number-decrement;
    temp=number;
    while(temp>0){
        temp=temp/10;
        count++;
    }

    int arr2[count];
    temp=number;
    int new_count=count;

    while(temp>0){
        reminder=temp%10;
        arr2[count--]=reminder;
        temp=temp/10;
    }
    for(j=0;j<=new_count;j++){
        printf("%d,",arr2[j]);
    }
}
