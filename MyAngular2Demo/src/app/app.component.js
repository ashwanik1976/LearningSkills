"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.pageHeader = 'Emolyee Details';
        //pageHeader: string = "Angular 2";
        this.isDisabled = true;
    }
    //calc:Calculation = new Calculation();
    //age:number=this.calc.Add1(10,20);
    AppComponent.prototype.onClick = function () {
        console.log("Hellow Mr Ashwani");
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'my-app',
            template: "<div style='padding:5px;'>\n                        <ul class =\"nav nav-tabs\" >\n                            <li routerLinkActive=\"active\" ><a routerLink=\"home\">Home</a></li>\n                            <li routerLinkActive=\"active\" ><a routerLink=\"employees\">Employees</a></li>\n                        </ul>\n                        <router-outlet></router-outlet>\n                  </div>\n                ",
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//class Calculation{
//   constructor(){
//   }
//    Add1(n1:number, n2:number):number
//    {
//        return n1+n2;
//    }
//}
//# sourceMappingURL=app.component.js.map