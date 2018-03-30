import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Component, EventEmitter, Input, OnInit, Output, Inject } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgSwitch, NgSwitchDefault } from "@angular/common";


@Component({
    selector: 'my-app',
    template:    `<div style='padding:5px;'>
                        <ul class ="nav nav-tabs" >
                            <li routerLinkActive="active" ><a routerLink="home">Home</a></li>
                            <li routerLinkActive="active" ><a routerLink="employees">Employees</a></li>
                        </ul>
                        <router-outlet></router-outlet>
                  </div>
                `,
})

export class AppComponent {
    
    pageHeader = 'Emolyee Details';
    //pageHeader: string = "Angular 2";

    isDisabled: boolean = true;

    //calc:Calculation = new Calculation();
    //age:number=this.calc.Add1(10,20);

    onClick(): void {
        console.log("Hellow Mr Ashwani");
    }
}
//class Calculation{
    
//   constructor(){
//   }
//    Add1(n1:number, n2:number):number
//    {
//        return n1+n2;
//    }
//}
 