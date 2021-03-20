#include <iostream>
using namespace std;

int top=-1,stki[1000];
char stkc[1000];

void push( int x){
    if(top<1000){
        top=top+1;        
        stki[top]=x;
    }
    else
        cout<<"The stack is full containing 1000 elements \n \n \n";
}

void push(char c){
    if(top<1000){
        top = top +1;
        stkc[top]=c;
    }
    else
        cout<<"the stack is full containing 1000 elements \n \n \n";
}

int size(){
    return top + 1;
}

int pop(){
    if(top > -1){
        top = top-1;
    }
    else
        return -1;
}

char tos(){
    if(top > -1){
        return stkc[top];
    }
    else
        return -1;
}
/*
int search(int x){
    if(top == -1){
        cout<<"Stack is empty, Please enter some elements first \n \n \n ";
    }
    else{
        int bot = top;
        while(1){
            if (stk[bot] == x){
                cout<<"The desired element is at "<< top - bot <<" position  from the top\n \n \n";
                break;
            }
            else {
                bot--;
            }
        }
    }
}
*/
